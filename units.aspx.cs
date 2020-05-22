using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class units : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Inventory;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * FROM dbo.unit";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into dbo.unit values('" + txtunit.Text + "')";
            cmd.ExecuteNonQuery();
            Label2.Text = "Units Added Successfully";
           
            txtunit.Text = "";
            con.Close();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            display();
        }
        public void display()
        {
            con.Open();
            string query = "Select * FROM registration";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            con.Close();
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            con.Open();
            string query = "Select * FROM registration";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE From unit WHERE Id_unit ='" + txtid.Text + "'";
            SqlCommand comm = new SqlCommand(query, con);
            comm.ExecuteNonQuery();
            Label2.Text = "Units is Deleted Successfully";
            txtunit.Text = "";
            con.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update unit Set id_unit = '" + txtid.Text + "',unit = '" + txtunit.Text + "'WHERE id_unit = '" + 1 + "'";
            SqlCommand comm = new SqlCommand(query, con);
            comm.ExecuteNonQuery();
            Label2.Text = "unit is Updated Successfully";
            con.Close();
        }
    }
}