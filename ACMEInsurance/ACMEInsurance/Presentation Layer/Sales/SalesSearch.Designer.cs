namespace Module9Assessment1.Presentation_Layer
{
    partial class frmSalesSearch
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
            this.gbSearchCriteria = new System.Windows.Forms.GroupBox();
            this.rbListAll = new System.Windows.Forms.RadioButton();
            this.dtpSaleStartDate = new System.Windows.Forms.DateTimePicker();
            this.lbProductID = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbProductName = new System.Windows.Forms.ComboBox();
            this.rbSaleStartDate = new System.Windows.Forms.RadioButton();
            this.rbProductName = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbSearchCriteria.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearchCriteria
            // 
            this.gbSearchCriteria.Controls.Add(this.rbListAll);
            this.gbSearchCriteria.Controls.Add(this.dtpSaleStartDate);
            this.gbSearchCriteria.Controls.Add(this.lbProductID);
            this.gbSearchCriteria.Controls.Add(this.btnCancel);
            this.gbSearchCriteria.Controls.Add(this.cbProductName);
            this.gbSearchCriteria.Controls.Add(this.rbSaleStartDate);
            this.gbSearchCriteria.Controls.Add(this.rbProductName);
            this.gbSearchCriteria.Controls.Add(this.btnSearch);
            this.gbSearchCriteria.Location = new System.Drawing.Point(12, 12);
            this.gbSearchCriteria.Name = "gbSearchCriteria";
            this.gbSearchCriteria.Size = new System.Drawing.Size(356, 165);
            this.gbSearchCriteria.TabIndex = 0;
            this.gbSearchCriteria.TabStop = false;
            this.gbSearchCriteria.Text = "Search Options";
            // 
            // rbListAll
            // 
            this.rbListAll.AutoSize = true;
            this.rbListAll.Location = new System.Drawing.Point(7, 98);
            this.rbListAll.Name = "rbListAll";
            this.rbListAll.Size = new System.Drawing.Size(70, 21);
            this.rbListAll.TabIndex = 5;
            this.rbListAll.TabStop = true;
            this.rbListAll.Text = "List All";
            this.rbListAll.UseVisualStyleBackColor = true;
            this.rbListAll.Click += new System.EventHandler(this.rbListAll_Click);
            // 
            // dtpSaleStartDate
            // 
            this.dtpSaleStartDate.Location = new System.Drawing.Point(146, 58);
            this.dtpSaleStartDate.Name = "dtpSaleStartDate";
            this.dtpSaleStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpSaleStartDate.TabIndex = 4;
            // 
            // lbProductID
            // 
            this.lbProductID.FormattingEnabled = true;
            this.lbProductID.ItemHeight = 16;
            this.lbProductID.Location = new System.Drawing.Point(352, 18);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(10, 20);
            this.lbProductID.TabIndex = 1;
            this.lbProductID.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(248, 123);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 32);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Canc&el";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbProductName
            // 
            this.cbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductName.FormattingEnabled = true;
            this.cbProductName.Location = new System.Drawing.Point(146, 18);
            this.cbProductName.Name = "cbProductName";
            this.cbProductName.Size = new System.Drawing.Size(200, 24);
            this.cbProductName.TabIndex = 2;
            // 
            // rbSaleStartDate
            // 
            this.rbSaleStartDate.AutoSize = true;
            this.rbSaleStartDate.Location = new System.Drawing.Point(7, 58);
            this.rbSaleStartDate.Name = "rbSaleStartDate";
            this.rbSaleStartDate.Size = new System.Drawing.Size(125, 21);
            this.rbSaleStartDate.TabIndex = 3;
            this.rbSaleStartDate.TabStop = true;
            this.rbSaleStartDate.Text = "Sale Start Date";
            this.rbSaleStartDate.UseVisualStyleBackColor = true;
            this.rbSaleStartDate.Click += new System.EventHandler(this.rbSaleStartDate_Click);
            // 
            // rbProductName
            // 
            this.rbProductName.AutoSize = true;
            this.rbProductName.Location = new System.Drawing.Point(7, 19);
            this.rbProductName.Name = "rbProductName";
            this.rbProductName.Size = new System.Drawing.Size(119, 21);
            this.rbProductName.TabIndex = 1;
            this.rbProductName.TabStop = true;
            this.rbProductName.Text = "Product Name";
            this.rbProductName.UseVisualStyleBackColor = true;
            this.rbProductName.Click += new System.EventHandler(this.rbProductName_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(127, 123);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 32);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmSalesSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 185);
            this.Controls.Add(this.gbSearchCriteria);
            this.Name = "frmSalesSearch";
            this.Text = "Search for Sale";
            this.Load += new System.EventHandler(this.frmSalesSearch_Load);
            this.gbSearchCriteria.ResumeLayout(false);
            this.gbSearchCriteria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchCriteria;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rbSaleStartDate;
        private System.Windows.Forms.RadioButton rbProductName;
        private System.Windows.Forms.DateTimePicker dtpSaleStartDate;
        private System.Windows.Forms.ComboBox cbProductName;
        private System.Windows.Forms.ListBox lbProductID;
        private System.Windows.Forms.RadioButton rbListAll;
    }
}