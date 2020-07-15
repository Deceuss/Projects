using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9Assessment1
{
    class GlobalVariables
    {
        //Public int variables that can be used by all forms in the application
        public static int selectedCustomerID;
        public static int selectedSalesID;
        public static int selectedProductID;
        public static int selectedCategoryID;
        public static int selectedProductTypeID;

        //Public string variables that can be used by all forms in the application
        public static string customerSearchCriteria;
        public static string salesSearchCriteria;
        public static string productSearchCriteria;
        public static string categorySearchCriteria;
        public static string productTypeSearchCriteria;

        //This bool variable allows the customer and product view forms to know if the user is making a sale,
        //and display the 'Select' button under that circumstance
        public static bool makingSale;
    }


}
