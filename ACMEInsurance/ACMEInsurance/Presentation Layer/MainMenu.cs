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
using Module9Assessment1.Presentation_Layer;
using Module9Assessment1.Presentation_Layer.Categories;
using Module9Assessment1.Presentation_Layer.ProductTypes;
using Module9Assessment1.Business_Logic_Layer;
using Module9Assessment1.Data_Access_Layer;

namespace Module9Assessment1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //Opens the Category View form
        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalVariables.categorySearchCriteria = "";
            frmCategoriesView viewForm = new frmCategoriesView();
            viewForm.Show();
            this.Hide();
        }

        //Opens the Customers View form
        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalVariables.customerSearchCriteria = "";
            frmCustomersView viewForm = new frmCustomersView();
            viewForm.Show();
            this.Hide();
        }

        //Opens the Products View form
        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalVariables.productSearchCriteria = "";
            frmProductsView viewForm = new frmProductsView();
            viewForm.Show();
            this.Hide();
        }

        //Opens the Product Types View form
        private void productTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalVariables.productTypeSearchCriteria = "";
            frmProductTypesView viewForm = new frmProductTypesView();
            viewForm.Show();
            this.Hide();
        }

        //Opens the Sales View form
        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalVariables.salesSearchCriteria = "";
            frmSalesView viewForm = new frmSalesView();
            viewForm.Show();
            this.Hide();
        }

        //Exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //takes user to about form
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout aboutForm = new frmAbout();
            aboutForm.Show();
        }

        //Takes user to the tutorial form
        private void tutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTutorial tutorialForm = new frmTutorial();
            tutorialForm.Show();
        }

        //Populates the List box on the main form
        private void frmMain_Load(object sender, EventArgs e)
        {
            DisplayDashboard();
        }

        //Code to populate the list box onthe Main Menu
        public void DisplayDashboard()
        {
            string selectQuery;

            selectQuery = "SELECT Products.ProductName, ProductTypes.ProductType, COUNT(Sales.ProductID) AS NumOfPurchases FROM Products " +
                            "INNER JOIN ProductTypes ON Products.ProductTypeID = ProductTypes.ProductTypeID " +
                            "INNER JOIN Sales ON Products.ProductID = Sales.ProductID " +
                            "GROUP BY Products.ProductName, ProductTypes.ProductType";

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;
            conn.Open();
            SqlCommand cmd = new SqlCommand(selectQuery, conn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                ListViewItem lvi = new ListViewItem(rdr["ProductName"].ToString());
                lvi.SubItems.Add(rdr["ProductType"].ToString());
                lvi.SubItems.Add(rdr["NumOfPurchases"].ToString());
                lvDashboard.Items.Add(lvi);
            }
            if (rdr != null)
            {
                rdr.Close();
            }
            conn.Close();
        }
    }
}
