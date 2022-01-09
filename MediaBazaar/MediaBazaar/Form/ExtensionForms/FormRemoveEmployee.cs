﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ClassLibraryProject.Class;
using ClassLibraryProject.ManagmentClasses;
using MySql.Data.MySqlClient;


namespace AdminBackups
{
    public partial class FormRemoveEmployee : Form
    {
        Person employee;
        Contract contract;
        int saveCount;
        public FormRemoveEmployee(Person p, Contract c)
        {
            InitializeComponent();
            this.employee = p;
            this.contract = c;
            lblEmployee.Text = $"{p.EmployeeID} - {p.FirstName} {p.LastName}";
            saveCount = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UpdateContract() == true)
            {
                Close();
            }
        }
        public bool UpdateContract()
        {
            string employeeID = employee.EmployeeID.ToString();
            string reasonForTermination = tbxReasonTermination.Text;
            if (string.IsNullOrEmpty(reasonForTermination))
            {
                MessageBox.Show("Please enter a reason for termination");
                return false;
            }

            string contractEndDate;
            if (Regex.IsMatch(tbxEndDate.Text, @"\d{4}\-(0[1-9]|1[012])\-(0[1-9]|[12][0-9]|3[01])$"))
            {
                contractEndDate = tbxEndDate.Text;
                if (string.IsNullOrEmpty(contractEndDate))
                {
                    MessageBox.Show("Please enter a contract end date");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid End date");
                return false;
            }

            MySqlConnection conn = Utils.GetConnection();
            string sql = ContractManagement.END_CONTRACT;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmd.Parameters.AddWithValue("@ReasonForTermination", reasonForTermination);
                cmd.Parameters.AddWithValue("@EndDate", contractEndDate);
                conn.Open();

                int numAffectedRows = cmd.ExecuteNonQuery();
                return true;
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
            return false;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            if (saveCount == 1)
            {
                MessageBox.Show("Make sure to save the data");
                saveCount = 0;
            }
        }
    }
}
