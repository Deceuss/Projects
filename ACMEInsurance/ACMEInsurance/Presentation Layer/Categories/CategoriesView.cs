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
using Module9Assessment1.Business_Logic_Layer;
using Module9Assessment1.Data_Access_Layer;

namespace Module9Assessment1.Presentation_Layer.Categories
{
    public partial class frmCategoriesView : Form
    {
        public frmCategoriesView()
        {
            InitializeComponent();
        }

        //Opens add form and sets the selectedCategoryID to 0, once the add form is closed,
        //the list view is reloaded
        private void btnAdd_Click(object sender, EventArgs e)
        {
            GlobalVariables.selectedCategoryID = 0;
            frmCategoriesAdd addForm = new frmCategoriesAdd();
            addForm.ShowDialog();
            lvCategoires.Items.Clear();
            DisplayCategories();
        }

        //opens the add form, but sets the selectedCategoryID value to the selected list box item,
        //then reloads the list view when the add form is closed
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(lvCategoires.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please Select a Category to edit.");
                return;
            }
            GlobalVariables.selectedCategoryID = int.Parse(lvCategoires.SelectedItems[0].Text);
            frmCategoriesAdd editForm = new frmCategoriesAdd();
            editForm.ShowDialog();
            lvCategoires.Items.Clear();
            DisplayCategories();
        }

        //Opens the search from and set the categorySearchCriteria to a null value, once the search form closes,
        //the list view repopulates
        private void btnSearch_Click(object sender, EventArgs e)
        {
            GlobalVariables.categorySearchCriteria = "";
            frmCategoriesSearch searchForm = new frmCategoriesSearch();
            searchForm.ShowDialog();
            lvCategoires.Items.Clear();
            DisplayCategories();
        }

        //Closes the form
        private void btnCancel_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        //opens main menu on this form closing
        private void frmCategoriesView_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain mainForm = new frmMain();
            mainForm.Show();
        }

        //Runs the DisplayCategories method when the form is loaded
        private void frmCategoriesView_Load(object sender, EventArgs e)
        {
            DisplayCategories();
        }

        //Populates the list view with information from the SQL database
        private void DisplayCategories()
        {
            //This is the SQL query that will extarct data from the database
            string selectQuery;
            selectQuery = "SELECT Categories.CategoryID, Categories.Category FROM Categories";
            selectQuery += " " + GlobalVariables.categorySearchCriteria;

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    //Define the list of items

                    Business_Logic_Layer.Categories category = new Business_Logic_Layer.Categories(
                        int.Parse(rdr["CategoryID"].ToString()), rdr["Category"].ToString());
                    ListViewItem lvi = new ListViewItem(category.CategoryID.ToString());
                    lvi.SubItems.Add(category.Category);
                    lvCategoires.Items.Add(lvi);
                }
                if (rdr != null)
                {
                    rdr.Close();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful " + ex);
            }
        }

        //Deletes the selected entry, but asks the user for conformation first
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lvCategoires.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Category to delete.");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete this category?", "Category Delete", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.No)
            {
                return;
            }

            int selectedCategoryID = int.Parse(lvCategoires.SelectedItems[0].Text);

            string deleteQuery = "sp_Categories_DeleteCategory";
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(deleteQuery, conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CategoryID", selectedCategoryID);
            cmd.Transaction = conn.BeginTransaction();
            cmd.ExecuteNonQuery();
            cmd.Transaction.Commit();

            conn.Close();

            lvCategoires.Items.Clear();
            DisplayCategories();
        }
    }
}
