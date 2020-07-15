namespace Module9Assessment1
{
    partial class frmCustomerAdd
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbCustomerDetails = new System.Windows.Forms.GroupBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lbCategoryID = new System.Windows.Forms.ListBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.gbCustomerAddress = new System.Windows.Forms.GroupBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.gbCustomerDetails.SuspendLayout();
            this.gbCustomerAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(295, 255);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(409, 255);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(523, 255);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Canc&el";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbCustomerDetails
            // 
            this.gbCustomerDetails.Controls.Add(this.dtpBirthDate);
            this.gbCustomerDetails.Controls.Add(this.txtCustomerID);
            this.gbCustomerDetails.Controls.Add(this.lbCategoryID);
            this.gbCustomerDetails.Controls.Add(this.lblCustomerID);
            this.gbCustomerDetails.Controls.Add(this.lblLastName);
            this.gbCustomerDetails.Controls.Add(this.txtLastName);
            this.gbCustomerDetails.Controls.Add(this.lblGender);
            this.gbCustomerDetails.Controls.Add(this.rbMale);
            this.gbCustomerDetails.Controls.Add(this.lblCategory);
            this.gbCustomerDetails.Controls.Add(this.txtFirstName);
            this.gbCustomerDetails.Controls.Add(this.rbFemale);
            this.gbCustomerDetails.Controls.Add(this.lblBirthDate);
            this.gbCustomerDetails.Controls.Add(this.cbCategory);
            this.gbCustomerDetails.Controls.Add(this.lblFirstName);
            this.gbCustomerDetails.Location = new System.Drawing.Point(9, 13);
            this.gbCustomerDetails.Margin = new System.Windows.Forms.Padding(4);
            this.gbCustomerDetails.Name = "gbCustomerDetails";
            this.gbCustomerDetails.Padding = new System.Windows.Forms.Padding(4);
            this.gbCustomerDetails.Size = new System.Drawing.Size(307, 234);
            this.gbCustomerDetails.TabIndex = 48;
            this.gbCustomerDetails.TabStop = false;
            this.gbCustomerDetails.Text = "Customer Details";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(115, 32);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(160, 22);
            this.txtCustomerID.TabIndex = 1;
            // 
            // lbCategoryID
            // 
            this.lbCategoryID.FormattingEnabled = true;
            this.lbCategoryID.ItemHeight = 16;
            this.lbCategoryID.Location = new System.Drawing.Point(282, 180);
            this.lbCategoryID.Name = "lbCategoryID";
            this.lbCategoryID.Size = new System.Drawing.Size(10, 20);
            this.lbCategoryID.TabIndex = 45;
            this.lbCategoryID.Visible = false;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(8, 35);
            this.lblCustomerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(89, 17);
            this.lblCustomerID.TabIndex = 50;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(10, 93);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 17);
            this.lblLastName.TabIndex = 27;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(115, 90);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(160, 22);
            this.txtLastName.TabIndex = 3;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(10, 122);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 17);
            this.lblGender.TabIndex = 32;
            this.lblGender.Text = "Gender:";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(115, 120);
            this.rbMale.Margin = new System.Windows.Forms.Padding(4);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(59, 21);
            this.rbMale.TabIndex = 4;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(10, 180);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 17);
            this.lblCategory.TabIndex = 34;
            this.lblCategory.Text = "Category";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(115, 61);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(160, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(187, 120);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(75, 21);
            this.rbFemale.TabIndex = 5;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(10, 151);
            this.lblBirthDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(75, 17);
            this.lblBirthDate.TabIndex = 33;
            this.lblBirthDate.Text = "Birth Date:";
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(115, 177);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(160, 24);
            this.cbCategory.TabIndex = 7;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(10, 64);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 17);
            this.lblFirstName.TabIndex = 26;
            this.lblFirstName.Text = "First Name:";
            // 
            // gbCustomerAddress
            // 
            this.gbCustomerAddress.Controls.Add(this.lblAddress);
            this.gbCustomerAddress.Controls.Add(this.lblSuburb);
            this.gbCustomerAddress.Controls.Add(this.lblState);
            this.gbCustomerAddress.Controls.Add(this.lblPostcode);
            this.gbCustomerAddress.Controls.Add(this.txtAddress);
            this.gbCustomerAddress.Controls.Add(this.txtPostcode);
            this.gbCustomerAddress.Controls.Add(this.cbState);
            this.gbCustomerAddress.Controls.Add(this.txtSuburb);
            this.gbCustomerAddress.Location = new System.Drawing.Point(324, 24);
            this.gbCustomerAddress.Margin = new System.Windows.Forms.Padding(4);
            this.gbCustomerAddress.Name = "gbCustomerAddress";
            this.gbCustomerAddress.Padding = new System.Windows.Forms.Padding(4);
            this.gbCustomerAddress.Size = new System.Drawing.Size(299, 157);
            this.gbCustomerAddress.TabIndex = 49;
            this.gbCustomerAddress.TabStop = false;
            this.gbCustomerAddress.Text = "Customer Address";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(13, 31);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 17);
            this.lblAddress.TabIndex = 28;
            this.lblAddress.Text = "Address:";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(13, 61);
            this.lblSuburb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(58, 17);
            this.lblSuburb.TabIndex = 29;
            this.lblSuburb.Text = "Suburb:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(13, 91);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(45, 17);
            this.lblState.TabIndex = 30;
            this.lblState.Text = "State:";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(13, 121);
            this.lblPostcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(71, 17);
            this.lblPostcode.TabIndex = 31;
            this.lblPostcode.Text = "Postcode:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(117, 28);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(160, 22);
            this.txtAddress.TabIndex = 8;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(117, 118);
            this.txtPostcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(160, 22);
            this.txtPostcode.TabIndex = 11;
            // 
            // cbState
            // 
            this.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbState.FormattingEnabled = true;
            this.cbState.Items.AddRange(new object[] {
            "NSW",
            "QLD",
            "VIC",
            "ACT",
            "SA",
            "NT",
            "WA"});
            this.cbState.Location = new System.Drawing.Point(117, 88);
            this.cbState.Margin = new System.Windows.Forms.Padding(4);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(160, 24);
            this.cbState.TabIndex = 10;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(117, 58);
            this.txtSuburb.Margin = new System.Windows.Forms.Padding(4);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(160, 22);
            this.txtSuburb.TabIndex = 9;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(115, 148);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(160, 22);
            this.dtpBirthDate.TabIndex = 6;
            // 
            // frmCustomerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 306);
            this.Controls.Add(this.gbCustomerAddress);
            this.Controls.Add(this.gbCustomerDetails);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCustomerAdd";
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.frmCustomerAdd_Load);
            this.gbCustomerDetails.ResumeLayout(false);
            this.gbCustomerDetails.PerformLayout();
            this.gbCustomerAddress.ResumeLayout(false);
            this.gbCustomerAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbCustomerDetails;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox gbCustomerAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.ListBox lbCategoryID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
    }
}