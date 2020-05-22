using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class Product1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddnewUser_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into dbo.product_name values('" +txtproductname.Text + "','"+txtunit.Text+"')";
            cmd.ExecuteNonQuery();
            Label8.Text = "Product Added Successfully";
            txtunit.Text = "";
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE From product_name WHERE prod_id ='" + 1+ "'";
            SqlCommand comm = new SqlCommand(query, con);
            comm.ExecuteNonQuery();
            Label8.Text = "Student is Deleted Successfully";
            con.Close();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void update_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update Product_name Set product_name = '" + txtproductname.Text + "',units = '"+txtunit.Text+ "'WHERE prod_id = '" + txtid.Text + "'";
            SqlCommand comm = new SqlCommand(query, con);
            comm.ExecuteNonQuery();
            Label8.Text = "Product is Updated Successfully";
            con.Close();
            
            
        }
    }
}