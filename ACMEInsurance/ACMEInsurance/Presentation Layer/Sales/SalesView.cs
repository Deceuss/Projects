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
    public partial class frmSalesView : Form
    {
        public frmSalesView()
        {
            InitializeComponent();
        }

        //Opens add form and sets the selectedSalesID to 0, once the add form is closed,
        //the list view is reloaded
        private void btnAdd_Click(object sender, EventArgs e)
        {
            GlobalVariables.selectedSalesID = 0;
            frmSalesAdd addForm = new frmSalesAdd();
            addForm.ShowDialog();
            lvSales.Items.Clear();
            DisplaySales();
        }

        //Opens the search from and set the salesSearchCriteria to a null value, once the search form closes,
        //the list view repopulates
        private void btnSearch_Click(object sender, EventArgs e)
        {
            GlobalVariables.salesSearchCriteria = "";
            frmSalesSearch searchForm = new frmSalesSearch();
            searchForm.ShowDialog();
            lvSales.Items.Clear();
            DisplaySales();
        }

        
        //Closes the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //opens main menu on this form closing
        private void frmSalesView_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain mainForm = new frmMain();
            mainForm.Show();
        }

        //Deletes the selected entry, but asks the user for conformation first
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvSales.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Sale to Delete.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete this record?", "Sale Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            int selectedSaleID = int.Parse(lvSales.SelectedItems[0].Text);

            string deleteQuery = "sp_Sales_DeleteSale";

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(deleteQuery, conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SaleID", selectedSaleID);
            cmd.Transaction = conn.BeginTransaction();
            cmd.ExecuteNonQuery();
            cmd.Transaction.Commit();

            conn.Close();

            lvSales.Items.Clear();
            DisplaySales();
        }

        //Runs the DisplaySales method when the form is loaded
        private void frmSalesView_Load(object sender, EventArgs e)
        {
            DisplaySales();
        }

        //Populates the list view with information from the SQL database
        public void DisplaySales()
        {

            /*
             * SELECT dbo.Sales.SaleID, 
                dbo.Sales.CustomerID, 
                dbo.Sales.ProductID, 
                dbo.Sales.Payable, 
                CASE WHEN
				Sales.Payable = 'M'
			    THEN Products.YearlyPremium/12

			    WHEN
				    Sales.Payable = 'F'
			    THEN Products.YearlyPremium/26

			    WHEN
				    Sales.Payable = 'Y'
			    THEN Products.YearlyPremium
                END AS PremiumPayable, 
                dbo.Sales.StartDate
                FROM     dbo.Products INNER JOIN
                  dbo.Sales ON dbo.Products.ProductID = dbo.Sales.ProductID
             */
            string selectQuery;
            selectQuery = "SELECT Sales.SaleID, ";
            selectQuery += "Sales.CustomerID, ";
            selectQuery += "Sales.ProductID, ";
            selectQuery += "Sales.Payable, ";
            selectQuery += "CASE WHEN Sales.Payable = 'M' THEN Products.YearlyPremium/12 WHEN Sales.Payable = 'F' THEN Products.YearlyPremium/26 WHEN Sales.Payable = 'Y' THEN Products.YearlyPremium END AS PremiumPayable, ";
            selectQuery += "Sales.StartDate ";
            selectQuery += "FROM Products INNER JOIN Sales ON Products.ProductID = Sales.ProductID";
            selectQuery += " " + GlobalVariables.salesSearchCriteria;

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    string payable = "Fortnightly";
                    if (rdr["Payable"].ToString() == "M")
                    {
                        payable = "Monthly";
                    }
                    if (rdr["Payable"].ToString() == "Y")
                    {
                        payable = "Yearly";
                    }
                    string premiumPayable = rdr["PremiumPayable"].ToString();
                    Sales sale = new Sales(int.Parse(rdr["SaleID"].ToString()), 
                                            int.Parse(rdr["CustomerID"].ToString()), 
                                            int.Parse(rdr["ProductID"].ToString()), 
                                            payable,
                                            rdr["StartDate"].ToString());

                    ListViewItem lvi = new ListViewItem(sale.SaleID.ToString());
                    lvi.SubItems.Add(sale.CustoemrID.ToString());
                    lvi.SubItems.Add(sale.ProductID.ToString());
                    lvi.SubItems.Add(sale.Payable);
                    lvi.SubItems.Add(premiumPayable);
                    lvi.SubItems.Add(sale.StartDate);
                    lvSales.Items.Add(lvi);

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

        //opens the add form, but sets the selectedSalesID value to the selected list box item,
        //then reloads the list view when the add form is closed
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvSales.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Sale to Edit.");
                return;
            }
            GlobalVariables.selectedSalesID = int.Parse(lvSales.SelectedItems[0].Text);
            frmSalesAdd editForm = new frmSalesAdd();
            editForm.ShowDialog();
            lvSales.Items.Clear();
            DisplaySales();
        }
    }
}
