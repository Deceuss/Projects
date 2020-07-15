namespace Module9Assessment1.Presentation_Layer.ProductTypes
{
    partial class frmProductTypesSearch
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
            this.cbProductType = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblProductType = new System.Windows.Forms.Label();
            this.gbSearchCriteria.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearchCriteria
            // 
            this.gbSearchCriteria.Controls.Add(this.cbProductType);
            this.gbSearchCriteria.Controls.Add(this.btnCancel);
            this.gbSearchCriteria.Controls.Add(this.btnSearch);
            this.gbSearchCriteria.Controls.Add(this.lblProductType);
            this.gbSearchCriteria.Location = new System.Drawing.Point(12, 12);
            this.gbSearchCriteria.Name = "gbSearchCriteria";
            this.gbSearchCriteria.Size = new System.Drawing.Size(292, 98);
            this.gbSearchCriteria.TabIndex = 9;
            this.gbSearchCriteria.TabStop = false;
            this.gbSearchCriteria.Text = "Search Criteria";
            // 
            // cbProductType
            // 
            this.cbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductType.FormattingEnabled = true;
            this.cbProductType.Location = new System.Drawing.Point(119, 22);
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.Size = new System.Drawing.Size(167, 24);
            this.cbProductType.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(211, 62);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Canc&el";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(119, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Location = new System.Drawing.Point(5, 25);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(97, 17);
            this.lblProductType.TabIndex = 5;
            this.lblProductType.Text = "Product Type:";
            // 
            // frmProductTypesSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 120);
            this.Controls.Add(this.gbSearchCriteria);
            this.Name = "frmProductTypesSearch";
            this.Text = "Search Product Types";
            this.Load += new System.EventHandler(this.frmProductTypesSearch_Load);
            this.gbSearchCriteria.ResumeLayout(false);
            this.gbSearchCriteria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchCriteria;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.ComboBox cbProductType;
    }
}