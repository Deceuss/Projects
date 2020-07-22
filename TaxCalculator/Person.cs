
/*
 * Open Colleges - Module 8 Part B Assessment - Tax Calculator
 * Author - Mike Ormond
 * 
 * ©2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    //create Person class
    class Person
    {
        private string firstName;
        private string surname;
        private string gender;

        //get and set
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        //Default Person Constructor
        public Person ()
        {
            this.FirstName = "John";
            this.Surname = "Doe";
            this.Gender = "Male";
        }

        //Person constructor
        public Person (string firstname, string surname, string gender)
        {
            this.FirstName = firstname;
            this.Surname = surname;
            this.Gender = gender;
        }
    }

    //create Employee class which extends Person class
    class Employee : Person
    {
        private string employeeID;
        private string department;
        private string email;
        private string hourlyRate;
        public const int HRS_WORK_WEEK = 40;

        //get and set
        public string EmployeeID
        {
            get
            {
                return employeeID;
            }
            set
            {
                employeeID = value;
            }
        }
        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string HourlyRate
        {
            get
            {
                return hourlyRate;
            }
            set
            {
                hourlyRate = value;
            }
        }

        //Default Employee constructor
        public Employee()
        {
            this.EmployeeID = "E1001";
            this.Department = "Accounting";
            this.Email = "Employee@company.com";
            this.HourlyRate = "30";
        }

        //Employee constructor
        public Employee (string employeeID, string firstname, string surname, string gender, string department, string email, string hourlyRate)
        {

            this.EmployeeID = employeeID;
            this.FirstName = firstname;
            this.Surname = surname;
            this.Gender = gender;
            this.Department = department;
            this.Email = email;
            this.HourlyRate = hourlyRate;
        }
    }

    //create Contractor class which extend from Employee class
    class Contractor : Employee
    {
        private string hoursWorked;
        public const double TAX_RATE = 0.2;

        //get and set
        public string HoursWorked
        {
            get
            {
                return hoursWorked;
            }
            set
            {
                hoursWorked = value;
            }
        }

        public Contractor()
        {
            this.HoursWorked = "10";
        }
        //Contractor constructor
        public Contractor (string employeeID, string firstname, string surname, string gender, string department, string email, string hourlyRate, string hoursWorked)
        {
            this.EmployeeID = employeeID;
            this.FirstName = firstname;
            this.Surname = surname;
            this.Gender = gender;
            this.Department = department;
            this.Email = email;
            this.HourlyRate = hourlyRate;
            this.HoursWorked = hoursWorked;
        }
    }
}
