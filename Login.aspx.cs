using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleAssessment
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(constr))
            {

                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from userdetails where useremail = @email and password = @password", conn);

                cmd.Parameters.AddWithValue("@email", TextBox1.Text);
                cmd.Parameters.AddWithValue("@password", TextBox2.Text);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {

                   
                    Response.Redirect("Home.aspx");

                }

                else

                {
                    MySqlCommand cmd1 = new MySqlCommand("select * from userdetails where useremail = @email", conn);

                    cmd1.Parameters.AddWithValue("@email", TextBox1.Text);
                   

                    MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    if (dt.Rows.Count == 1)
                    {


                        Label1.Text = "Please ensure that entered password is correct";

                    }
                    else
                    {
                        Label1.Text = "Please ensure that entered email and password is correct";

                    }
                }
            }
        }
    }
}