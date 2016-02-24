using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eCommerce
{
    public partial class PlaceOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Request.QueryString["item1"];
            Label3.Text = Request.QueryString["item2"];
            Label5.Text = Request.QueryString["item3"];

            Label2.Text = Request.QueryString["quantity1"];
            Label4.Text = Request.QueryString["quantity2"];
            Label6.Text = Request.QueryString["quantity3"];
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("checkout.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("orderconfirmed.aspx");
        }
    }
}