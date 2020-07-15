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
    public partial class frmCustomersView : Form
    {
        public frmCustomersView()
        {
            InitializeComponent();
        }

        //Closes the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //opens main menu on this form closing
        private void frmCustomersView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GlobalVariables.makingSale != true)
            {
                frmMain mainForm = new frmMain();
                mainForm.Show();
            }
            
        }

        //Opens add form and sets the selectedCustomerID to 0, once the add form is closed,
        //the list view is reloaded
        private void btnAdd_Click(object sender, EventArgs e)
        {
            GlobalVariables.selectedCustomerID = 0;
            frmCustomerAdd addForm = new frmCustomerAdd();
            addForm.ShowDialog();
            lvCustomers.Items.Clear();
            DisplayCustomers();
        }

        //Opens the search from and set the customerSearchCriteria to a null value, once the search form closes,
        //the list view repopulates
        private void btnSearch_Click(object sender, EventArgs e)
        {
            GlobalVariables.customerSearchCriteria = "";
            frmCustomersSearch searchForm = new frmCustomersSearch();
            searchForm.ShowDialog();
            lvCustomers.Items.Clear();
            DisplayCustomers();
        }

        //opens the add form, but sets the selectedCustomerID value to the selected list box item,
        //then reloads the list view when the add form is closed
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvCustomers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Customer to update.");
                return;
            }
            GlobalVariables.selectedCustomerID = int.Parse(lvCustomers.SelectedItems[0].Text);
            frmCustomerAdd editForm = new frmCustomerAdd();
            editForm.ShowDialog();
            lvCustomers.Items.Clear();
            DisplayCustomers();
        }

        //Sets the Select button to enabled and visible if user is navigating from and 
        //runs the DisplayCustomers method when the form is loaded
        private void frmCustomersView_Load(object sender, EventArgs e)
        {
            if (GlobalVariables.makingSale == true)
            {
                btnSelect.Visible = true;
                btnSelect.Enabled = true;
            }
            DisplayCustomers();
        }

        //Populates the list view with information from the SQL database
        public void DisplayCustomers()
        {
            string selectQuery;

            selectQuery = "SELECT Customers.CustomerID, ";
            selectQuery = selectQuery + "Categories.Category, ";
            selectQuery = selectQuery + "Customers.FirstName, ";
            selectQuery = selectQuery + "Customers.LastName, ";
            selectQuery = selectQuery + "Customers.Address, ";
            selectQuery = selectQuery + "Customers.Suburb, ";
            selectQuery = selectQuery + "Customers.State, ";
            selectQuery = selectQuery + "Customers.Postcode, ";
            selectQuery = selectQuery + "Customers.Gender, ";
            selectQuery = selectQuery + "Customers.BirthDate ";
            selectQuery = selectQuery + "FROM Customers INNER JOIN ";
            selectQuery = selectQuery + "Categories ON Customers.CategoryID = Categories.CategoryID";
            selectQuery = selectQuery + " " + GlobalVariables.customerSearchCriteria;

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string gender = "Male";
                    if (rdr["Gender"].ToString() == "F")
                    {
                        gender = "Female";
                    }

                    Customers customer = new Customers(int.Parse(rdr["CustomerID"].ToString()),
                                            rdr["Category"].ToString(), rdr["FirstName"].ToString(),
                                            rdr["LastName"].ToString(), gender, rdr["BirthDate"].ToString(),
                                            rdr["Address"].ToString(), rdr["Suburb"].ToString(),
                                            rdr["State"].ToString(), int.Parse(rdr["Postcode"].ToString()));

                    ListViewItem lvi = new ListViewItem(customer.CustomerID.ToString());
                    lvi.SubItems.Add(customer.Category);
                    lvi.SubItems.Add(customer.FirstName);
                    lvi.SubItems.Add(customer.LastName);
                    lvi.SubItems.Add(customer.Gender);
                    lvi.SubItems.Add(customer.BirthDate);
                    lvi.SubItems.Add(customer.Address);
                    lvi.SubItems.Add(customer.Suburb);
                    lvi.SubItems.Add(customer.State);
                    lvi.SubItems.Add(customer.Postcode.ToString());
                    lvCustomers.Items.Add(lvi);
                }
                if(rdr != null)
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
            if (lvCustomers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Customer to Delete.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete this record?", "Customer Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            int selectedCustomerID = int.Parse(lvCustomers.SelectedItems[0].Text);

            string deleteQuery = "sp_Customers_DeleteCustomer";

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(deleteQuery, conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustomerID", selectedCustomerID);
            cmd.Transaction = conn.BeginTransaction();
            cmd.ExecuteNonQuery();
            cmd.Transaction.Commit();

            conn.Close();

            lvCustomers.Items.Clear();
            DisplayCustomers();
        }

        //If the user is navigating from the 'Add sale' form, then the select button allows
        //the user to parse the selected CustomerID to the 'Add sale' form
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lvCustomers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Customer to add to the sale.");
                return;
            }
            GlobalVariables.selectedCustomerID = int.Parse(lvCustomers.SelectedItems[0].Text);
            this.Close();
        }
    }
}
