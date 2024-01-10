using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace SampleAssessment
{
    public partial class ReadData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }


      
        protected void lnkDelete_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            Session["id"] = btn.CommandArgument;

            string constr = ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                string query = "Delete FROM moviedetails WHERE Movie_Id = @Movie_Id";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Movie_Id", Session["id"]);
                    cmd.ExecuteNonQuery();
                }
            }
            BindData();
        }
        protected void lnkUpdate_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            Session["id"] = btn.CommandArgument;
            Response.Redirect("/UpdateData.aspx");
           
        }
        protected void BindData()
        {
            string constr = ConfigurationManager.ConnectionStrings["DBconnection"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM moviedetails"))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView2.DataSource = dt;
                            GridView2.DataBind();

                        }
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/GetData.aspx");
        }
    }
}