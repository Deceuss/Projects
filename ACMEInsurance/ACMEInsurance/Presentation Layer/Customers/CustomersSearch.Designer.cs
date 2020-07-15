namespace Module9Assessment1.Presentation_Layer
{
    partial class frmCustomersSearch
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
            this.rbLastName = new System.Windows.Forms.RadioButton();
            this.rbCategory = new System.Windows.Forms.RadioButton();
            this.rbPostcode = new System.Windows.Forms.RadioButton();
            this.rbListAll = new System.Windows.Forms.RadioButton();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbCategoryID = new System.Windows.Forms.ListBox();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbLastName
            // 
            this.rbLastName.AutoSize = true;
            this.rbLastName.Location = new System.Drawing.Point(6, 21);
            this.rbLastName.Name = "rbLastName";
            this.rbLastName.Size = new System.Drawing.Size(165, 21);
            this.rbLastName.TabIndex = 1;
            this.rbLastName.TabStop = true;
            this.rbLastName.Text = "Search by Last Name";
            this.rbLastName.UseVisualStyleBackColor = true;
            this.rbLastName.Click += new System.EventHandler(this.rbLastName_Click);
            // 
            // rbCategory
            // 
            this.rbCategory.AutoSize = true;
            this.rbCategory.Location = new System.Drawing.Point(6, 62);
            this.rbCategory.Name = "rbCategory";
            this.rbCategory.Size = new System.Drawing.Size(154, 21);
            this.rbCategory.TabIndex = 3;
            this.rbCategory.TabStop = true;
            this.rbCategory.Text = "Search by Category";
            this.rbCategory.UseVisualStyleBackColor = true;
            this.rbCategory.Click += new System.EventHandler(this.rbCategory_Click);
            // 
            // rbPostcode
            // 
            this.rbPostcode.AutoSize = true;
            this.rbPostcode.Location = new System.Drawing.Point(6, 103);
            this.rbPostcode.Name = "rbPostcode";
            this.rbPostcode.Size = new System.Drawing.Size(156, 21);
            this.rbPostcode.TabIndex = 5;
            this.rbPostcode.TabStop = true;
            this.rbPostcode.Text = "Search by Postcode";
            this.rbPostcode.UseVisualStyleBackColor = true;
            this.rbPostcode.Click += new System.EventHandler(this.rbPostcode_Click);
            // 
            // rbListAll
            // 
            this.rbListAll.AutoSize = true;
            this.rbListAll.Location = new System.Drawing.Point(6, 144);
            this.rbListAll.Name = "rbListAll";
            this.rbListAll.Size = new System.Drawing.Size(69, 21);
            this.rbListAll.TabIndex = 7;
            this.rbListAll.TabStop = true;
            this.rbListAll.Text = "List all";
            this.rbListAll.UseVisualStyleBackColor = true;
            this.rbListAll.Click += new System.EventHandler(this.rbListAll_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(187, 20);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(172, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(187, 61);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(172, 24);
            this.cbCategory.TabIndex = 4;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(187, 102);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(172, 22);
            this.txtPostcode.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(203, 161);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 27);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 161);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbCategoryID
            // 
            this.lbCategoryID.FormattingEnabled = true;
            this.lbCategoryID.ItemHeight = 16;
            this.lbCategoryID.Location = new System.Drawing.Point(366, 61);
            this.lbCategoryID.Name = "lbCategoryID";
            this.lbCategoryID.Size = new System.Drawing.Size(11, 20);
            this.lbCategoryID.TabIndex = 9;
            this.lbCategoryID.Visible = false;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnCancel);
            this.gbSearch.Controls.Add(this.lbCategoryID);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.rbLastName);
            this.gbSearch.Controls.Add(this.txtPostcode);
            this.gbSearch.Controls.Add(this.rbCategory);
            this.gbSearch.Controls.Add(this.cbCategory);
            this.gbSearch.Controls.Add(this.rbPostcode);
            this.gbSearch.Controls.Add(this.txtLastName);
            this.gbSearch.Controls.Add(this.rbListAll);
            this.gbSearch.Location = new System.Drawing.Point(12, 12);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(378, 194);
            this.gbSearch.TabIndex = 10;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search Options";
            // 
            // frmCustomersSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 218);
            this.Controls.Add(this.gbSearch);
            this.Name = "frmCustomersSearch";
            this.Text = "Customers Search";
            this.Load += new System.EventHandler(this.frmCustomersSearch_Load);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbLastName;
        private System.Windows.Forms.RadioButton rbCategory;
        private System.Windows.Forms.RadioButton rbPostcode;
        private System.Windows.Forms.RadioButton rbListAll;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lbCategoryID;
        private System.Windows.Forms.GroupBox gbSearch;
    }
}