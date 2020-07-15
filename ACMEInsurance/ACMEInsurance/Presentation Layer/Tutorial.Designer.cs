namespace Module9Assessment1.Presentation_Layer
{
    partial class frmTutorial
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblChoose = new System.Windows.Forms.Label();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnProductTypes = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(160, 376);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 27);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Location = new System.Drawing.Point(13, 13);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(222, 17);
            this.lblChoose.TabIndex = 1;
            this.lblChoose.Text = "Choose one of the below tutorials:";
            // 
            // btnCategories
            // 
            this.btnCategories.Location = new System.Drawing.Point(48, 47);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(151, 31);
            this.btnCategories.TabIndex = 1;
            this.btnCategories.Text = "&Categories";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(48, 112);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(151, 31);
            this.btnCustomers.TabIndex = 2;
            this.btnCustomers.Text = "C&ustomers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(48, 177);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(151, 31);
            this.btnProducts.TabIndex = 3;
            this.btnProducts.Text = "&Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnProductTypes
            // 
            this.btnProductTypes.Location = new System.Drawing.Point(48, 242);
            this.btnProductTypes.Name = "btnProductTypes";
            this.btnProductTypes.Size = new System.Drawing.Size(151, 31);
            this.btnProductTypes.TabIndex = 4;
            this.btnProductTypes.Text = "Product &Types";
            this.btnProductTypes.UseVisualStyleBackColor = true;
            this.btnProductTypes.Click += new System.EventHandler(this.btnProductTypes_Click);
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(48, 307);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(151, 31);
            this.btnSales.TabIndex = 5;
            this.btnSales.Text = "&Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // frmTutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 410);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnProductTypes);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnCategories);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.btnBack);
            this.Name = "frmTutorial";
            this.Text = "Tutorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnProductTypes;
        private System.Windows.Forms.Button btnSales;
    }
}