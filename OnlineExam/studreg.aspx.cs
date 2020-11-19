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
    public partial class WebForm2 : System.Web.UI.Page
    {
        MySqlConnection connection;
        string server;
        string database;
        string uid;
        string password;
      
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
            MySqlCommand cmd = new MySqlCommand("insert into student values (null,@p1,@p2,@p3,@p4) ", connection);
            cmd.Parameters.AddWithValue("@p1", TextBox1.Text);
            cmd.Parameters.AddWithValue("@p2", TextBox2.Text);
            cmd.Parameters.AddWithValue("@p3", TextBox3.Text);
            cmd.Parameters.AddWithValue("@p4", DropDownList1.SelectedItem.Value);
            cmd.ExecuteNonQuery();

            //Response.Write("registered");
            Response.Redirect("onlineexam.aspx");
           




        }
    }
}