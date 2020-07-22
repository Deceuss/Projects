/*  Tax Calculator
 *  This program is a simple tax calculator that uses tax brackets and their associated
 *  tax percentages to calculate the tax payable of an Employeeor or Contractor and then
 *  produce a PDF file with the relevent Tax information listed.
 *  Copyright(C) 2019  Dyfan Batchelor
 *  
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU Affero General Public License as
 *  published by the Free Software Foundation, either version 3 of the
 *  License, or(at your option) any later version.
 *  
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
 *  GNU Affero General Public License for more details.
 *  
 *  You should have received a copy of the GNU Affero General Public License
 *  along with this program.If not, see https://www.gnu.org/licenses/. */

using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace TaxCalculator
{
    public partial class TaxCalculator : Form
    {
        public TaxCalculator()
        {
            InitializeComponent();
        }

        private void txtEmployeeID_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmployeeID.Text))
            {
                string sub = EmployeeIDSubString();

                if (sub == "E") /*If employeeID begins with 'E', ensurse txtHoursWorked is not visible*/
                {
                    lblHoursWorked.Enabled = false;
                    txtHoursWorked.Enabled = false;
                    btnCreateEmployee.Enabled = true;
                    btnCreateContractor.Enabled = false;
                }
                else if (sub == "C") /*If employeeID begins with 'C',Makes txtHoursWorked visible to allow a value to be entered*/
                {
                    lblHoursWorked.Enabled = true;
                    txtHoursWorked.Enabled = true;
                    btnCreateContractor.Enabled = true;
                    btnCreateEmployee.Enabled = false;
                }
                else
                {
                    EmployeeIDFieldMessage();
                }
            }
        }
        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            if (EmployeeCheckEmployee() == true)/*Checks that all fields are filled and that employeeID is in the correct format*/
            {
                /*Creates new Employee object*/
                Employee newEmployee = new Employee(txtEmployeeID.Text, txtFirstName.Text, txtSurname.Text, txtGender.Text, txtDepartment.Text, txtEmail.Text, txtHourlyRate.Text);

                /*displays the information entered into the fields into the display*/
                txtOutput.Text = "Employee ID: " + newEmployee.EmployeeID + Environment.NewLine;
                txtOutput.Text += "First Name: " + newEmployee.FirstName + Environment.NewLine;
                txtOutput.Text += "Surname: " + newEmployee.Surname + Environment.NewLine;
                txtOutput.Text += "Gender: " + newEmployee.Gender + Environment.NewLine;
                txtOutput.Text += "Department: " + newEmployee.Department + Environment.NewLine;
                txtOutput.Text += "Email: " + newEmployee.Email + Environment.NewLine;
                txtOutput.Text += "Hourly Rate: $" + newEmployee.HourlyRate;
                btnCalculateEmployeeTax.Enabled = true;
            }
            else
            {
                /*if any fields have been left empty or employeeID is not in the accepted format this message will
                 appear and the button employee object will not be created*/
                FieldsNotFilledMessage();
            }
            
        }

        private void btnCreateContractor_Click(object sender, EventArgs e)
        {
            if (EmployeeCheckContractor() == true)/*Checks that all fields are filled and that employeeID is in the correct format*/
            {
                /*Creats new Contractor object*/
                Contractor newContractor = new Contractor(txtEmployeeID.Text, txtFirstName.Text, txtSurname.Text, txtGender.Text, txtDepartment.Text, txtEmail.Text, txtHourlyRate.Text, txtHoursWorked.Text);
                
                /*displays the information entered into the fields into the display*/
                txtOutput.Text = "Employee ID: " + newContractor.EmployeeID + Environment.NewLine;
                txtOutput.Text += "First Name: " + newContractor.FirstName + Environment.NewLine;
                txtOutput.Text += "Surname: " + newContractor.Surname + Environment.NewLine;
                txtOutput.Text += "Gender: " + newContractor.Gender + Environment.NewLine;
                txtOutput.Text += "Department: " + newContractor.Department + Environment.NewLine;
                txtOutput.Text += "Email: " + newContractor.Email + Environment.NewLine;
                txtOutput.Text += "Hourly Rate: $" + newContractor.HourlyRate + Environment.NewLine;
                txtOutput.Text += "Hours Worked: " + newContractor.HoursWorked;
                btnCalculateContractorTax.Enabled = true;
            }
            else
            {
                /*if any fields have been left empty or employeeID is not in the accepted format this message will
                 appear and the button contractor object will not be created*/
                FieldsNotFilledMessage();
            }
            
        }

        private void btnCalculateEmployeeTax_Click(object sender, EventArgs e)
        {
            if (EmployeeCheckEmployee() == true)
            {
                btnGeneratePDF.Enabled = true;

                double employeeTax = EmployeeTaxPayble();
                txtOutput.Text += Environment.NewLine + "Tax Payable: $" + employeeTax.ToString();
                btnCalculateEmployeeTax.Enabled = false;
            }
        }

        private void btnCalculateContractorTax_Click(object sender, EventArgs e)
        {
            if (EmployeeCheckContractor() == true)
            {
                double contractorTax = ContractorTaxPayable();
                txtOutput.Text += Environment.NewLine + "Tax Payable: $" + contractorTax.ToString();
                btnGeneratePDF.Enabled = true;
                btnCalculateContractorTax.Enabled = false;
            }
        }

        private void btnGeneratePDF_Click(object sender, EventArgs e)   
        {
            string sub = EmployeeIDSubString();
            if (sub == "E")
            {
                CreatePDF(txtEmployeeID.Text, txtFirstName.Text, txtSurname.Text, txtDepartment.Text);
                
            }
            else if (sub == "C")
            {
                CreatePDF(txtEmployeeID.Text, txtFirstName.Text, txtSurname.Text, txtEmail.Text, txtDepartment.Text);
                
            }
            
            txtOutput.Clear();
            btnGeneratePDF.Enabled = false;
        }

        private void CreatePDF(string employeeID, string firstName, string lastName, string email, string department)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "ContractorTax";
            sfd.Filter = "PDF Files|*.pdf";
            sfd.FilterIndex = 0;

            string fileName = String.Empty;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fileName = sfd.FileName;

                System.IO.FileStream fs = new FileStream(fileName, FileMode.Create);
                //the below line creates an instance of the document class which represents the PDF document itself
                Document document = new Document(PageSize.A4, 25, 25, 30, 30);
                //Writer class using the document and the filestream in the constructor
                PdfWriter writer = PdfWriter.GetInstance(document, fs);
                //you can add meta data to the file using document.AddAuthor and such

                //Open the document to enable writing
                document.Open();
                //Add text to the document
                //The following 3 strings are used to extract employeeTax from the txtOutput text box
                string txtOutputString = txtOutput.Text;
                string taxPayableSTring = txtOutputString.Substring(txtOutputString.IndexOf("Tax Payable: $"));
                string contractorTaxString = taxPayableSTring.Substring(14);
                double contractorTax = double.Parse(contractorTaxString);
                double hoursWorked = double.Parse(txtHoursWorked.Text);
                double hourlyRate = double.Parse(txtHourlyRate.Text);
                double weeklyIncome = hoursWorked * hourlyRate;
                document.Add(new Paragraph("Employee ID: " + employeeID + Environment.NewLine +
                                        "Name: " + firstName + " " + lastName + Environment.NewLine +
                                        "Email: " + email + Environment.NewLine +
                                        "Department: " + department + Environment.NewLine +
                                        "Salary: $" + weeklyIncome.ToString() + Environment.NewLine +
                                        "Tax Payable: $" + contractorTax.ToString()));
                //ALWAYS CLOSE TEH DOCUMENT, WRITER INSTANCE AND FILESTREAM
                document.Close();

                writer.Close();
                fs.Close();
            }
        }

        private void CreatePDF(string employeeID, string firstName, string lastName, string department)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "EmployeeTax";
            sfd.Filter = "PDF Files|*.pdf";
            sfd.FilterIndex = 0;

            string fileName = String.Empty;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fileName = sfd.FileName;

                System.IO.FileStream fs = new FileStream(fileName, FileMode.Create);
                //the below line creates an instance of the document class which represents the PDF document itself
                Document document = new Document(PageSize.A4, 25, 25, 30, 30);
                //Writer class using the document and the filestream in the constructor
                PdfWriter writer = PdfWriter.GetInstance(document, fs);
                //you can add meta data to the file using document.AddAuthor and such

                //Open the document to enable writing
                document.Open();
                //Add text to the document
                //The following 3 strings are used to extract employeeTax from the txtOutput text box
                string txtOutputString = txtOutput.Text;
                string taxPayableSTring = txtOutputString.Substring(txtOutputString.IndexOf("Tax Payable: $"));
                string employeeTaxString = taxPayableSTring.Substring(14);
                //employeeTax is is parsed from the string above
                double employeeTax = double.Parse(employeeTaxString);
                double hourlyRate = double.Parse(txtHourlyRate.Text);
                double weeklyIncome = Employee.HRS_WORK_WEEK * hourlyRate;
                document.Add(new Paragraph("Employee ID: " + employeeID + Environment.NewLine +
                                        "Name: " + firstName + " " + lastName + Environment.NewLine +
                                        "Department: " + department + Environment.NewLine +
                                        "Salary: $" + weeklyIncome.ToString() + Environment.NewLine +
                                        "Tax Payable: $" + employeeTax.ToString()));
                //ALWAYS CLOSE TEH DOCUMENT, WRITER INSTANCE AND FILESTREAM
                document.Close();

                writer.Close();
                fs.Close();
            }
        }

        //If fields are empty, will return this message
        private void FieldsNotFilledMessage()
        {
            /*This message displays when txtEmployeeID is not filled out in the correct format*/
            MessageBox.Show("Please ensure that all fields are filled out correctly.");
        }

        /**EmployeeIDMessage()**/
        /*This method simply displays a message box to explain the correct 
        format that the EmployeeID must be in.*/
        private void EmployeeIDFieldMessage()
        {
            MessageBox.Show("Please enter EmployeeID in the acceptable format: " + Environment.NewLine
                        + "Employee ID must begin with either a “E” or a “C” to signify whether the employee is full time or a contractor."
                        + Environment.NewLine + "This must be followed by a four-digit number(that is greater than 1000)."
                        + Environment.NewLine + "For example: E1234 or C5678.");
        }

        //Checks the Hourly Rate field to ensure the value entered is a double and is Greater than 0
        private bool HourlyRateCheck()
        {
            bool hourlyRateCheck = false;
            string input = txtHourlyRate.Text;
            double hourlyRate;
            bool isHourlyRateDouble = double.TryParse(input, out hourlyRate);
            if (!string.IsNullOrEmpty(input) && isHourlyRateDouble && hourlyRate > 0)
            {
                hourlyRateCheck = true;
            }
            else
            {
                MessageBox.Show("Please ensure Hourly Rate has been filled out and is a valid number.");
            }
            return hourlyRateCheck;
        }

        //Checks the Hours Worked field to ensure the value entered is a double and is Greater than 0
        private bool HoursWorkedCheck()
        {
            bool hoursWorkedCheck = false;
            string input = txtHoursWorked.Text;
            double hoursWorked;
            bool isHoursWorkedDouble = double.TryParse(input, out hoursWorked);
            if (isHoursWorkedDouble && hoursWorked > 0)
            {
                hoursWorkedCheck = true;
            }
            else
            {
                MessageBox.Show("Please ensure Hours Worked has been filled out and is a valid number.");
            }
            return hoursWorkedCheck;
        }

        /**EmployeeIDCheckEmployee()**/
        /*This method checks the txtEmployeeID text to determine if it is   
        in the correct format for employees.*/
        private bool EmployeeCheckEmployee()
        {
            bool isValid = false;
            bool eFormat = false;
            bool numFormat = false;
            bool firstNameFilled = false;
            bool surnameFilled = false;
            bool genderFilled = false;
            bool departmentFilled = false;
            bool emailFilled = false;
            bool hourlyRateFilled = HourlyRateCheck();
            string input = txtEmployeeID.Text; /*The string value entered into txtEmployeeID*/
            string sub = input.Substring(0, 1); /*The first Letter of the txtEmployeeID is extracted*/

            /*Check all fields for entries*/
            /*First name field check*/
            if (!string.IsNullOrEmpty(txtFirstName.Text))
            {
                firstNameFilled = true;
            }

            /*Surname field check*/
            if (!string.IsNullOrEmpty(txtSurname.Text))
            {
                surnameFilled = true;
            }

            /*Gender field check*/
            if (!string.IsNullOrEmpty(txtFirstName.Text))
            {
                genderFilled = true;
            }

            /*Department field check*/
            if (!string.IsNullOrEmpty(txtDepartment.Text))
            {
                departmentFilled = true;
            }

            /*Email Field Check*/
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                emailFilled = true;
            }

            if (!string.IsNullOrEmpty(txtEmployeeID.Text) && txtEmployeeID.Text.Length == 5 && sub == "E")/*Checks to see if employeeID has 5 characters*/
            {
                numFormat = true;
                eFormat = true;
            }
            else
            {
                EmployeeIDFieldMessage();
            }

            if (eFormat == true && numFormat == true && firstNameFilled == true && surnameFilled == true && genderFilled == true && departmentFilled == true && emailFilled == true && hourlyRateFilled == true)/*If all conditions for the format of employeeID are met, isValid is set to true*/
            {
                isValid = true;
            }
            
            return isValid;
        }

        /**EmployeeIDCheckContractor()**/
        /*This method checks the txtEmployeeID text to determine if it is   
        in the correct format for contractor.*/
        private bool EmployeeCheckContractor()
        {
            bool isValid = false;
            if (!string.IsNullOrEmpty(txtEmployeeID.Text))
            {
                bool cFormat = false;
                bool numFormat = false;
                bool firstNameFilled = false;
                bool surnameFilled = false;
                bool genderFilled = false;
                bool departmentFilled = false;
                bool emailFilled = false;
                bool hourlyRateFilled = HourlyRateCheck();
                bool hoursWorkedFilled = HoursWorkedCheck();
                string input = txtEmployeeID.Text; /*The string value entered into txtEmployeeID*/
                string sub = input.Substring(0, 1); /*The first Letter of the txtEmployeeID is extracted*/

                /*First name field check*/
                if (!string.IsNullOrEmpty(txtFirstName.Text))
                {
                    firstNameFilled = true;
                }

                /*Surname field check*/
                if (!string.IsNullOrEmpty(txtSurname.Text))
                {
                    surnameFilled = true;
                }

                /*Gender field check*/
                if (!string.IsNullOrEmpty(txtFirstName.Text))
                {
                    genderFilled = true;
                }

                /*Department field check*/
                if (!string.IsNullOrEmpty(txtDepartment.Text))
                {
                    departmentFilled = true;
                }

                /*Email Field Check*/
                if (!string.IsNullOrEmpty(txtEmail.Text))
                {
                    emailFilled = true;
                }

                if (txtEmployeeID.Text.Length == 5)
                {
                    numFormat = true;
                }

                if (sub == "C") /*The extracted first letter from employeeID is compared to "E"*/
                {
                    cFormat = true;
                }

                if (cFormat == true && numFormat == true && firstNameFilled == true && surnameFilled == true && genderFilled == true && departmentFilled == true && emailFilled == true && hourlyRateFilled == true && hoursWorkedFilled == true)/*If all conditions for the format of employeeID are met, isValid is set to true*/
                {
                    isValid = true;
                }
            }
            return isValid;
        }

        private double EmployeeTaxPayble()
        {
            MessageBox.Show("Please select the text file containing current tax rates.");
            OpenFileDialog chooseFile = new OpenFileDialog();
            chooseFile.Filter = "TXT Files|*.txt";
            chooseFile.FilterIndex = 0;
            string filePath = String.Empty;
            /*Variables required for calculating tax*/
            double hourlyRate = double.Parse(txtHourlyRate.Text);
            double weeklyIncome = Employee.HRS_WORK_WEEK * hourlyRate;
            double amountTracker = 0;
            double employeeTax = 0;
            if (chooseFile.ShowDialog() == DialogResult.OK)
            {
                filePath = chooseFile.FileName;
                double[] incomeBracket = ExtractIncomeBracket(filePath);/*Gets the income brakcet array*/
                double[] taxPercentage = ExtractTaxPercentage(filePath);/*Gets the tax percentage array*/

                /*Compares the incomeBracket array value to the weekly income, once the incomeBracket array value
                 is larger than the weekly income, the loop goes into the else statement and calculates tax on the
                 remainder then break*/
                foreach (double i in incomeBracket)
                {
                    int counter = Array.IndexOf(incomeBracket, i);
                    if (i < weeklyIncome)
                    {
                        employeeTax = employeeTax + ((i - amountTracker) * taxPercentage[counter]);
                        amountTracker = amountTracker + (incomeBracket[counter + 1] - incomeBracket[counter]);
                    }
                    else
                    {
                        double remainder = weeklyIncome - amountTracker;
                        employeeTax = employeeTax + (remainder * taxPercentage[counter]);
                        break;
                    }
                }  
            }
            return employeeTax;
        }

        /*This method extracts the income brackets from the Rates.txt file and puts them into an array*/
        private double[] ExtractIncomeBracket(string filePath)
        {
            /*Sets up file to be read*/
            string FilePath = filePath;
            var fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            var sr = new StreamReader(fs, Encoding.UTF8);

            /*Strings and a line counter (lineNum) to extract lines from the file Rates.txt and assign them to string objects*/
            string line = String.Empty;
            int lineNum = 0;
            string lineOne = String.Empty;

            /*Assigns the lines in the Rates.txt file to string objects*/
            while ((line = sr.ReadLine()) != null)
            {
                if (lineNum == 0)
                {
                    lineOne = line;
                }
                else if (lineNum > 0)
                {
                    break;
                }
                lineNum++;
            }

            /*String arrays for the sub strings which are then parsed to the double arrays*/
            string[] stringSeperator = new string[] { ", " };/*Used as the deliminator in the Split() method*/
            /*breaks the lineOne string into sub strings and places them into an array*/
            string[] incomeBracketSub = lineOne.Split(stringSeperator, StringSplitOptions.None);
            double[] incomeBracket = new double[5];

            foreach (string i in incomeBracketSub)
            {
                int counter = Array.IndexOf(incomeBracketSub, i);
                incomeBracket[counter] = double.Parse(i);
            }
            return incomeBracket;
        }

        /*This method extarcts the tax percentage from the Rates.txt file and puts them into an array*/
        private double[] ExtractTaxPercentage(string filePath)
        {
            /*Sets up file to be read*/
            string FilePath = filePath;
            var fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            var sr = new StreamReader(fs, Encoding.UTF8);

            /*Strings and a line counter (lineNum) to extract lines from the file Rates.txt and assign them to string objects*/
            string line = String.Empty;
            int lineNum = 0;
            string lineTwo = String.Empty;

            /*Assigns the lines in the Rates.txt file to string objects*/
            while ((line = sr.ReadLine()) != null)
            {
                if (lineNum == 1)
                {
                    lineTwo = line;
                }
                else if (lineNum > 1)
                {
                    break;
                }
                lineNum++;
            }
            

            /*String arrays for the sub strings which are then parsed to the double arrays*/
            string[] stringSeperator = new string[] { ", " };/*Used as the deliminator in the Split() method*/
            /*breaks the lineTwo string into sub strings and places them into an array*/
            string[] taxPercentageSub = lineTwo.Split(stringSeperator, StringSplitOptions.None);
            double[] taxPercentage = new double[5];

            foreach (string i in taxPercentageSub)
            {
                int counter = Array.IndexOf(taxPercentageSub, i);
                taxPercentage[counter] = double.Parse(i);
            }
            return taxPercentage;
        }

        /*This method calculates the tax payable by a contractor*/
        private double ContractorTaxPayable()
        {
            double hourlyRate = double.Parse(txtHourlyRate.Text);
            double hoursWorked = double.Parse(txtHoursWorked.Text);
            double weeklyIncome = hoursWorked * hourlyRate;
            double contractorTax = weeklyIncome * Contractor.TAX_RATE;
            return contractorTax;
        }

        /*This method splits the string in txtEmployeeID into a sub string*/
        private string EmployeeIDSubString()
        {
            string input = txtEmployeeID.Text; /*The string value entered into txtEmployeeID*/
            string sub = input.Substring(0, 1); /*The first Letter of the txtEmployeeID is extracted*/
            return sub;
        }
    }

 }

