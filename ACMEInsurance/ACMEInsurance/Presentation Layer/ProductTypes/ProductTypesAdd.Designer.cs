namespace Module9Assessment1.Presentation_Layer.ProductTypes
{
    partial class frmProductTypesAdd
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtProuctTypeToAdd = new System.Windows.Forms.TextBox();
            this.lblProductTypeToAdd = new System.Windows.Forms.Label();
            this.lblProductTypeID = new System.Windows.Forms.Label();
            this.txtProductTypeID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(236, 76);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Canc&el";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(155, 76);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 28);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtProuctTypeToAdd
            // 
            this.txtProuctTypeToAdd.Location = new System.Drawing.Point(160, 37);
            this.txtProuctTypeToAdd.Name = "txtProuctTypeToAdd";
            this.txtProuctTypeToAdd.Size = new System.Drawing.Size(151, 22);
            this.txtProuctTypeToAdd.TabIndex = 2;
            // 
            // lblProductTypeToAdd
            // 
            this.lblProductTypeToAdd.AutoSize = true;
            this.lblProductTypeToAdd.Location = new System.Drawing.Point(12, 40);
            this.lblProductTypeToAdd.Name = "lblProductTypeToAdd";
            this.lblProductTypeToAdd.Size = new System.Drawing.Size(142, 17);
            this.lblProductTypeToAdd.TabIndex = 5;
            this.lblProductTypeToAdd.Text = "Product Type to Add:";
            // 
            // lblProductTypeID
            // 
            this.lblProductTypeID.AutoSize = true;
            this.lblProductTypeID.Location = new System.Drawing.Point(13, 13);
            this.lblProductTypeID.Name = "lblProductTypeID";
            this.lblProductTypeID.Size = new System.Drawing.Size(114, 17);
            this.lblProductTypeID.TabIndex = 10;
            this.lblProductTypeID.Text = "Product Type ID:";
            // 
            // txtProductTypeID
            // 
            this.txtProductTypeID.Location = new System.Drawing.Point(160, 10);
            this.txtProductTypeID.Name = "txtProductTypeID";
            this.txtProductTypeID.ReadOnly = true;
            this.txtProductTypeID.Size = new System.Drawing.Size(152, 22);
            this.txtProductTypeID.TabIndex = 1;
            // 
            // frmProductTypesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 114);
            this.Controls.Add(this.txtProductTypeID);
            this.Controls.Add(this.lblProductTypeID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtProuctTypeToAdd);
            this.Controls.Add(this.lblProductTypeToAdd);
            this.Name = "frmProductTypesAdd";
            this.Text = "Add Product Types";
            this.Load += new System.EventHandler(this.frmProductTypesAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtProuctTypeToAdd;
        private System.Windows.Forms.Label lblProductTypeToAdd;
        private System.Windows.Forms.Label lblProductTypeID;
        private System.Windows.Forms.TextBox txtProductTypeID;
    }
}