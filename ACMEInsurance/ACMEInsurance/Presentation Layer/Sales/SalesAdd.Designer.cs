namespace Module9Assessment1.Presentation_Layer
{
    partial class frmSalesAdd
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
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblPayable = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.btnSelectProductID = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbPayable = new System.Windows.Forms.ComboBox();
            this.gbCustomerSelection = new System.Windows.Forms.GroupBox();
            this.btnSelectCustomer = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.gbProductSelection = new System.Windows.Forms.GroupBox();
            this.txtYearlyPremium = new System.Windows.Forms.TextBox();
            this.lblYearlyPremium = new System.Windows.Forms.Label();
            this.txtProductType = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.dtpSaleDate = new System.Windows.Forms.DateTimePicker();
            this.lblPeoductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbCustomerSelection.SuspendLayout();
            this.gbProductSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(8, 81);
            this.lblCustomerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(89, 17);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(8, 81);
            this.lblProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(78, 17);
            this.lblProductID.TabIndex = 1;
            this.lblProductID.Text = "Product ID:";
            // 
            // lblPayable
            // 
            this.lblPayable.AutoSize = true;
            this.lblPayable.Location = new System.Drawing.Point(8, 209);
            this.lblPayable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayable.Name = "lblPayable";
            this.lblPayable.Size = new System.Drawing.Size(63, 17);
            this.lblPayable.TabIndex = 2;
            this.lblPayable.Text = "Payable:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(142, 77);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(133, 22);
            this.txtCustomerID.TabIndex = 2;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(132, 77);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(245, 22);
            this.txtProductID.TabIndex = 6;
            // 
            // btnSelectProductID
            // 
            this.btnSelectProductID.Location = new System.Drawing.Point(11, 32);
            this.btnSelectProductID.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectProductID.Name = "btnSelectProductID";
            this.btnSelectProductID.Size = new System.Drawing.Size(127, 28);
            this.btnSelectProductID.TabIndex = 5;
            this.btnSelectProductID.Text = "Select &Product";
            this.btnSelectProductID.UseVisualStyleBackColor = true;
            this.btnSelectProductID.Click += new System.EventHandler(this.btnSelectProductID_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(579, 301);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 28);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbPayable
            // 
            this.cbPayable.AutoCompleteCustomSource.AddRange(new string[] {
            "Fortnightly",
            "Monthly",
            "Yearly"});
            this.cbPayable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPayable.FormattingEnabled = true;
            this.cbPayable.Items.AddRange(new object[] {
            "Fortnightly",
            "Monthly",
            "Yearly"});
            this.cbPayable.Location = new System.Drawing.Point(132, 206);
            this.cbPayable.Margin = new System.Windows.Forms.Padding(4);
            this.cbPayable.Name = "cbPayable";
            this.cbPayable.Size = new System.Drawing.Size(245, 24);
            this.cbPayable.TabIndex = 10;
            // 
            // gbCustomerSelection
            // 
            this.gbCustomerSelection.Controls.Add(this.btnSelectCustomer);
            this.gbCustomerSelection.Controls.Add(this.lblLastName);
            this.gbCustomerSelection.Controls.Add(this.lblFirstName);
            this.gbCustomerSelection.Controls.Add(this.txtLastName);
            this.gbCustomerSelection.Controls.Add(this.txtFirstName);
            this.gbCustomerSelection.Controls.Add(this.lblCustomerID);
            this.gbCustomerSelection.Controls.Add(this.txtCustomerID);
            this.gbCustomerSelection.Location = new System.Drawing.Point(16, 15);
            this.gbCustomerSelection.Margin = new System.Windows.Forms.Padding(4);
            this.gbCustomerSelection.Name = "gbCustomerSelection";
            this.gbCustomerSelection.Padding = new System.Windows.Forms.Padding(4);
            this.gbCustomerSelection.Size = new System.Drawing.Size(289, 177);
            this.gbCustomerSelection.TabIndex = 11;
            this.gbCustomerSelection.TabStop = false;
            this.gbCustomerSelection.Text = "Customer Selection";
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.Location = new System.Drawing.Point(11, 32);
            this.btnSelectCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectCustomer.Name = "btnSelectCustomer";
            this.btnSelectCustomer.Size = new System.Drawing.Size(127, 28);
            this.btnSelectCustomer.TabIndex = 1;
            this.btnSelectCustomer.Text = "Select &Customer";
            this.btnSelectCustomer.UseVisualStyleBackColor = true;
            this.btnSelectCustomer.Click += new System.EventHandler(this.btnSelectCustomer_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(8, 135);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 17);
            this.lblLastName.TabIndex = 19;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(8, 108);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 17);
            this.lblFirstName.TabIndex = 18;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(142, 132);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(133, 22);
            this.txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(142, 105);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(133, 22);
            this.txtFirstName.TabIndex = 3;
            // 
            // gbProductSelection
            // 
            this.gbProductSelection.Controls.Add(this.txtYearlyPremium);
            this.gbProductSelection.Controls.Add(this.lblYearlyPremium);
            this.gbProductSelection.Controls.Add(this.txtProductType);
            this.gbProductSelection.Controls.Add(this.lblDate);
            this.gbProductSelection.Controls.Add(this.lblProductType);
            this.gbProductSelection.Controls.Add(this.dtpSaleDate);
            this.gbProductSelection.Controls.Add(this.lblPeoductName);
            this.gbProductSelection.Controls.Add(this.txtProductName);
            this.gbProductSelection.Controls.Add(this.cbPayable);
            this.gbProductSelection.Controls.Add(this.btnSelectProductID);
            this.gbProductSelection.Controls.Add(this.lblPayable);
            this.gbProductSelection.Controls.Add(this.txtProductID);
            this.gbProductSelection.Controls.Add(this.lblProductID);
            this.gbProductSelection.Location = new System.Drawing.Point(319, 15);
            this.gbProductSelection.Margin = new System.Windows.Forms.Padding(4);
            this.gbProductSelection.Name = "gbProductSelection";
            this.gbProductSelection.Padding = new System.Windows.Forms.Padding(4);
            this.gbProductSelection.Size = new System.Drawing.Size(395, 278);
            this.gbProductSelection.TabIndex = 12;
            this.gbProductSelection.TabStop = false;
            this.gbProductSelection.Text = "Product Details";
            // 
            // txtYearlyPremium
            // 
            this.txtYearlyPremium.Location = new System.Drawing.Point(132, 174);
            this.txtYearlyPremium.Name = "txtYearlyPremium";
            this.txtYearlyPremium.ReadOnly = true;
            this.txtYearlyPremium.Size = new System.Drawing.Size(245, 22);
            this.txtYearlyPremium.TabIndex = 9;
            // 
            // lblYearlyPremium
            // 
            this.lblYearlyPremium.AutoSize = true;
            this.lblYearlyPremium.Location = new System.Drawing.Point(8, 177);
            this.lblYearlyPremium.Name = "lblYearlyPremium";
            this.lblYearlyPremium.Size = new System.Drawing.Size(111, 17);
            this.lblYearlyPremium.TabIndex = 23;
            this.lblYearlyPremium.Text = "Yearly Premium:";
            // 
            // txtProductType
            // 
            this.txtProductType.Location = new System.Drawing.Point(132, 142);
            this.txtProductType.Name = "txtProductType";
            this.txtProductType.ReadOnly = true;
            this.txtProductType.Size = new System.Drawing.Size(245, 22);
            this.txtProductType.TabIndex = 8;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(8, 241);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 21;
            this.lblDate.Text = "Date:";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Location = new System.Drawing.Point(8, 145);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(97, 17);
            this.lblProductType.TabIndex = 20;
            this.lblProductType.Text = "Product Type:";
            // 
            // dtpSaleDate
            // 
            this.dtpSaleDate.Checked = false;
            this.dtpSaleDate.Location = new System.Drawing.Point(132, 239);
            this.dtpSaleDate.Name = "dtpSaleDate";
            this.dtpSaleDate.Size = new System.Drawing.Size(245, 22);
            this.dtpSaleDate.TabIndex = 11;
            // 
            // lblPeoductName
            // 
            this.lblPeoductName.AutoSize = true;
            this.lblPeoductName.Location = new System.Drawing.Point(8, 113);
            this.lblPeoductName.Name = "lblPeoductName";
            this.lblPeoductName.Size = new System.Drawing.Size(102, 17);
            this.lblPeoductName.TabIndex = 17;
            this.lblPeoductName.Text = "Product Name:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(132, 110);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(245, 22);
            this.txtProductName.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(436, 301);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 28);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Cl&ear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(293, 301);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 28);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmSalesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 338);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbCustomerSelection);
            this.Controls.Add(this.gbProductSelection);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSalesAdd";
            this.Text = "New Sale";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSalesAdd_FormClosing);
            this.Load += new System.EventHandler(this.frmSalesAdd_Load);
            this.gbCustomerSelection.ResumeLayout(false);
            this.gbCustomerSelection.PerformLayout();
            this.gbProductSelection.ResumeLayout(false);
            this.gbProductSelection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblPayable;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Button btnSelectProductID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbPayable;
        private System.Windows.Forms.GroupBox gbCustomerSelection;
        private System.Windows.Forms.GroupBox gbProductSelection;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblPeoductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSelectCustomer;
        private System.Windows.Forms.DateTimePicker dtpSaleDate;
        private System.Windows.Forms.TextBox txtProductType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.TextBox txtYearlyPremium;
        private System.Windows.Forms.Label lblYearlyPremium;
    }
}