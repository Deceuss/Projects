namespace Module9Assessment1.Presentation_Layer
{
    partial class frmProductsAdd
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
            this.lblProductType = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblYearlyPremium = new System.Windows.Forms.Label();
            this.cbProductType = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bgProductDetails = new System.Windows.Forms.GroupBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lbProductTypeID = new System.Windows.Forms.ListBox();
            this.txtYearlyPremium = new System.Windows.Forms.TextBox();
            this.bgProductDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Location = new System.Drawing.Point(21, 70);
            this.lblProductType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(97, 17);
            this.lblProductType.TabIndex = 1;
            this.lblProductType.Text = "Product Type:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(21, 108);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(102, 17);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Product Name:";
            // 
            // lblYearlyPremium
            // 
            this.lblYearlyPremium.AutoSize = true;
            this.lblYearlyPremium.Location = new System.Drawing.Point(21, 146);
            this.lblYearlyPremium.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYearlyPremium.Name = "lblYearlyPremium";
            this.lblYearlyPremium.Size = new System.Drawing.Size(111, 17);
            this.lblYearlyPremium.TabIndex = 3;
            this.lblYearlyPremium.Text = "Yearly Premium:";
            // 
            // cbProductType
            // 
            this.cbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductType.FormattingEnabled = true;
            this.cbProductType.Location = new System.Drawing.Point(173, 67);
            this.cbProductType.Margin = new System.Windows.Forms.Padding(4);
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.Size = new System.Drawing.Size(160, 24);
            this.cbProductType.TabIndex = 2;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(173, 105);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(160, 22);
            this.txtProductName.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 201);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(136, 201);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(262, 201);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Canc&el";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bgProductDetails
            // 
            this.bgProductDetails.Controls.Add(this.txtProductID);
            this.bgProductDetails.Controls.Add(this.lblProductID);
            this.bgProductDetails.Controls.Add(this.lbProductTypeID);
            this.bgProductDetails.Controls.Add(this.txtYearlyPremium);
            this.bgProductDetails.Controls.Add(this.lblProductName);
            this.bgProductDetails.Controls.Add(this.txtProductName);
            this.bgProductDetails.Controls.Add(this.lblProductType);
            this.bgProductDetails.Controls.Add(this.cbProductType);
            this.bgProductDetails.Controls.Add(this.lblYearlyPremium);
            this.bgProductDetails.Location = new System.Drawing.Point(7, 8);
            this.bgProductDetails.Margin = new System.Windows.Forms.Padding(4);
            this.bgProductDetails.Name = "bgProductDetails";
            this.bgProductDetails.Padding = new System.Windows.Forms.Padding(4);
            this.bgProductDetails.Size = new System.Drawing.Size(355, 185);
            this.bgProductDetails.TabIndex = 10;
            this.bgProductDetails.TabStop = false;
            this.bgProductDetails.Text = "Product Details";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(173, 29);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(160, 22);
            this.txtProductID.TabIndex = 1;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(21, 32);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(74, 17);
            this.lblProductID.TabIndex = 6;
            this.lblProductID.Text = "Product ID";
            // 
            // lbProductTypeID
            // 
            this.lbProductTypeID.FormattingEnabled = true;
            this.lbProductTypeID.ItemHeight = 16;
            this.lbProductTypeID.Location = new System.Drawing.Point(340, 67);
            this.lbProductTypeID.Name = "lbProductTypeID";
            this.lbProductTypeID.Size = new System.Drawing.Size(10, 20);
            this.lbProductTypeID.TabIndex = 5;
            this.lbProductTypeID.Visible = false;
            // 
            // txtYearlyPremium
            // 
            this.txtYearlyPremium.Location = new System.Drawing.Point(173, 143);
            this.txtYearlyPremium.Name = "txtYearlyPremium";
            this.txtYearlyPremium.Size = new System.Drawing.Size(160, 22);
            this.txtYearlyPremium.TabIndex = 4;
            // 
            // frmProductsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 237);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.bgProductDetails);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProductsAdd";
            this.Text = "Add Products";
            this.Load += new System.EventHandler(this.frmProductsAdd_Load);
            this.bgProductDetails.ResumeLayout(false);
            this.bgProductDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblYearlyPremium;
        private System.Windows.Forms.ComboBox cbProductType;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox bgProductDetails;
        private System.Windows.Forms.TextBox txtYearlyPremium;
        private System.Windows.Forms.ListBox lbProductTypeID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblProductID;
    }
}