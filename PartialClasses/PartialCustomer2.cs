using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialClasses
{
    public partial class PartialCustomer
    {
        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }
    }
}