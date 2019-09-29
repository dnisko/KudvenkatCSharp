using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static PartialClasses.WebForm1;

namespace PartialClasses
{
    //LESSION 61
    //public partial class PartialCustomer
    //{
    //    private string _firstName;
    //    private string _lastName;

    //    public string FirstName
    //    {
    //        get { return _firstName; }
    //        set { _firstName = value; }
    //    }

    //    public string LastName
    //    {
    //        get { return _lastName; }
    //        set { _lastName = value; }
    //    }
    //}

    //LESSION 62
    public partial class SamplePartianClass : ICustomer//Customer//cannot inherit from multiple classes  (partial class)
                                                       //for interfaces, all members must be implemented
    {
        public void Method1()
        {

        }
        public void EmployeeMethod()
        {

        }
        public void CustomerMethod()
        {

        }
    }
}