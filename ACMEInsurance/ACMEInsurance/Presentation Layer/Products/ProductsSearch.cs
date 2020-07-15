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

namespace Module9Assessment1.Presentation_Layer
{
    public partial class frmProductsSearch : Form
    {
        public frmProductsSearch()
        {
            InitializeComponent();
        }

        //The following three methods set certain search options as enabled or disabled
        //Depending on what radio button the user has pressed
        private void rbProductName_Click(object sender, EventArgs e)
        {
            cbProductName.Enabled = true;
            cbProductType.Enabled = false;
        }

        private void rbProductType_Click(object sender, EventArgs e)
        {
            cbProductName.Enabled = false;
            cbProductType.Enabled = true;
        }

        private void rbListAll_Click(object sender, EventArgs e)
        {
            cbProductName.Enabled = false;
            cbProductType.Enabled = false;
        }

        //Closes the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Populates the the product name and product type combo boxes
        private void frmProductsSearch_Load(object sender, EventArgs e)
        {
            cbProductName.Enabled = false;
            cbProductType.Enabled = false;

            PopulateProductName();
            PopulateProductType();
        }

        //Sets the productSearchCriteria string so that the when the view form reloads the
        //list box, it adds the productSearchCriteria string to the end of the search query
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rbListAll.Checked == true)
            {
                GlobalVariables.productSearchCriteria = "";
            }

            if (rbProductName.Checked == true)
            {
                GlobalVariables.productSearchCriteria = "WHERE ProductName = '" + cbProductName.Text + "'";
            }

            if (rbProductType.Checked == true)
            {
                GlobalVariables.productSearchCriteria = "WHERE Products.ProductTypeID = " + lbProductTypeID.Items[cbProductType.SelectedIndex].ToString() + "";
            }
            this.Close();
        }

        public void PopulateProductName()
        {
            string selectQuery = "SELECT * FROM Products";

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lbProductID.Items.Add(rdr["ProductID"].ToString());
                    cbProductName.Items.Add(rdr["ProductName"].ToString());
                }
                if (rdr != null)
                    rdr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful" + ex);
            }
        }

        public void PopulateProductType()
        {
            string selectQuery = "SELECT * FROM ProductTypes";

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
        }
    }
}
