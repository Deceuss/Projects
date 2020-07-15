namespace Module9Assessment1.Presentation_Layer.Categories
{
    partial class frmCategoriesSearch
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbSearchCriteria = new System.Windows.Forms.GroupBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbSearchCriteria.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(13, 22);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(69, 17);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Category:";
            // 
            // gbSearchCriteria
            // 
            this.gbSearchCriteria.Controls.Add(this.cbCategory);
            this.gbSearchCriteria.Controls.Add(this.btnCancel);
            this.gbSearchCriteria.Controls.Add(this.btnSearch);
            this.gbSearchCriteria.Controls.Add(this.lblCategory);
            this.gbSearchCriteria.Location = new System.Drawing.Point(12, 12);
            this.gbSearchCriteria.Name = "gbSearchCriteria";
            this.gbSearchCriteria.Size = new System.Drawing.Size(265, 91);
            this.gbSearchCriteria.TabIndex = 8;
            this.gbSearchCriteria.TabStop = false;
            this.gbSearchCriteria.Text = "Search Criteria";
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(99, 22);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(156, 24);
            this.cbCategory.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(180, 52);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Canc&el";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(99, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmCategoriesSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 116);
            this.Controls.Add(this.gbSearchCriteria);
            this.Name = "frmCategoriesSearch";
            this.Text = "Search Categories";
            this.Load += new System.EventHandler(this.frmCategoriesSearch_Load);
            this.gbSearchCriteria.ResumeLayout(false);
            this.gbSearchCriteria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbSearchCriteria;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbCategory;
    }
}