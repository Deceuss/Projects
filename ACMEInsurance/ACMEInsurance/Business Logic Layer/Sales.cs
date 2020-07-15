using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9Assessment1.Business_Logic_Layer
{
    class Sales
    {
        //Declare Sales variables
        private string payable, startDate;
        private int saleID, productID, customerID;
        //private float premiumPayable;

        //Declare get and set methods
        public int SaleID
        {
            get { return saleID; }
            set { saleID = value; }
        }

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        public int CustoemrID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public string Payable
        {
            get { return payable; }
            set { payable = value; }
        }

        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        /*public float PremiumPayable
        {
            get { return premiumPayable; }
            set {premiumPayable = value; }
        }*/

        //Constructors for Sales
        //Default constructor
        public Sales() { }

        //Constructor with parameters
        public Sales(int saleid, int customerid, int productid, string payable, string startdate)
        {
            SaleID = saleid;
            ProductID = productid;
            customerID = customerid;
            Payable = payable;
            //PremiumPayable = premiumpayable;
            StartDate = startdate;
        }
    }
}
