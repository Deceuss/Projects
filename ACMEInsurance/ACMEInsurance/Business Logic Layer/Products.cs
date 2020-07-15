using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9Assessment1.Business_Logic_Layer
{
    class Products
    {
        //Declare variables for ProductTypes
        private string productType, productName;
        private int productID;
        private float yearlyPremium;

        //Get and set methods
        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        public string ProductType
        {
            get { return productType; }
            set { productType = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public float YearlyPremium
        {
            get { return yearlyPremium; }
            set { yearlyPremium = value; }
        }

        //Constructers for Products
        //Default constructor
        public Products() { }

        //Products constructor with parameters
        public Products(int productid, string producttype, string productname, float yearlypremium)
        {
            ProductID = productid;
            ProductType = producttype;
            ProductName = productname;
            YearlyPremium = yearlypremium;
        }
    }
}
