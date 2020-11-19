using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace OnlineExam
{

    public partial class onlineexam : System.Web.UI.Page
    {

        MySqlConnection connection;
        string server;
        string database;
        string uid;
        string password;
        
        ////MySqlConnection cn = new MySqlConnection("server=localhost;user id=root;database=college;persistsecurityinfo=True");
        MySqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            server = "localhost";
            database = "college";
            uid = "root";
            password = "root";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
            connection.Open();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("select * from student where email = @p1 and password = @p2", connection);
            cmd.Parameters.AddWithValue("@p1", TextBox1.Text);
            cmd.Parameters.AddWithValue("@p2", TextBox2.Text);
            dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                dr.Read();
                Session["user"] = dr[1].ToString();
                Session["id"] = dr[0].ToString();
                dr.Close();
                Response.Redirect("test.aspx");
            }
            else
            {
              //  Response.Write("invalid credentials");
                Response.Redirect("onlineexam.aspx");
        
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("studreg.aspx");
        }

        protected void ImageMap1_Click(object sender, ImageMapEventArgs e)
        {

        }
    }
}