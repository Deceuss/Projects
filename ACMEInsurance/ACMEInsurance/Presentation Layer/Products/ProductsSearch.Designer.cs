namespace Module9Assessment1.Presentation_Layer
{
    partial class frmProductsSearch
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
            this.cbProductType = new System.Windows.Forms.ComboBox();
            this.gbSearchCriteria = new System.Windows.Forms.GroupBox();
            this.lbProductID = new System.Windows.Forms.ListBox();
            this.cbProductName = new System.Windows.Forms.ComboBox();
            this.lbProductTypeID = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbListAll = new System.Windows.Forms.RadioButton();
            this.rbProductType = new System.Windows.Forms.RadioButton();
            this.rbProductName = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbSearchCriteria.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbProductType
            // 
            this.cbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductType.FormattingEnabled = true;
            this.cbProductType.Location = new System.Drawing.Point(212, 59);
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.Size = new System.Drawing.Size(160, 24);
            this.cbProductType.TabIndex = 4;
            // 
            // gbSearchCriteria
            // 
            this.gbSearchCriteria.Controls.Add(this.lbProductID);
            this.gbSearchCriteria.Controls.Add(this.cbProductName);
            this.gbSearchCriteria.Controls.Add(this.lbProductTypeID);
            this.gbSearchCriteria.Controls.Add(this.btnCancel);
            this.gbSearchCriteria.Controls.Add(this.rbListAll);
            this.gbSearchCriteria.Controls.Add(this.rbProductType);
            this.gbSearchCriteria.Controls.Add(this.rbProductName);
            this.gbSearchCriteria.Controls.Add(this.btnSearch);
            this.gbSearchCriteria.Controls.Add(this.cbProductType);
            this.gbSearchCriteria.Location = new System.Drawing.Point(12, 12);
            this.gbSearchCriteria.Name = "gbSearchCriteria";
            this.gbSearchCriteria.Size = new System.Drawing.Size(387, 169);
            this.gbSearchCriteria.TabIndex = 15;
            this.gbSearchCriteria.TabStop = false;
            this.gbSearchCriteria.Text = "Search Options";
            // 
            // lbProductID
            // 
            this.lbProductID.FormattingEnabled = true;
            this.lbProductID.ItemHeight = 16;
            this.lbProductID.Location = new System.Drawing.Point(371, 21);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(10, 20);
            this.lbProductID.TabIndex = 21;
            this.lbProductID.Visible = false;
            // 
            // cbProductName
            // 
            this.cbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductName.FormattingEnabled = true;
            this.cbProductName.Location = new System.Drawing.Point(212, 21);
            this.cbProductName.Name = "cbProductName";
            this.cbProductName.Size = new System.Drawing.Size(160, 24);
            this.cbProductName.TabIndex = 2;
            // 
            // lbProductTypeID
            // 
            this.lbProductTypeID.FormattingEnabled = true;
            this.lbProductTypeID.ItemHeight = 16;
            this.lbProductTypeID.Location = new System.Drawing.Point(371, 61);
            this.lbProductTypeID.Name = "lbProductTypeID";
            this.lbProductTypeID.Size = new System.Drawing.Size(10, 20);
            this.lbProductTypeID.TabIndex = 16;
            this.lbProductTypeID.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(283, 132);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Canc&el";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rbListAll
            // 
            this.rbListAll.AutoSize = true;
            this.rbListAll.Location = new System.Drawing.Point(19, 96);
            this.rbListAll.Name = "rbListAll";
            this.rbListAll.Size = new System.Drawing.Size(70, 21);
            this.rbListAll.TabIndex = 5;
            this.rbListAll.TabStop = true;
            this.rbListAll.Text = "List All";
            this.rbListAll.UseVisualStyleBackColor = true;
            this.rbListAll.Click += new System.EventHandler(this.rbListAll_Click);
            // 
            // rbProductType
            // 
            this.rbProductType.AutoSize = true;
            this.rbProductType.Location = new System.Drawing.Point(19, 60);
            this.rbProductType.Name = "rbProductType";
            this.rbProductType.Size = new System.Drawing.Size(182, 21);
            this.rbProductType.TabIndex = 3;
            this.rbProductType.TabStop = true;
            this.rbProductType.Text = "Search by Product Type";
            this.rbProductType.UseVisualStyleBackColor = true;
            this.rbProductType.Click += new System.EventHandler(this.rbProductType_Click);
            // 
            // rbProductName
            // 
            this.rbProductName.AutoSize = true;
            this.rbProductName.Location = new System.Drawing.Point(19, 23);
            this.rbProductName.Name = "rbProductName";
            this.rbProductName.Size = new System.Drawing.Size(187, 21);
            this.rbProductName.TabIndex = 1;
            this.rbProductName.TabStop = true;
            this.rbProductName.Text = "Search by Product Name";
            this.rbProductName.UseVisualStyleBackColor = true;
            this.rbProductName.Click += new System.EventHandler(this.rbProductName_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(172, 132);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 28);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmProductsSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 192);
            this.Controls.Add(this.gbSearchCriteria);
            this.Name = "frmProductsSearch";
            this.Text = "Product Search";
            this.Load += new System.EventHandler(this.frmProductsSearch_Load);
            this.gbSearchCriteria.ResumeLayout(false);
            this.gbSearchCriteria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbProductType;
        private System.Windows.Forms.GroupBox gbSearchCriteria;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rbListAll;
        private System.Windows.Forms.RadioButton rbProductType;
        private System.Windows.Forms.RadioButton rbProductName;
        private System.Windows.Forms.ListBox lbProductTypeID;
        private System.Windows.Forms.ListBox lbProductID;
        private System.Windows.Forms.ComboBox cbProductName;
    }
}