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
    public partial class Dashboard : System.Web.UI.Page
    { 
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            display();
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
                display();
                Label8.Text = "user recored inserted successfully";
            }
            else
            {

                Label8.Text = "This usernamee already registered plz choose another";

                //Response.Redirect("Dashboard.aspx");
            }
        }


        public void display()
        {
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select * from registration";
            //cmd.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dt);
            //GridView1.DataSource = dt;
            string query = "Select * FROM registration";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //int Id;
            //Id = Convert.ToInt32(GridView1.ToString());
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "delete from registration where id=" + id_reg + "";
            //cmd.ExecuteNonQuery();
            //display();
        
            string query = "DELETE From Registration WHERE Id_reg ='" + txtid.Text + "'";
            SqlCommand comm = new SqlCommand(query, con);
            comm.ExecuteNonQuery();
            Label8.Text = "user is Deleted Successfully";
            txtid.Text = "";
            con.Close();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
           
            string query = "update Registration Set firstname = '" + txtFirstname.Text + "',lastname = '" + txtlastname.Text + "',username = '" + txtusername.Text + "',password = '" + txtpassword.Text + "',email = '" + txtemail.Text + "',contact = '" + txtcontact.Text + "'WHERE Id_reg = '" + txtid.Text + "'";
            SqlCommand comm = new SqlCommand(query, con);
            comm.ExecuteNonQuery();
            Label8.Text = "user is Updated Successfully";
            txtid.Text = "";
            con.Close();
        }
    }
}