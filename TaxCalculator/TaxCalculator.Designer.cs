namespace TaxCalculator
{
    partial class TaxCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.btnCreateContractor = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnCalculateEmployeeTax = new System.Windows.Forms.Button();
            this.btnCalculateContractorTax = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.ComboBox();
            this.btnGeneratePDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(26, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tax Calculator";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(29, 162);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(91, 17);
            this.lblEmployeeID.TabIndex = 1;
            this.lblEmployeeID.Text = "Employee ID:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(29, 194);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(86, 17);
            this.lblDepartment.TabIndex = 2;
            this.lblDepartment.Text = "Department:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(29, 229);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Enabled = false;
            this.lblHoursWorked.Location = new System.Drawing.Point(29, 294);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(103, 17);
            this.lblHoursWorked.TabIndex = 4;
            this.lblHoursWorked.Text = "Hours Worked:";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(153, 162);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(121, 22);
            this.txtEmployeeID.TabIndex = 3;
            this.txtEmployeeID.Leave += new System.EventHandler(this.txtEmployeeID_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(153, 229);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Enabled = false;
            this.txtHoursWorked.Location = new System.Drawing.Point(153, 294);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(121, 22);
            this.txtHoursWorked.TabIndex = 7;
            // 
            // btnCreateEmployee
            // 
            this.btnCreateEmployee.Enabled = false;
            this.btnCreateEmployee.Location = new System.Drawing.Point(32, 335);
            this.btnCreateEmployee.Name = "btnCreateEmployee";
            this.btnCreateEmployee.Size = new System.Drawing.Size(128, 28);
            this.btnCreateEmployee.TabIndex = 8;
            this.btnCreateEmployee.Text = "Create Employee";
            this.btnCreateEmployee.UseVisualStyleBackColor = true;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click);
            // 
            // btnCreateContractor
            // 
            this.btnCreateContractor.Enabled = false;
            this.btnCreateContractor.Location = new System.Drawing.Point(166, 335);
            this.btnCreateContractor.Name = "btnCreateContractor";
            this.btnCreateContractor.Size = new System.Drawing.Size(138, 28);
            this.btnCreateContractor.TabIndex = 9;
            this.btnCreateContractor.Text = "Create Contractor";
            this.btnCreateContractor.UseVisualStyleBackColor = true;
            this.btnCreateContractor.Click += new System.EventHandler(this.btnCreateContractor_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(32, 422);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(272, 189);
            this.txtOutput.TabIndex = 11;
            // 
            // btnCalculateEmployeeTax
            // 
            this.btnCalculateEmployeeTax.Enabled = false;
            this.btnCalculateEmployeeTax.Location = new System.Drawing.Point(32, 369);
            this.btnCalculateEmployeeTax.Name = "btnCalculateEmployeeTax";
            this.btnCalculateEmployeeTax.Size = new System.Drawing.Size(128, 28);
            this.btnCalculateEmployeeTax.TabIndex = 10;
            this.btnCalculateEmployeeTax.Text = "Employee Tax";
            this.btnCalculateEmployeeTax.UseVisualStyleBackColor = true;
            this.btnCalculateEmployeeTax.Click += new System.EventHandler(this.btnCalculateEmployeeTax_Click);
            // 
            // btnCalculateContractorTax
            // 
            this.btnCalculateContractorTax.Enabled = false;
            this.btnCalculateContractorTax.Location = new System.Drawing.Point(166, 369);
            this.btnCalculateContractorTax.Name = "btnCalculateContractorTax";
            this.btnCalculateContractorTax.Size = new System.Drawing.Size(138, 28);
            this.btnCalculateContractorTax.TabIndex = 11;
            this.btnCalculateContractorTax.Text = "Contractor Tax";
            this.btnCalculateContractorTax.UseVisualStyleBackColor = true;
            this.btnCalculateContractorTax.Click += new System.EventHandler(this.btnCalculateContractorTax_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(29, 131);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 17);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Gender:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(29, 101);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(69, 17);
            this.lblSurname.TabIndex = 15;
            this.lblSurname.Text = "Surname:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(29, 71);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 17);
            this.lblFirstName.TabIndex = 16;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(153, 131);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(121, 22);
            this.txtGender.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(153, 101);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(121, 22);
            this.txtSurname.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(153, 71);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(121, 22);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(153, 261);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(121, 22);
            this.txtHourlyRate.TabIndex = 6;
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Location = new System.Drawing.Point(29, 261);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(87, 17);
            this.lblHourlyRate.TabIndex = 20;
            this.lblHourlyRate.Text = "Hourly Rate:";
            // 
            // txtDepartment
            // 
            this.txtDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDepartment.FormattingEnabled = true;
            this.txtDepartment.Items.AddRange(new object[] {
            "Accounts",
            "Customer Service",
            "IT",
            "Administration"});
            this.txtDepartment.Location = new System.Drawing.Point(153, 194);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(121, 24);
            this.txtDepartment.TabIndex = 4;
            // 
            // btnGeneratePDF
            // 
            this.btnGeneratePDF.Enabled = false;
            this.btnGeneratePDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnGeneratePDF.Location = new System.Drawing.Point(57, 626);
            this.btnGeneratePDF.Name = "btnGeneratePDF";
            this.btnGeneratePDF.Size = new System.Drawing.Size(217, 36);
            this.btnGeneratePDF.TabIndex = 21;
            this.btnGeneratePDF.Text = "Export to PDF";
            this.btnGeneratePDF.UseVisualStyleBackColor = true;
            this.btnGeneratePDF.Click += new System.EventHandler(this.btnGeneratePDF_Click);
            // 
            // TaxCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 683);
            this.Controls.Add(this.btnGeneratePDF);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.btnCalculateContractorTax);
            this.Controls.Add(this.btnCalculateEmployeeTax);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnCreateContractor);
            this.Controls.Add(this.btnCreateEmployee);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.lblTitle);
            this.Name = "TaxCalculator";
            this.Text = "Tax Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.Button btnCreateEmployee;
        private System.Windows.Forms.Button btnCreateContractor;
        private System.Windows.Forms.Button btnCalculateEmployeeTax;
        private System.Windows.Forms.Button btnCalculateContractorTax;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.ComboBox txtDepartment;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnGeneratePDF;
    }
}

