using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class Dashboard1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

        }

        protected void btnAddnewUser_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select * from registration where username='" + txtusername.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "insert into registration values('" + txtFirstname.Text + "','" + txtlastname.Text + "','" + txtusername.Text + "','" + txtpassword.Text + "','" + txtemail.Text + "','" + txtcontact.Text + "')";
                cmd1.ExecuteNonQuery();
                txtFirstname.Text = txtlastname.Text = "";
                txtusername.Text = txtpassword.Text = "";
                txtemail.Text = txtpassword.Text = "";
                Label8.Text = "user recored inserted successfully";
            }
            else
            {

                Label8.Text = "This usernamee already registered plz choose another";

                //Response.Redirect("Dashboard.aspx");
            }
        }
    }
}