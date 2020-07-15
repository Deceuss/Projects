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

namespace Module9Assessment1.Presentation_Layer.Categories
{
    public partial class frmCategoriesSearch : Form
    {
        public frmCategoriesSearch()
        {
            InitializeComponent();
        }

        //Closes the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Populates the Category combo box
        private void frmCategoriesSearch_Load(object sender, EventArgs e)
        {
            string selectQuery = "SELECT Categories.Category FROM Categories";

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
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

        //Sets the categorySearchCriteria string so that the when the view form reloads the
        //list box, it adds the categorySearchCriteria string to the end of the search query
        private void btnSearch_Click(object sender, EventArgs e)
        {
            GlobalVariables.categorySearchCriteria = "WHERE Category = '" + cbCategory.Text + "'";
            this.Close();
        }
    }
}
