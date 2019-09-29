using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PartialClasses
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //LESSION 61
            //Customer C1 = new Customer();
            //C1.FirstName = "Dino";
            //C1.LastName = "Nik";

            //string FullName = C1.GetFullName();
            //Response.Write("Full Name = " + FullName + "<br/>");


            //PartialCustomer C2 = new PartialCustomer();
            //C2.FirstName = "Dinko";
            //C2.LastName = "Niko";
            //string FullName1 = C2.GetFullName();
            //Response.Write("Full Name = " + FullName1 + "<br/>");

            //LESSION 62


        }

        public class Customer
        {
            void CustomerMethod()
            {
            }
        }
        public class Employee
        {
            void CustomerMethod() 
            {
            }
        }

        public interface IEmployee
        {
            void EmployeeMethod();
        }

        public interface ICustomer
        {
            void CustomerMethod();
        }
    }
}