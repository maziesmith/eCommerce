using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace eCommerce
{
    public partial class Checkout : System.Web.UI.Page
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Databases\eCommerce.mdf;Integrated Security=True;Connect Timeout=30");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            //Sql Connection Code
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into checkout values('"+TextBox1.Text+ "','" + TextBox1.Text + "','" + TextBox1.Text + "')";
            con.Close();


            Response.Redirect("PlaceOrder.aspx?item1=" + TextBox1.Text + "&item2=" + TextBox2.Text + "&item3=" + TextBox3.Text + 
                "&quantity1=" + DropDownList1.Text.ToString() + "&quantity2=" + DropDownList2.Text.ToString() + "&quantity3=" + DropDownList3.Text.ToString());
            //Server.Transfer("PlaceOrder.aspx");
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}