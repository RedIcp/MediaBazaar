﻿using MediaBazaar.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MediaBazaar
{
    class ContractManagement
    {
        // fields

        // sql
        public static string CREATE_CONTRACT = "INSERT INTO Contract (EmployeeID, JobTitle, WorkHoursPerWeek, SalaryPerHour, StartDate) VALUES (@EmployeeID, @JobTitle, @WorkHoursPerWeek, @SalaryPerHour, @StartDate);";
        public static string GET_ALL_CONTRACTS = "SELECT * FROM Contract ORDER BY EmployeeID;";
        public static string UPDATE_CONTRACT = "UPDATE Contract SET JobTitle = @JobTitle, WorkHoursPerWeek = @WorkHoursPerWeek, SalaryPerHour = @SalaryPerHour, StartDate = @StartDate;";
        public static string DELETE_CONTRACT_BY_ID = "DELETE FROM Contract WHERE EmployeeID = @EmployeeID";

        public static string CONTRACT_BY_EMPLOYEEID = "SELECT * FROM Contract WHERE EmployeeID = @EmployeeID;";
        public static string END_CONTRACT = "UPDATE Contract SET EndDate = @EndDate, ReasonForTermination = @ReasonForTermination WHERE EmployeeID = @EmployeeID;";

        // properties

        // constructor
        public ContractManagement()
        {

        }

        // methods


        // end contract
    }
}