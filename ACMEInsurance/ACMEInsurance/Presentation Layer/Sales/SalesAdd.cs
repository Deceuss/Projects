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

namespace Module9Assessment1.Presentation_Layer
{
    public partial class frmSalesAdd : Form
    {
        public frmSalesAdd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //The code in the add button adds an entry to the Sales table, but 
        //first makes check to ensure all fields have been filled
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Stop user continuing without filling out required fields
            if (GlobalVariables.selectedCustomerID == 0)
            {
                MessageBox.Show("Please select a Customer.");
                return;
            }
            if (GlobalVariables.selectedProductID == 0)
            {
                MessageBox.Show("Please Select a Product.");
                return;
            }
            if (String.IsNullOrEmpty(cbPayable.Text))
            {
                MessageBox.Show("Please select a payable option.");
                return;
            }

            //Sets the payable value to M as default, changes based on input
            string payable = "M";
            if (cbPayable.Text == "Fortnightly")
            {
                payable = "F";
            }
            if (cbPayable.Text == "Yearly")
            {
                payable = "Y";
            }

            //Sets Sales object values
            Sales sale = new Sales(GlobalVariables.selectedSalesID, int.Parse(txtCustomerID.Text), int.Parse(txtProductID.Text), payable, dtpSaleDate.Text);
            string addQuery;
            //Sets addQuery based on the selectedSalesID
            if (GlobalVariables.selectedSalesID == 0)
            {
                addQuery = "sp_Sales_CreateSale";
            }
            else
            {
                addQuery = "sp_Sales_UpdateSale";
            }
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(addQuery, conn);

            cmd.CommandType = CommandType.StoredProcedure;

            //If user is updating a sale, Uses the current Sale ID
            if(GlobalVariables.selectedSalesID != 0)
            {
                cmd.Parameters.AddWithValue("@SaleID", sale.SaleID);
            }

            cmd.Parameters.AddWithValue("@CustomerID", sale.CustoemrID);
            cmd.Parameters.AddWithValue("@ProductID", sale.ProductID);
            cmd.Parameters.AddWithValue("@Payable", sale.Payable);
            cmd.Parameters.AddWithValue("@StartDate", sale.StartDate);

            //If user is making new sale, sets new Sale ID
            if (GlobalVariables.selectedSalesID == 0)
            {
                cmd.Parameters.AddWithValue("@NewSaleID", SqlDbType.Int).Direction = ParameterDirection.Output;
            }
            cmd.Transaction = conn.BeginTransaction();
            cmd.ExecuteNonQuery();
            cmd.Transaction.Commit();

            conn.Close();

            this.Close();
        }

        private void frmSalesAdd_Load(object sender, EventArgs e)
        {
            GlobalVariables.makingSale = true;
            SetMyCustomFormat();
            LoadSales();
        }

        private void frmSalesAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Resets values used from GlobalVariables upon the form closing
            GlobalVariables.makingSale = false;
            GlobalVariables.selectedCustomerID = 0;
            GlobalVariables.selectedProductID = 0;
        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            //Opens the Customers View Form, allows all functionally of the Customer view form
            frmCustomersView viewForm = new frmCustomersView();
            viewForm.ShowDialog();
            if (GlobalVariables.selectedCustomerID > 0)
            {
                string selectQuery = "SELECT * FROM Customers WHERE CustomerID = " + GlobalVariables.selectedCustomerID.ToString();

                SqlConnection conn = ConnectionManager.DatabaseConnection();
                SqlDataReader rdr = null;
                //Fills the Customer information
                try
                {
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand(selectQuery, conn);
                    rdr = cmd1.ExecuteReader();
                    rdr.Read();
                    txtCustomerID.Text = rdr["CustomerID"].ToString();
                    txtFirstName.Text = rdr["FirstName"].ToString();
                    txtLastName.Text = rdr["LastName"].ToString();
                    rdr.Close();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unsuccessful" + ex);
                }
            }
        }

        private void btnSelectProductID_Click(object sender, EventArgs e)
        {
            //Opens the Products View Form, allows all functionally of the Products view form
            frmProductsView viewForm = new frmProductsView();
            viewForm.ShowDialog();
            if(GlobalVariables.selectedProductID > 0)
            {
                string selectQuery = "SELECT * FROM Products INNER JOIN ProductTypes ON " +
                    "Products.ProductTypeID = ProductTypes.ProductTypeID WHERE ProductID = " + GlobalVariables.selectedProductID.ToString();

                SqlConnection conn1 = ConnectionManager.DatabaseConnection();
                SqlDataReader rdr1 = null;
                //Fills out the product information based on the selected product ID
                try
                {
                    conn1.Open();
                    SqlCommand cmd1 = new SqlCommand(selectQuery, conn1);
                    rdr1 = cmd1.ExecuteReader();
                    rdr1.Read();
                    txtProductID.Text = rdr1["ProductID"].ToString();
                    txtProductType.Text = rdr1["ProductType"].ToString();
                    txtProductName.Text = rdr1["ProductName"].ToString();
                    txtYearlyPremium.Text = rdr1["YearlyPremium"].ToString();
                    rdr1.Close();
                    conn1.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unsuccessful" + ex);
                }
            }
        }

        //Loads the form in a specific format depending on if the user 
        //clicked the Add or Update button on the categories view form
        public void LoadSales()
        {
            if (GlobalVariables.selectedSalesID == 0)
                btnAdd.Text = "&Add";
            else
                btnAdd.Text = "U&pdate";

            if (GlobalVariables.selectedSalesID > 0)
            {
                string selectQuery = "SELECT * FROM Sales WHERE SaleID = " + GlobalVariables.selectedSalesID;
                SqlConnection conn = ConnectionManager.DatabaseConnection();
                SqlDataReader rdr = null;

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(selectQuery, conn);
                    rdr = cmd.ExecuteReader();
                    rdr.Read();
                    GlobalVariables.selectedCustomerID = int.Parse(rdr["CustomerID"].ToString());
                    GlobalVariables.selectedProductID = int.Parse(rdr["ProductID"].ToString());
                    rdr.Close();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unsuccesful " + ex);
                }

                selectQuery = "SELECT CustomerID, FirstName, LastName FROM Customers WHERE CustomerID = " + GlobalVariables.selectedCustomerID;
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(selectQuery, conn);
                    rdr = cmd.ExecuteReader();
                    rdr.Read();
                    txtCustomerID.Text = rdr["CustomerID"].ToString();
                    txtFirstName.Text = rdr["FirstName"].ToString();
                    txtLastName.Text = rdr["LastName"].ToString();
                    rdr.Close();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unsuccesful " + ex);
                }

                selectQuery = "SELECT * FROM Products INNER JOIN ProductTypes ON " +
                    "Products.ProductTypeID = ProductTypes.ProductTypeID WHERE ProductID = " + GlobalVariables.selectedProductID.ToString();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(selectQuery, conn);
                    rdr = cmd.ExecuteReader();
                    rdr.Read();
                    txtProductID.Text = rdr["ProductID"].ToString();
                    txtProductType.Text = rdr["ProductType"].ToString();
                    txtProductName.Text = rdr["ProductName"].ToString();
                    txtYearlyPremium.Text = rdr["YearlyPremium"].ToString();
                    rdr.Close();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unsuccesful " + ex);
                }

                selectQuery = "SELECT Payable, StartDate FROM Sales WHERE SaleID = " + GlobalVariables.selectedSalesID.ToString();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(selectQuery, conn);
                    rdr = cmd.ExecuteReader();
                    rdr.Read();
                    string Payable = rdr["Payable"].ToString();
                    string payable = "Fortnightly";
                    if (Payable == "M")
                    {
                        payable = "Monthly";
                    }
                    if (Payable == "Y")
                    {
                        payable = "Yearly";
                    }
                    cbPayable.Text = payable;
                    dtpSaleDate.Value = DateTime.Parse(rdr["StartDate"].ToString());

                    rdr.Close();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unsuccesful " + ex);
                }
            }
        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dtpSaleDate.Format = DateTimePickerFormat.Custom;
            dtpSaleDate.CustomFormat = "yyyy'-'MM'-'dd";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears/Resets fields
            txtCustomerID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtProductID.Clear();
            txtProductName.Clear();
            txtProductType.Clear();
            txtYearlyPremium.Clear();
            dtpSaleDate.ResetText();
        }
    }
}
