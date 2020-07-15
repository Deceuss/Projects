using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9Assessment1.Business_Logic_Layer
{
    class Customers
    {
        //Declare variables for Customer
        private string firstName, lastName, category, address, suburb, state, gender, birthDate;
        private int customerID, postCode;

        //Declare set and get mathods
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Suburb
        {
            get { return suburb; }
            set { suburb = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public int Postcode
        {
            get { return postCode; }
            set { postCode = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        //Cosntructors for Customer Class
        //Default constructor
        public Customers() { }

        //Constructor with parameters
        public Customers(int customerid, string category, string firstname, string lastname, string gender,
                         string birthdate, string address, string suburb, string state, int postcode)
        {
            CustomerID = customerid;
            Category = category;
            FirstName = firstname;
            LastName = lastname;
            Gender = gender;
            BirthDate = birthdate;
            Address = address;
            Suburb = suburb;
            State = state;
            Postcode = postcode;
        }
    }
}
