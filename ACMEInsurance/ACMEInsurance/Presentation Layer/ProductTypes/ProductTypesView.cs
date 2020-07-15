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

namespace Module9Assessment1.Presentation_Layer.ProductTypes
{
    public partial class frmProductTypesView : Form
    {
        public frmProductTypesView()
        {
            InitializeComponent();
        }

        //Opens add form and sets the selectedProductTypeID to 0, once the add form is closed,
        //the list view is reloaded
        private void btnAdd_Click(object sender, EventArgs e)
        {
            GlobalVariables.selectedProductTypeID = 0;
            frmProductTypesAdd addForm = new frmProductTypesAdd();
            addForm.ShowDialog();
            lvProductTypes.Items.Clear();
            DisplayProductTypes();
        }

        //opens the add form, but sets the selectedProductTypeID value to the selected list box item,
        //then reloads the list view when the add form is closed
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvProductTypes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please Select a Category to edit.");
                return;
            }
            GlobalVariables.selectedProductTypeID = int.Parse(lvProductTypes.SelectedItems[0].Text);
            frmProductTypesAdd editForm = new frmProductTypesAdd();
            editForm.ShowDialog();
            lvProductTypes.Items.Clear();
            DisplayProductTypes();
        }

        //Opens the search from and set the productTypeSearchCriteria to a null value, once the search form closes,
        //the list view repopulates
        private void btnSearch_Click(object sender, EventArgs e)
        {
            GlobalVariables.productTypeSearchCriteria = "";
            frmProductTypesSearch searchForm = new frmProductTypesSearch();
            searchForm.ShowDialog();
            lvProductTypes.Items.Clear();
            DisplayProductTypes();
        }

        //Deletes the selected entry, but asks the user for conformation first
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvProductTypes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Product Type to delete.");
            }
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete this Product Type?", "Product Type Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            int selectedProductTypeID = int.Parse(lvProductTypes.SelectedItems[0].Text);

            string deleteQuery = "sp_ProductTypes_DeleteProductType";
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(deleteQuery, conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProductTypeID", selectedProductTypeID);
            cmd.Transaction = conn.BeginTransaction();
            cmd.ExecuteNonQuery();
            cmd.Transaction.Commit();

            conn.Close();

            lvProductTypes.Items.Clear();
            DisplayProductTypes();
        }

        //Closes the form
        private void btnCancel_Click(object sender, EventArgs e)
        {  
            this.Close();
        }

        //opens main menu on this form closing
        private void frmProductTypesView_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain mainForm = new frmMain();
            mainForm.Show();
        }

        //Runs the DisplayProductTypes method when the form is loaded
        private void frmProductTypesView_Load(object sender, EventArgs e)
        {
            DisplayProductTypes();
        }

        //Populates the list view with information from the SQL database
        public void DisplayProductTypes()
        {
            string selectQuery;
            selectQuery = "SELECT * FROM ProductTypes";
            selectQuery += " " + GlobalVariables.productTypeSearchCriteria;

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    Business_Logic_Layer.ProductTypes productType = new Business_Logic_Layer.ProductTypes(
                        int.Parse(rdr["ProductTypeID"].ToString()), rdr["ProductType"].ToString());
                    ListViewItem lvi = new ListViewItem(productType.ProductTypeID.ToString());
                    lvi.SubItems.Add(productType.ProductType);
                    lvProductTypes.Items.Add(lvi);
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
    }
}
