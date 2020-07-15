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

namespace Module9Assessment1.Presentation_Layer.ProductTypes
{
    public partial class frmProductTypesAdd : Form
    {
        public frmProductTypesAdd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //The code in the add button adds an entry to the Product Types table, but 
        //first makes check to ensure all fields have been filled
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtProuctTypeToAdd.Text))
            {
                MessageBox.Show("Please enter a Product Type to add.");
            }

            Business_Logic_Layer.ProductTypes productType = new Business_Logic_Layer.ProductTypes(GlobalVariables.selectedProductTypeID, txtProuctTypeToAdd.Text);

            string addQuery;
            if (GlobalVariables.selectedProductTypeID == 0)
            {
                addQuery = "sp_ProductTypes_CreateProductType";
            }
            else
            {
                addQuery = "sp_ProductTypes_UpdateProductType";
            }

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(addQuery, conn);



            cmd.CommandType = CommandType.StoredProcedure;
            if (GlobalVariables.selectedProductTypeID != 0)
            {
                cmd.Parameters.AddWithValue("@ProductTypeID", productType.ProductTypeID);
            }
            cmd.Parameters.AddWithValue("@ProductType", productType.ProductType);
            if (GlobalVariables.selectedProductTypeID == 0)
            {
                cmd.Parameters.AddWithValue("@NewProductTypeID", SqlDbType.Int).Direction = ParameterDirection.Output;
            }
            cmd.Transaction = conn.BeginTransaction();
            cmd.ExecuteNonQuery();
            cmd.Transaction.Commit();

            conn.Close();

            this.Close();
        }

        //Loads the form in a specific format depending on if the user 
        //clicked the Add or Update button on the categories view form
        private void frmProductTypesAdd_Load(object sender, EventArgs e)
        {
            if (GlobalVariables.selectedProductTypeID == 0)
                btnAdd.Text = "&Add";
            else
                btnAdd.Text = "U&pdate";

            string selectQuery;

            if (GlobalVariables.selectedProductTypeID > 0)
            {
                selectQuery = "SELECT * FROM ProductTypes WHERE ProductTypeID = " + GlobalVariables.selectedProductTypeID.ToString();

                SqlConnection conn1 = ConnectionManager.DatabaseConnection();
                SqlDataReader rdr1 = null;
                try
                {
                    conn1.Open();
                    SqlCommand cmd1 = new SqlCommand(selectQuery, conn1);
                    rdr1 = cmd1.ExecuteReader();
                    rdr1.Read();
                    txtProductTypeID.Text = rdr1["ProductTypeID"].ToString();
                    txtProuctTypeToAdd.Text = rdr1["ProductType"].ToString();
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
