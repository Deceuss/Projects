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

namespace Module9Assessment1.Presentation_Layer
{
    public partial class frmProductsView : Form
    {
        public frmProductsView()
        {
            InitializeComponent();
        }

        //Closes the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //opens the add form, but sets the selectedProductID value to the selected list box item,
        //then reloads the list view when the add form is closed
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Product to update.");
                return;
            }
            GlobalVariables.selectedProductID = int.Parse(lvProducts.SelectedItems[0].Text);
            frmProductsAdd editForm = new frmProductsAdd();
            editForm.ShowDialog();
            lvProducts.Items.Clear();
            DisplayProducts();
        }

        //Opens add form and sets the selectedProductID to 0, once the add form is closed,
        //the list view is reloaded
        private void btnAdd_Click(object sender, EventArgs e)
        {
            GlobalVariables.selectedProductID = 0;
            frmProductsAdd addForm = new frmProductsAdd();
            addForm.ShowDialog();
            lvProducts.Items.Clear();
            DisplayProducts();
        }

        //Opens the search from and set the productSearchCriteria to a null value, once the search form closes,
        //the list view repopulates
        private void btnSearch_Click(object sender, EventArgs e)
        {
            GlobalVariables.productSearchCriteria = "";
            frmProductsSearch searchForm = new frmProductsSearch();
            searchForm.ShowDialog();
            lvProducts.Items.Clear();
            DisplayProducts();
        }

        //opens main menu on this form closing
        private void frmProductsView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GlobalVariables.makingSale != true)
            {
                frmMain mainForm = new frmMain();
                mainForm.Show();
            }
        }

        //Sets the Select button to enabled and visible if user is navigating from and 
        //runs the DisplayProducts method when the form is loaded
        private void frmProductsView_Load(object sender, EventArgs e)
        {
            if (GlobalVariables.makingSale == true)
            {
                btnSelect.Visible = true;
                btnSelect.Enabled = true;
            }
            DisplayProducts();
        }

        //Populates the list view with information from the SQL database
        public void DisplayProducts()
        {
            //Sets SQL query to show product information
            string selectQuery;
            selectQuery = "SELECT Products.ProductID, " +
                          "Products.ProductName, " +
                          "ProductTypes.ProductType, " +
                          "Products.YearlyPremium " +
                          "FROM Products INNER JOIN ProductTypes ON " +
                          "Products.ProductTypeID = ProductTypes.ProductTypeID";
            selectQuery += " " + GlobalVariables.productSearchCriteria;

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    //decimal yearlyPremium = decimal.Parse(rdr["YearlyPremium"].ToString());

                    Products product = new Products(int.Parse(rdr["ProductID"].ToString()),
                                                    rdr["ProductType"].ToString(),
                                                    rdr["ProductName"].ToString(),
                                                    float.Parse(rdr["YearlyPremium"].ToString()));
                    ListViewItem lvi = new ListViewItem(product.ProductID.ToString());
                    lvi.SubItems.Add(product.ProductName);
                    lvi.SubItems.Add(product.ProductType);
                    lvi.SubItems.Add($"${product.YearlyPremium.ToString()}");
                    lvProducts.Items.Add(lvi);
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
            if (lvProducts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Product to Delete.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete this record?", "Product Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            int selectedProductID = int.Parse(lvProducts.SelectedItems[0].Text);

            string deleteQuery = "sp_Products_DeleteProduct";

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(deleteQuery, conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProductID", selectedProductID);
            cmd.Transaction = conn.BeginTransaction();
            cmd.ExecuteNonQuery();
            cmd.Transaction.Commit();

            conn.Close();

            lvProducts.Items.Clear();
            DisplayProducts();
        }

        //If the user is navigating from the 'Add sale' form, then the select button allows
        //the user to parse the selected ProductID to the 'Add sale' form
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Product.");
                return;
            }
            GlobalVariables.selectedProductID = int.Parse(lvProducts.SelectedItems[0].Text);
            this.Close();
        }
    }
}
