using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleAssessment
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(constr))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("insert into userdetails (useremail ,username , password) values(@useremail,@username,@password);", conn);
                    cmd.Parameters.AddWithValue("@username", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@useremail", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@password", TextBox2.Text);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        Response.Redirect("Home.aspx");
                    }
                    else
                    {
                        Label1.Text = "Please try with another email and username";
                    }

                }
            }
            catch (Exception ex)
            {
                Label1.Text = "Please try with another email and username";
            }
        }
    }
}