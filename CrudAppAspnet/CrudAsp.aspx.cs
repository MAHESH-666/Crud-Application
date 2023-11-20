using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudAppAspnet
{
    public partial class CrudAsp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        protected void Unnamed_Click(object sender, EventArgs e)
        {
            
        
                SqlDataSource1.InsertParameters["ClientName"].DefaultValue =
                    ((TextBox)GridView1.FooterRow.FindControl("TextBox6")).Text;

                SqlDataSource1.InsertParameters["ProductNumber"].DefaultValue =
                    ((TextBox)GridView1.FooterRow.FindControl("TextBox7")).Text;

                SqlDataSource1.InsertParameters["Productname"].DefaultValue =
                    ((TextBox)GridView1.FooterRow.FindControl("TextBox8")).Text;

                SqlDataSource1.InsertParameters["Quantity"].DefaultValue =
                    ((TextBox)GridView1.FooterRow.FindControl("TextBox9")).Text;

                SqlDataSource1.InsertParameters["DateAndTime"].DefaultValue =
                    ((TextBox)GridView1.FooterRow.FindControl("TextBox10")).Text;

                int rowsAffected = SqlDataSource1.Insert();

                if (rowsAffected > 0)
                {
                    
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "FailureScript", "alert('Insert Failed');", true);
                }
            }
   
        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            
        }
    }


}