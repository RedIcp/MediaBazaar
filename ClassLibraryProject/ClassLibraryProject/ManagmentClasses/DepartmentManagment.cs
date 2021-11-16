﻿using ClassLibraryProject.Class;
using ClassLibraryProject.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace ClassLibraryProject.ManagmentClasses
{
    public class DepartmentManagment
    {
        IDepartmentManagment iDepartmentManagment;

        public DepartmentManagment(IDepartmentManagment departmentManagment)
        { 
            iDepartmentManagment = departmentManagment;
        }

        //Get all departments
        public DataTable ViewAllDepartments()
        {
            return iDepartmentManagment.ViewAllDepartments();
        }

        //Add a new department
        public void AddDepartment(string Name, string Head, string CompanyID)
        {
            iDepartmentManagment.AddDepartment(Name, Head, CompanyID);
        }

        // edit a department
        public void EditDepartment(string Name, string Head, string DepartmetnID)
        {
            iDepartmentManagment.EditDepartment(Name, Head, DepartmetnID);
        }
    }
}
