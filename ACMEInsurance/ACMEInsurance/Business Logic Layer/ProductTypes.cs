using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9Assessment1.Business_Logic_Layer
{
     public class ProductTypes
    {
        //Declare variables for ProductTypes
        private string productType;
        private int productTypeID;

        //Get and set methods
        public int ProductTypeID
        {
            get { return productTypeID; }
            set { productTypeID = value; }
        }

        public string ProductType
        {
            get { return productType; }
            set { productType = value; }
        }

        //Cosntructors for ProductTypes
        //Default constructor
        public ProductTypes() { }

        //Constructor with parameters
        public ProductTypes(int producttypeid, string producttype)
        {
            ProductTypeID = producttypeid;
            ProductType = producttype;
        }
    }
}
