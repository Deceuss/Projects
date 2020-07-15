using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module9Assessment1.Presentation_Layer
{
    public partial class frmTutorial : Form
    {
        public frmTutorial()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*Insert a form with a picture of the Categories forms with visual descriptors on using them");
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*Insert a form with a picture of the Customers forms with visual descriptors on using them");
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*Insert a form with a picture of the Products forms with visual descriptors on using them");
        }

        private void btnProductTypes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*Insert a form with a picture of the Product Types forms with visual descriptors on using them");
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*Insert a form with a picture of the Sales forms with visual descriptors on using them");
        }
    }
}
