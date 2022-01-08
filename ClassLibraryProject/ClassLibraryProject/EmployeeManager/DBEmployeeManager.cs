﻿using ClassLibraryProject.ChildClasses;
using ClassLibraryProject.Class;
using ClassLibraryProject.dbClasses;
using ClassLibraryProject.dbClasses.AutoSchedule;
using ClassLibraryProject.Interfaces;
using ClassLibraryProject.ManagmentClasses;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;

namespace ClassLibraryProject
{
    public class DBEmployeeManager : IDBEmployeeManagerOffice, IDBEmployeeManagerAdmin
    {
        // sql
        public static string CREATE_EMPLOYEE = "INSERT INTO Employee (FirstName, LastName, UserName, Password, BSN, Active, City, Email, PhoneNumber, DateOfBirth, StreetName, ZipCode) VALUES (@FirstName, @LastName, @Username, @Password, @BSN, @Active, @City, @Email, @PhoneNumber, @DateOfBirth, @StreetName, @ZipCode);";
        public static string READ_EMPLOYEES = "SELECT * FROM Employee as e INNER JOIN Contract as c on e.EmployeeID = c.EmployeeID WHERE e.Active = @Active;";
        public static string UPDATE_EMPLOYEE = "UPDATE Employee SET FirstName = @FirstName, LastName = @LastName, City = @City, PhoneNumber = @PhoneNumber, StreetName = @StreetName, ZipCode = @ZipCode WHERE EmployeeID = @EmployeeID;";
        public static string DELETE_EMPLOYEE = "UPDATE Employee SET Active = @Active WHERE EmployeeID = @EmployeeID;";

        public static string GET_EMPLOYEE_ID = "SELECT * FROM Employee WHERE Email = @Email AND Active = @Active;";

        /*public static string CREATE_EMPLOYEE = "INSERT INTO Employee (FirstName, LastName, UserName, Password, BSN, Active, Address, Email, PhoneNumber, DateOfBirth) VALUES (@FirstName, @LastName, @Username, @Password, @BSN, @Active, @City, @Email, @PhoneNumber, @DateOfBirth);";
        public static string GET_ALL_EMPLOYEES = "SELECT * FROM Employee ORDER BY EmployeeID LIMIT 25;";
        public static string UPDATE_EMPLOYEE = "UPDATE Employee SET FirstName = @FirstName, LastName = @LastName, Address = @City, PhoneNumber = @PhoneNumber WHERE EmployeeID = @EmployeeID;";
        public static string DELETE_EMPLOYEE_BY_ID = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";*/

        public bool CreateEmployee(Employee e)
        {
            if (!Regex.IsMatch(e.ZipCode, @"^[0-9]{4}[A-Z]{2}$"))
            {
                return false;
            }
            if (!Regex.IsMatch(e.Email, @"[a-z]@mb.com"))
            {
                return false;
            }
            if (!Regex.IsMatch(e.BSN.ToString(), @"\b[0-9]{8,9}\b"))
            {
                return false;
            }
            if (!Regex.IsMatch(e.PhoneNumber, @"^(\+)316[0-9]{8}$"))
            {
                return false;
            }
            if (!Regex.IsMatch(e.DateOfBirth.ToString("dd/MM/yyyy"), @"((?:0[0-9])|(?:[1-2][0-9])|(?:3[0-1]))\/((?:0[1-9])|(?:1[0-2]))\/(\d{4})"))
            {
                return false;
            }

            MySqlConnection conn = Utils.GetConnection();
            string sql = CREATE_EMPLOYEE;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@FirstName", e.FirstName);
                cmd.Parameters.AddWithValue("@LastName", e.LastName);
                cmd.Parameters.AddWithValue("@Username", e.Username);
                cmd.Parameters.AddWithValue("@Password", e.Password);
                cmd.Parameters.AddWithValue("@BSN", e.BSN);
                cmd.Parameters.AddWithValue("@Active", 1);
                cmd.Parameters.AddWithValue("@City", e.City);
                cmd.Parameters.AddWithValue("@Email", e.Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", e.PhoneNumber);
                cmd.Parameters.AddWithValue("@DateOfBirth", e.DateOfBirth);
                cmd.Parameters.AddWithValue("@StreetName", e.StreetName);
                cmd.Parameters.AddWithValue("@ZipCode", e.ZipCode);

                int numCreatedRows = cmd.ExecuteNonQuery();
            }
            catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return true;
        }
        public List<Employee> ReadEmployees()
        {
            List<Employee> employees = new List<Employee>();

            MySqlConnection conn = Utils.GetConnection();
            string sql = READ_EMPLOYEES;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@Active", 1);

                MySqlDataReader reader = cmd.ExecuteReader();

                Employee employee;

                while (reader.Read())
                {
                    int employeeID = reader.GetInt32(0);
                    string firstName = reader.GetString(1);
                    string lastName = reader.GetString(2);
                    string username = reader.GetString(3);
                    string password = reader.GetString(4);
                    int bsn = reader.GetInt32(5);
                    string city = reader.GetString(7);
                    string email = reader.GetString(8);
                    string phoneNumber = reader.GetString(9);
                    DateTime dateOfBirth = reader.GetDateTime(10);
                    string streetName = reader.GetString(12);
                    string zipCode = reader.GetString(13);
                    string jobTitle = reader.GetString(16);

                    if (jobTitle == "ADMIN")
                    {
                        IAddEmployee addEmployee = new AdminAddEmployee();
                        IEmployeeManagerAdmin employeeManagerAdmin = new EmployeeManager();

                        employee = new Admin(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, addEmployee, employeeManagerAdmin);
                        employees.Add(employee);
                    } else if (jobTitle == "CEO")
                    {
                        employee = new CEO(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
                        employees.Add(employee);
                    } else if (jobTitle == "DEPOT MANAGER")
                    {
                        AutoScheduleManagment autoSchedule = new AutoScheduleManagment(new AsignShiftManagment(new DbAsignShiftManagment()), new EmployeesAvailibleManagment(new DbEmployeesAvailibleManagment()), new DeletePlanningForTheWeekManagment(new DbDeletePlanningForTheWeekManagment()), new AmountOfEmployeesNeededManagment(new DbAmountOfEmployeesNeededManagment()));
                        employee = new DepotManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, new DepotDepartmentsManagment(new dbDepotDepartments()), autoSchedule);
                        employees.Add(employee);
                    } else if (jobTitle == "DEPOT EMPLOYEE")
                    {
                        employee = new DepotEmployee(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
                        employees.Add(employee);
                    } else if (jobTitle == "OFFICE MANAGER")
                    {
                        employee = new OfficeManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
                        employees.Add(employee);
                    } else if (jobTitle == "PRODUCT MANAGER")
                    {
                        employee = new ProductManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
                        employees.Add(employee);
                    } else if (jobTitle == "SALES MANAGER")
                    {
                        AutoScheduleManagment autoSchedule = new AutoScheduleManagment(new AsignShiftManagment(new DbAsignShiftManagment()), new EmployeesAvailibleManagment(new DbEmployeesAvailibleManagment()), new DeletePlanningForTheWeekManagment(new DbDeletePlanningForTheWeekManagment()) , new AmountOfEmployeesNeededManagment(new DbAmountOfEmployeesNeededManagment()));
                        employee = new SalesManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, new SalesDepartmentsManagment(new dbSalesDepartments()), autoSchedule);
                        employees.Add(employee);
                    }
                    else if (jobTitle == "SALES REPRESENTATIVE")
                    {
                        employee = new SalesRepresentative(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
                        employees.Add(employee);
                    }
                }
            }
            catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return employees;
        }

        public bool DeleteEmployee(Employee e)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEmployee(Employee e)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeID(string givenEmail, string jobTitle)
        {
            MySqlConnection conn = Utils.GetConnection();
            string sql = GET_EMPLOYEE_ID;

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@Active", 1);
                cmd.Parameters.AddWithValue("@Email", givenEmail);

                MySqlDataReader reader = cmd.ExecuteReader();

                Employee employee;

                while (reader.Read())
                {
                    int employeeID = reader.GetInt32(0);
                    string firstName = reader.GetString(1);
                    string lastName = reader.GetString(2);
                    string username = reader.GetString(3);
                    string password = reader.GetString(4);
                    int bsn = reader.GetInt32(5);
                    string city = reader.GetString(7);
                    string email = reader.GetString(8);
                    string phoneNumber = reader.GetString(9);
                    DateTime dateOfBirth = reader.GetDateTime(10);
                    string streetName = reader.GetString(12);
                    string zipCode = reader.GetString(13);

                    if (jobTitle == "ADMIN")
                    {
                        IAddEmployee addEmployee = new AdminAddEmployee();
                        IEmployeeManagerAdmin employeeManagerAdmin = new EmployeeManager();

                        employee = new Admin(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, addEmployee, employeeManagerAdmin);
                        return employee;
                    }
                    else if (jobTitle == "CEO")
                    {
                        employee = new CEO(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
                        return employee;
                    }
                    else if (jobTitle == "DEPOT MANAGER")
                    {
                        AutoScheduleManagment autoSchedule = new AutoScheduleManagment(new AsignShiftManagment(new DbAsignShiftManagment()), new EmployeesAvailibleManagment(new DbEmployeesAvailibleManagment()), new DeletePlanningForTheWeekManagment(new DbDeletePlanningForTheWeekManagment()), new AmountOfEmployeesNeededManagment(new DbAmountOfEmployeesNeededManagment()));
                        employee = new DepotManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, new DepotDepartmentsManagment(new dbDepotDepartments()), autoSchedule);
                        return employee;
                    }
                    else if (jobTitle == "DEPOT EMPLOYEE")
                    {
                        employee = new DepotEmployee(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
                        return employee;
                    }
                    else if (jobTitle == "OFFICE MANAGER")
                    {
                        employee = new OfficeManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
                        return employee;
                    }
                    else if (jobTitle == "PRODUCT MANAGER")
                    {
                        employee = new ProductManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
                        return employee;
                    }
                    else if (jobTitle == "SALES MANAGER")
                    {
                        AutoScheduleManagment autoSchedule = new AutoScheduleManagment(new AsignShiftManagment(new DbAsignShiftManagment()), new EmployeesAvailibleManagment(new DbEmployeesAvailibleManagment()), new DeletePlanningForTheWeekManagment(new DbDeletePlanningForTheWeekManagment()), new AmountOfEmployeesNeededManagment(new DbAmountOfEmployeesNeededManagment()));
                        employee = new SalesManager(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password, new SalesDepartmentsManagment(new dbSalesDepartments()), autoSchedule);
                        return employee;
                    }
                    else if (jobTitle == "SALES REPRESENTATIVE")
                    {
                        employee = new SalesRepresentative(employeeID, firstName, lastName, phoneNumber, email, zipCode, streetName, city, dateOfBirth, bsn, username, password);
                        return employee;
                    }
                }
            }
            catch (MySqlException msqEx)
            {
                Debug.WriteLine(msqEx);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return null;
        }

        /* Send Email to new Employee */
        public void SendEmail(Employee e)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("mediabazaar.hq@gmail.com", "MediaBazaar21"),
                EnableSsl = true,
            };

            StringBuilder message = new StringBuilder();

            message.Append("<h1>Welcome to Media Bazaar!</h1>");
            message.AppendLine("<h2>Here is your account information:</h2>");
            message.AppendLine("<p>You can use these credentials to log in to the different Media Bazaar apps and the website</p>");
            message.AppendLine($"<p>                username: {e.Username}</p>");
            message.AppendLine($"<p>                password: {e.Password}</p>");
            message.AppendLine($"<p>                email: {e.Email}</p>");
            message.AppendLine("<p>Please change your password on our website: i474883core.venus.fhict.nl</p>");
            message.AppendLine("<p>If you run into any problems please contact us at mediabazaar.hq@gmail.com</p>");

            var mailMessage = new MailMessage
            {
                From = new MailAddress("mediabazaar.hq@gmail.com"),
                Subject = "Welcome to Media Bazaar!",
                Body = message.ToString(),
                IsBodyHtml = true,
            };

            mailMessage.To.Add(e.PersonalEmail);

            smtpClient.Send(mailMessage);
        }

        /*public void Email(string Password, string Username, string Email)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("MediaBazaar.HQ@gmail.com", "MediaBazaar21"),
                EnableSsl = true,
            };

            StringBuilder message = new StringBuilder();

            message.Append(" <h1>Here is your acount information.</h1>");
            message.AppendLine("<p>Here is your acount information.</p>");
            message.AppendLine("<p>You can use these in the diferent mediabazaar apps and websites.</p>");
            message.AppendLine($"<p>                Username: {Username}</p>");
            message.AppendLine($"<p>                password: {Password}</p>");
            message.AppendLine("<p> Please change your password on i474883core.venus.fhict.nl </p>");
            message.AppendLine("<p> Contact us with this email adress if you run in to any problems: nazibul.kabir.srv@gmail.com</p>");

            var mailMessage = new MailMessage
            {
                From = new MailAddress("MediaBazaar.HQ@gmail.com"),
                Subject = "Mediabazaar acount information",
                Body = message.ToString(),
                IsBodyHtml = true,
            };
            mailMessage.To.Add(Email);

            smtpClient.Send(mailMessage);
        }*/
    }
}
