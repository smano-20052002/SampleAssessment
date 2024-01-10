using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleAssessment
{
    public partial class UpdateData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
                    string constr = ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString;
                    using (MySqlConnection con = new MySqlConnection(constr))
                    {
                        con.Open();
                    using (MySqlCommand cmd = new MySqlCommand($"SELECT * FROM moviedetails where Movie_Id={Session["id"]}"))
                    {
                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            // Create a DataSet to store the query results
                            DataSet ds = new DataSet();
                            // Fill the DataSet with the data from the adapter
                            sda.Fill(ds);
                            // Assign the value of the first column of the first row to the textbox
                            TextBox1.Text = ds.Tables[0].Rows[0][0].ToString();
                            TextBox2.Text = ds.Tables[0].Rows[0][1].ToString();
                            TextBox3.Text = ds.Tables[0].Rows[0][2].ToString();
                            TextBox4.Text = ds.Tables[0].Rows[0][3].ToString();
                            TextBox5.Text = ds.Tables[0].Rows[0][4].ToString();
                        }
                    }

                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                string str = "UPDATE moviedetails SET Movie_Id=@Movie_Id1, Movie_Name=@Movie_Name,Movie_Type=@Movie_Type, " +
                         "Movie_Language=@Movie_Language,Movie_Durations=@Movie_Durations " +
                         "WHERE Movie_Id=@Movie_Id";
                using (MySqlCommand cmd = new MySqlCommand(str, con))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter())
                    {
                        cmd.Parameters.AddWithValue("@Movie_Id1", TextBox1.Text);
                        cmd.Parameters.AddWithValue("@Movie_Name", TextBox2.Text);
                        cmd.Parameters.AddWithValue("@Movie_Type", TextBox3.Text);
                        cmd.Parameters.AddWithValue("@Movie_Language", TextBox4.Text);
                        cmd.Parameters.AddWithValue("@Movie_Durations", TextBox5.Text);
                        cmd.Parameters.AddWithValue("@Movie_Id", Session["id"]);
                        if (cmd.ExecuteNonQuery()>0)
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
}