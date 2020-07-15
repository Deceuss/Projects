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


namespace Module9Assessment1.Presentation_Layer.Categories
{
    public partial class frmCategoriesAdd : Form
    {
        public frmCategoriesAdd()
        {
            InitializeComponent();
        }
        //Cancel button closes the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //The code in the add button adds an entry to the Categories table, but 
        //first makes check to ensure all fields have been filled
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCategoryToAdd.Text))
            {
                MessageBox.Show("Please enter a Category to add.");
            }

            Business_Logic_Layer.Categories category = new Business_Logic_Layer.Categories(GlobalVariables.selectedCategoryID, txtCategoryToAdd.Text);

            string addQuery;
            if (GlobalVariables.selectedCategoryID == 0)
            {
                addQuery = "sp_Categories_CreateCategory";
            }
            else
            {
                addQuery = "sp_Categories_UpdateCategory";
            }

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(addQuery, conn);

            cmd.CommandType = CommandType.StoredProcedure;
            if (GlobalVariables.selectedCategoryID != 0)
            {
                cmd.Parameters.AddWithValue("@CategoryID", category.CategoryID);
            }
            cmd.Parameters.AddWithValue("@Category", category.Category);
            if (GlobalVariables.selectedCategoryID == 0)
            {
                cmd.Parameters.AddWithValue("@NewCategoryID", SqlDbType.Int).Direction = ParameterDirection.Output;
            }
            cmd.Transaction = conn.BeginTransaction();
            cmd.ExecuteNonQuery();
            cmd.Transaction.Commit();

            conn.Close();

            this.Close();

        }

        //Loads the form in a specific format depending on if the user 
        //clicked the Add or Update button on the categories view form
        private void frmCategoriesAdd_Load(object sender, EventArgs e)
        {
            if (GlobalVariables.selectedCategoryID == 0)
                btnAdd.Text = "&Add";
            else
                btnAdd.Text = "U&pdate";
            string selectQuery;

            if (GlobalVariables.selectedCategoryID > 0)
            {
                selectQuery = "SELECT * FROM Categories WHERE CategoryID = " + GlobalVariables.selectedCategoryID.ToString();

                SqlConnection conn1 = ConnectionManager.DatabaseConnection();
                SqlDataReader rdr1 = null;
                try
                {
                    conn1.Open();
                    SqlCommand cmd1 = new SqlCommand(selectQuery, conn1);
                    rdr1 = cmd1.ExecuteReader();
                    rdr1.Read();
                    txtCategoryID.Text = rdr1["CategoryID"].ToString();
                    txtCategoryToAdd.Text = rdr1["Category"].ToString();
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
