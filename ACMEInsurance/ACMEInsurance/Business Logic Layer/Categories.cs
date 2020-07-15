using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9Assessment1.Business_Logic_Layer
{
    public class Categories
    {
        //Declare values for categories
        private string category;
        private int categoryID;

        //Set and Get methods
        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        //Cosntructors for Categories class
        //Default Constructor
        public Categories() { }

        //parameterized Constructor
        public Categories(int categoryid, string category)
        {
            CategoryID = categoryid;
            Category = category;
        }
    }
}
