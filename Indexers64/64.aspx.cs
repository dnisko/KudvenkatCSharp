using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Indexers64
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["Session1"] = "Session1 Data";
            //Session["Session2"] = "Session2 Data";

            //Response.Write("Session 1 Data = "+Session[0].ToString());
            //Response.Write("<br/>");
            //Response.Write("Session 2 Data = " + Session["Session2"].ToString());

            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("Select * from tblEmployee", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    // Using integral indexer to retrieve Id column value
                    Response.Write("Id = " + rdr[0].ToString() + " ");
                    // Using string indexer to retrieve Id column value
                    Response.Write("Name = " + rdr["Name"].ToString());
                    Response.Write("<br/>");
                }
            }
        }
    }
}