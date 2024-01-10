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
    public partial class GetData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                string str = "insert into moviedetails (Movie_Name,Movie_Type,Movie_Language,Movie_Durations ) values(@Movie_Name,@Movie_Type,@Movie_Language,@Movie_Durations )";
                using (MySqlCommand cmd = new MySqlCommand(str, con))
                {
                   
                        //cmd.Parameters.AddWithValue("@Movie_Id1", TextBox1.Text);
                        cmd.Parameters.AddWithValue("@Movie_Name", TextBox2.Text);
                        cmd.Parameters.AddWithValue("@Movie_Type", TextBox3.Text);
                        cmd.Parameters.AddWithValue("@Movie_Language", TextBox4.Text);
                        cmd.Parameters.AddWithValue("@Movie_Durations", TextBox5.Text);
                        //cmd.Parameters.AddWithValue("@Movie_Id", Session["id"]);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            con.Close();
                            Response.Redirect("/ReadData.aspx");
                        }
                        else
                        {
                            Label1.Text = "Current the server is not available Please retry it";
                        }
                    

                }

            }
        }
    }
}