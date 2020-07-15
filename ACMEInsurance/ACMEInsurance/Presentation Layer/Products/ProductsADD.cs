using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Module9Assessment1.Data_Access_Layer;
using Module9Assessment1.Business_Logic_Layer;

namespace Module9Assessment1.Presentation_Layer
{
    public partial class frmProductsAdd : Form
    {
        public frmProductsAdd()
        {
            InitializeComponent();
        }
        
        //Closes the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //The code in the add button adds an entry to the Products table, but 
        //first makes check to ensure all fields have been filled
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(cbProductType.Text))
            {
                MessageBox.Show("Please select a Product Type.");
                return;
            }

            if(String.IsNullOrEmpty(txtProductName.Text))
            {
                MessageBox.Show("Please enter a Product Name.");
                return;
            }

            int parsedValue;
            if (!int.TryParse(txtYearlyPremium.Text, out parsedValue))
            {
                MessageBox.Show("Yearly Premium must be an number.");
                return;
            }

            Products product = new Products(GlobalVariables.selectedProductID, lbProductTypeID.Items[cbProductType.SelectedIndex].ToString(), 
                                            txtProductName.Text, float.Parse(txtYearlyPremium.Text));

            string addQuery;
            if (GlobalVariables.selectedProductID == 0)
            {
                addQuery = "sp_Products_CreateProduct";
            }
            else
            {
                addQuery = "sp_Products_UpdateProduct";
            }

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(addQuery, conn);

            cmd.CommandType = CommandType.StoredProcedure;
            if (GlobalVariables.selectedProductID != 0)
            {
                cmd.Parameters.AddWithValue("@ProductID", product.ProductID);
            }

            cmd.Parameters.AddWithValue("@ProductTypeID", product.ProductType);
            cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
            cmd.Parameters.AddWithValue("@YearlyPremium", product.YearlyPremium);

            if (GlobalVariables.selectedProductID == 0)
            {
                cmd.Parameters.AddWithValue("@NewProductID", SqlDbType.Int).Direction = ParameterDirection.Output;
            }
            cmd.Transaction = conn.BeginTransaction();
            cmd.ExecuteNonQuery();
            cmd.Transaction.Commit();

            conn.Close();

            this.Close();
        }

        //Loads the form in a specific format depending on if the user 
        //clicked the Add or Update button on the categories view form
        private void frmProductsAdd_Load(object sender, EventArgs e)
        {
            string selectQuery;

            selectQuery = "SELECT * FROM ProductTypes";

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lbProductTypeID.Items.Add(rdr["ProductTypeID"].ToString());
                    cbProductType.Items.Add(rdr["ProductType"].ToString());
                }
                if (rdr != null)
                    rdr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful" + ex);
            }

            if (GlobalVariables.selectedProductID == 0)
                btnAdd.Text = "&Add";
            else
                btnAdd.Text = "U&pdate";

            if (GlobalVariables.selectedProductID > 0)
            {
                selectQuery = "SELECT * FROM Products WHERE ProductID = " + GlobalVariables.selectedProductID.ToString();

                SqlConnection conn1 = ConnectionManager.DatabaseConnection();
                SqlDataReader rdr1 = null;
                try
                {
                    conn1.Open();
                    SqlCommand cmd1 = new SqlCommand(selectQuery, conn1);
                    rdr1 = cmd1.ExecuteReader();
                    rdr1.Read();
                    txtProductID.Text = rdr1["ProductID"].ToString();
                    cbProductType.SelectedIndex = int.Parse(rdr1["ProductTypeID"].ToString()) - 1;
                    txtProductName.Text = rdr1["ProductName"].ToString();
                    txtYearlyPremium.Text = rdr1["YearlyPremium"].ToString();
                    rdr1.Close();
                    conn1.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unsuccessful" + ex);
                }
            }
        }
    }
}
