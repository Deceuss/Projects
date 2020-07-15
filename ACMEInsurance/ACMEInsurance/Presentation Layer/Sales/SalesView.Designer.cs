namespace Module9Assessment1.Presentation_Layer
{
    partial class frmSalesView
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
            this.lvSales = new System.Windows.Forms.ListView();
            this.SaleID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Payable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.PremiumPayable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvSales
            // 
            this.lvSales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SaleID,
            this.CustomerID,
            this.ProductID,
            this.Payable,
            this.PremiumPayable,
            this.StartDate});
            this.lvSales.HideSelection = false;
            this.lvSales.Location = new System.Drawing.Point(17, 25);
            this.lvSales.Margin = new System.Windows.Forms.Padding(4);
            this.lvSales.Name = "lvSales";
            this.lvSales.Size = new System.Drawing.Size(817, 457);
            this.lvSales.TabIndex = 5;
            this.lvSales.UseCompatibleStateImageBehavior = false;
            this.lvSales.View = System.Windows.Forms.View.Details;
            // 
            // SaleID
            // 
            this.SaleID.Text = "Sale ID";
            this.SaleID.Width = 80;
            // 
            // CustomerID
            // 
            this.CustomerID.Text = "Customer ID";
            this.CustomerID.Width = 100;
            // 
            // ProductID
            // 
            this.ProductID.Text = "Product ID";
            this.ProductID.Width = 80;
            // 
            // Payable
            // 
            this.Payable.Text = "Payable";
            this.Payable.Width = 80;
            // 
            // StartDate
            // 
            this.StartDate.Text = "Start Date";
            this.StartDate.Width = 80;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(616, 490);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(256, 490);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&New Sale";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(376, 490);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 28);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(736, 490);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(496, 490);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // PremiumPayable
            // 
            this.PremiumPayable.Text = "Premium Payable";
            this.PremiumPayable.Width = 80;
            // 
            // frmSalesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 530);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lvSales);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSalesView";
            this.Text = "Sales List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSalesView_FormClosing);
            this.Load += new System.EventHandler(this.frmSalesView_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvSales;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ColumnHeader SaleID;
        private System.Windows.Forms.ColumnHeader CustomerID;
        private System.Windows.Forms.ColumnHeader ProductID;
        private System.Windows.Forms.ColumnHeader Payable;
        private System.Windows.Forms.ColumnHeader StartDate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ColumnHeader PremiumPayable;
    }
}