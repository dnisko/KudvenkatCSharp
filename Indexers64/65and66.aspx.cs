using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Indexers64
{
    public partial class _65 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Company company = new Company();

            //LESSON 65
            //Response.Write("Name of Employee with Id = 2: " + company[2]);
            //Response.Write("<br/>");

            //Response.Write("Name of Employee with Id = 5: " + company[5]);
            //Response.Write("<br/>");

            //Response.Write("Name of Employee with Id = 8: " + company[8]);
            //Response.Write("<br/>");
            //Response.Write("<br/>");

            //Response.Write("Changing names of employees with Id = 2, 5 & 8");
            //Response.Write("<br/>");
            //Response.Write("<br/>");


            //company[2] = "2nd Employee Name changed";
            //company[5] = "5th Employee Name changed";
            //company[8] = "8th Employee Name changed";


            //Response.Write("Name of Employee with Id = 2: " + company[2]);
            //Response.Write("<br/>");

            //Response.Write("Name of Employee with Id = 5: " + company[5]);
            //Response.Write("<br/>");

            //Response.Write("Name of Employee with Id = 8: " + company[8]);
            //Response.Write("<br/>");

            //LESSON 66
            Response.Write("Before update");
            Response.Write("<br/>");
            Response.Write("Total Male Employees = " + company["Male"]);
            Response.Write("<br/>");
            Response.Write("Total Female Employees = " + company["Female"]);
            Response.Write("<br/>");
            Response.Write("<br/>");

            company["Male"] = "Female";

            Response.Write("After update");
            Response.Write("<br/>");
            Response.Write("Total Male Employees = " + company["Male"]);
            Response.Write("<br/>");
            Response.Write("Total Female Employees = " + company["Female"]);
            Response.Write("<br/>");

        }
    }
}