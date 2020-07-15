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
    public partial class frmCustomersSearch : Form
    {
        public frmCustomersSearch()
        {
            InitializeComponent();
        }

        //The following four methods set certain search options as enabled or disabled
        //Depending on what radio button the user has pressed
        private void rbListAll_Click(object sender, EventArgs e)
        {
            txtLastName.Enabled = false;
            cbCategory.Enabled = false;
            txtPostcode.Enabled = false;
        }

        private void rbPostcode_Click(object sender, EventArgs e)
        {
            txtLastName.Enabled = false;
            cbCategory.Enabled = false;
            txtPostcode.Enabled = true;
        }

        private void rbCategory_Click(object sender, EventArgs e)
        {
            txtLastName.Enabled = false;
            cbCategory.Enabled = true;
            txtPostcode.Enabled = false;
        }

        private void rbLastName_Click(object sender, EventArgs e)
        {
            txtLastName.Enabled = true;
            cbCategory.Enabled = false;
            txtPostcode.Enabled = false;
        }


        private void frmCustomersSearch_Load(object sender, EventArgs e)
        {
            txtLastName.Enabled = false;
            cbCategory.Enabled = false;
            txtPostcode.Enabled = false;

            //The following code populates the Category Combo box and the associated List box
            string selectQuery;

            selectQuery = "SELECT * FROM Categories";

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lbCategoryID.Items.Add(rdr["CategoryID"].ToString());
                    cbCategory.Items.Add(rdr["Category"].ToString());
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

        //Sets the customerSearchCriteria string so that the when the view form reloads the
        //list box, it adds the customerSearchCriteria string to the end of the search query
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Sets the search criteria based on the user selection
            if (rbListAll.Checked == true)
            {
                GlobalVariables.customerSearchCriteria = "";
            }

            if (rbLastName.Checked == true)
            {
                GlobalVariables.customerSearchCriteria = "WHERE LastName = '" + txtLastName.Text + "'";
            }

            if (rbCategory.Checked == true)
            {
                GlobalVariables.customerSearchCriteria = "WHERE Customers.CategoryID = '" + lbCategoryID.Items[cbCategory.SelectedIndex].ToString() + "'";
            }

            if (rbPostcode.Checked == true)
            {
                GlobalVariables.customerSearchCriteria = "WHERE PostCode = '" + txtPostcode.Text + "'";
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
