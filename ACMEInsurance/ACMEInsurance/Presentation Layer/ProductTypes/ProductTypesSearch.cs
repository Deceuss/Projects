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

namespace Module9Assessment1.Presentation_Layer.ProductTypes
{
    public partial class frmProductTypesSearch : Form
    {
        public frmProductTypesSearch()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Populates the product type combo box
        private void frmProductTypesSearch_Load(object sender, EventArgs e)
        {
            string selectQuery = "SELECT ProductTypes.ProductType FROM ProductTypes";

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
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

        //Sets the productTypeSearchCriteria string so that the when the view form reloads the
        //list box, it adds the productTypeSearchCriteria string to the end of the search query
        private void btnSearch_Click(object sender, EventArgs e)
        {
            GlobalVariables.productTypeSearchCriteria = "WHERE ProductType = '" + cbProductType.Text + "'";
            this.Close();
        }
    }
}
