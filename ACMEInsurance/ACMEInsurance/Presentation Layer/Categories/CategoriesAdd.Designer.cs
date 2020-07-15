namespace Module9Assessment1.Presentation_Layer.Categories
{
    partial class frmCategoriesAdd
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
            this.lblCategoryToAdd = new System.Windows.Forms.Label();
            this.txtCategoryToAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCategoryToAdd
            // 
            this.lblCategoryToAdd.AutoSize = true;
            this.lblCategoryToAdd.Location = new System.Drawing.Point(12, 37);
            this.lblCategoryToAdd.Name = "lblCategoryToAdd";
            this.lblCategoryToAdd.Size = new System.Drawing.Size(114, 17);
            this.lblCategoryToAdd.TabIndex = 0;
            this.lblCategoryToAdd.Text = "Category to Add:";
            // 
            // txtCategoryToAdd
            // 
            this.txtCategoryToAdd.Location = new System.Drawing.Point(132, 34);
            this.txtCategoryToAdd.Name = "txtCategoryToAdd";
            this.txtCategoryToAdd.Size = new System.Drawing.Size(151, 22);
            this.txtCategoryToAdd.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(35, 75);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 28);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(121, 75);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 28);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(207, 75);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Canc&el";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(132, 6);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.ReadOnly = true;
            this.txtCategoryID.Size = new System.Drawing.Size(151, 22);
            this.txtCategoryID.TabIndex = 1;
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Location = new System.Drawing.Point(12, 9);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(86, 17);
            this.lblCategoryID.TabIndex = 6;
            this.lblCategoryID.Text = "Category ID:";
            // 
            // frmCategoriesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 110);
            this.Controls.Add(this.lblCategoryID);
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCategoryToAdd);
            this.Controls.Add(this.lblCategoryToAdd);
            this.Name = "frmCategoriesAdd";
            this.Text = "Add Category";
            this.Load += new System.EventHandler(this.frmCategoriesAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryToAdd;
        private System.Windows.Forms.TextBox txtCategoryToAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label lblCategoryID;
    }
}