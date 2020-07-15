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
    public partial class frmSalesSearch : Form
    {
        public frmSalesSearch()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //The following three methods set certain search options as enabled or disabled
        //Depending on what radio button the user has pressed
        private void rbProductName_Click(object sender, EventArgs e)
        {
            cbProductName.Enabled = true;
            dtpSaleStartDate.Enabled = false;
        }

        private void rbSaleStartDate_Click(object sender, EventArgs e)
        {
            cbProductName.Enabled = false;
            dtpSaleStartDate.Enabled = true;
        }

        private void rbListAll_Click(object sender, EventArgs e)
        {
            cbProductName.Enabled = false;
            dtpSaleStartDate.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Sets the search end of the Sales search query depending on what the user has chosen
            if (rbListAll.Checked == true)
            {
                GlobalVariables.salesSearchCriteria = "";
            }
            if (rbProductName.Checked == true)
            {
                GlobalVariables.salesSearchCriteria = "WHERE ProductID = " + lbProductID.Items[cbProductName.SelectedIndex].ToString() + "";
            }
            if (rbSaleStartDate.Checked == true)
            {
                GlobalVariables.salesSearchCriteria = "WHERE StartDate = '" + dtpSaleStartDate.Text + "'";
            }
            this.Close();
        }

        private void frmSalesSearch_Load(object sender, EventArgs e)
        {
            cbProductName.Enabled = false;
            dtpSaleStartDate.Enabled = false;
            //Sets the format of the Date adn Time picker to interface properly with SQL queries
            SetMyCustomFormat();
            //Populates product name and the associated list box
            PopulateProductName();
        }

        public void PopulateProductName()
        {
            //Populates product name and the associated list box
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

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dtpSaleStartDate.Format = DateTimePickerFormat.Custom;
            dtpSaleStartDate.CustomFormat = "yyyy'-'MM'-'dd";
        }
    }
}
