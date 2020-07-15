using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Module9Assessment1.Presentation_Layer;
using System.Data.SqlClient;
using Module9Assessment1.Data_Access_Layer;
using Module9Assessment1.Business_Logic_Layer;

namespace Module9Assessment1
{
    public partial class frmCustomerAdd : Form
    {
        public frmCustomerAdd()
        {
            InitializeComponent();
        }

        //Closes the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //The code in the add button adds an entry to the Customers table, but 
        //first makes check to ensure all fields have been filled
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please enter the first name.");
                return;
            }

            if (String.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Please enter the Last name.");
                return;
            }

            if (rbMale.Checked == false && rbFemale.Checked == false)
            {
                MessageBox.Show("Please select a Gender.");
                return;
            }

            if (String.IsNullOrEmpty(cbCategory.Text))
            {
                MessageBox.Show("Please select a Category.");
                return;
            }

            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please enter an Address.");
                return;
            }

            if (String.IsNullOrEmpty(txtSuburb.Text))
            {
                MessageBox.Show("Please enter a Suburb.");
                return;
            }

            if (String.IsNullOrEmpty(cbState.Text))
            {
                MessageBox.Show("Please select a State.");
                return;
            }

            if (String.IsNullOrEmpty(txtPostcode.Text))
            {
                MessageBox.Show("Please enter a postcode.");
                return;
            }

            int parsedValue;
            if (!int.TryParse(txtPostcode.Text, out parsedValue))
            {
                MessageBox.Show("Postcode must be an number.");
                return;
            }

            string gender = "M";
            if (rbFemale.Checked)
            {
                gender = "F";
            }

            Customers customer = new Customers(GlobalVariables.selectedCustomerID,
                                               lbCategoryID.Items[cbCategory.SelectedIndex].ToString(), 
                                               txtFirstName.Text, txtLastName.Text, gender, 
                                               dtpBirthDate.Text, txtAddress.Text, txtSuburb.Text, 
                                               cbState.Text, int.Parse(txtPostcode.Text));

            string addQuery;

            if (GlobalVariables.selectedCustomerID == 0)
            {
                //addQuery = "INSERT INTO Customers VALUES (" + customer.Category + ", '" + customer.FirstName + "', '";
                //addQuery = addQuery + customer.LastName + "', '" + customer.Address + "', '" + customer.Suburb + "', '";
                //addQuery = addQuery + customer.State + "', " + customer.Postcode + ", '" + customer.Gender + "', '" + customer.BirthDate + "')";
                addQuery = "sp_Customers_CreateCustomer";
            }
            else
            {
                addQuery = "sp_Customers_UpdateCustomer";
            }


            SqlConnection conn = ConnectionManager.DatabaseConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(addQuery, conn);


            cmd.CommandType = CommandType.StoredProcedure;
            if (GlobalVariables.selectedCustomerID != 0)
            {
                cmd.Parameters.AddWithValue("@CustomerID", customer.CustomerID);
            }
            cmd.Parameters.AddWithValue("@CategoryID", customer.Category);
            cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
            cmd.Parameters.AddWithValue("@LastName", customer.LastName);
            cmd.Parameters.AddWithValue("@Address", customer.Address);
            cmd.Parameters.AddWithValue("@Suburb", customer.Suburb);
            cmd.Parameters.AddWithValue("@State", customer.State);
            cmd.Parameters.AddWithValue("@Postcode", customer.Postcode);
            cmd.Parameters.AddWithValue("@Gender", customer.Gender);
            cmd.Parameters.AddWithValue("@BirthDate", customer.BirthDate);
            if (GlobalVariables.selectedCustomerID == 0)
            {
                cmd.Parameters.AddWithValue("@NewCustomerID", SqlDbType.Int).Direction = ParameterDirection.Output;
            }


            cmd.Transaction = conn.BeginTransaction();
            cmd.ExecuteNonQuery();
            cmd.Transaction.Commit();

            conn.Close();

            this.Close();
        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.CustomFormat = "yyyy'-'MM'-'dd";
        }


        //Loads the form in a specific format depending on if the user 
        //clicked the Add or Update button on the categories view form
        private void frmCustomerAdd_Load(object sender, EventArgs e)
        {
            SetMyCustomFormat();
            string selectQuery;

            //Populates the Category Combo Box
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
            if (GlobalVariables.selectedCustomerID == 0)
                btnAdd.Text = "&Add";
            else
                btnAdd.Text = "U&pdate";

            if (GlobalVariables.selectedCustomerID > 0)
            {
                selectQuery = "SELECT * FROM Customers WHERE CustomerID = " + GlobalVariables.selectedCustomerID.ToString();

                SqlConnection conn1 = ConnectionManager.DatabaseConnection();
                SqlDataReader rdr1 = null;
                try
                {
                    conn1.Open();
                    SqlCommand cmd1 = new SqlCommand(selectQuery, conn1);
                    rdr1 = cmd1.ExecuteReader();
                    rdr1.Read();
                    txtCustomerID.Text = rdr1["CustomerID"].ToString();
                    txtFirstName.Text = rdr1["FirstName"].ToString();
                    txtLastName.Text = rdr1["LastName"].ToString();
                    if (rdr1["Gender"].ToString() == "M")
                        rbMale.Checked = true;
                    else
                        rbFemale.Checked = true;
                    cbCategory.SelectedIndex = int.Parse(rdr1["CategoryID"].ToString()) - 1;
                    txtAddress.Text = rdr1["Address"].ToString();
                    txtSuburb.Text = rdr1["Suburb"].ToString();
                    cbState.Text = rdr1["State"].ToString();
                    txtPostcode.Text = rdr1["Postcode"].ToString();
                    dtpBirthDate.Text = rdr1["BirthDate"].ToString();
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
