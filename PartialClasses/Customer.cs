using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialClasses
{
    public class Customer
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName 
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }
    }
}