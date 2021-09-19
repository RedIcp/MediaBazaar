﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaar
    {
        abstract class Employee
        {

        
            // fields
            private static int nextEmployeeID = 1;
            private int employeeID;
            private string lastname;
            private string firstname;
            private string gender;
            private int phonenumber;
            private string email;
            private string address;
            private DateTime dateofbirth;
            private int bsn;
            private string username;
            private string password;
            private Contract contract; /* every employee has 1 contract*/

        // properties

        public int EmployeeID { get; private set; }


        // constructors

        public string Username { get; private set; }
        public  string Password { get; private set; }

        public Contract Contract { get { return contract; } private set; }

        public Employee(int employeeID, string lastname, string firstname, string gender, int phonenumber, string email, string address, DateTime dateofbirth, int bsn, string username, string password)
            {
                this.employeeID = nextEmployeeID;
                nextEmployeeID++;
                this.lastname = lastname;
                this.firstname = firstname;
                this.gender = gender;
                this.phonenumber = phonenumber;
                this.email = email;
                this.address = address;
                this.dateofbirth = dateofbirth;
                this.bsn = bsn;
                this.username = username;
                this.password = password;
            }

        public Employee(string lastname, string firstname, int bsn, string username, string password)
            {
                this.lastname = lastname;
                this.firstname = firstname;
                this.bsn = bsn;
                this.username = username;
                this.password = password;
            }

         // methodes

        public void MostPreferedTimeToWork(string day, string time)
            {

            }

         public void LeastPreferedTimeToWork(string day, string time)
            {

            }

         public string Tostring()
            {
                return null;
            }

        }
    }
