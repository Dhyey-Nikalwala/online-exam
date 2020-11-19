using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;


namespace OnlineExam
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        MySqlConnection connection;
        string server;
        string database;
        string uid;
        string password;

        int count = 0;
  
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
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
                if (Session.Count > 0)
                {
                    Label1.Text = Session["user"].ToString();
                }
                else
                {
                    Response.Redirect("onlineexam.aspx");
                }
                MySqlCommand cmd = new MySqlCommand("select * from question ", connection);
                MySqlDataAdapter sdr = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sdr.Fill(dt);
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
                          
            }
           
        }
        int flag = 0;
        

        protected void Button1_Click(object sender, EventArgs e)
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
            flag = 1;

            if(flag==1)
            {
                Button1.Enabled = false;
            }

            
            foreach(RepeaterItem ri in Repeater1.Items)
            {
                RadioButton rb1 = (RadioButton)ri.FindControl("RadioButton1");
                Label labcorrect = (Label)ri.FindControl("labcorrected");
                labcorrect.Visible = true;
                if(rb1.Checked == true)
                {
                    if(rb1.Text.Equals(labcorrect.Text))
                    {
                        count++;
                        Label userselected = (Label)ri.FindControl("userselectedans");
                        userselected.Text = "The Selected Answer is <b>" + rb1.Text.ToString() + "</b>";
                        userselected.ForeColor = System.Drawing.Color.Green;
                        

                    }
                    else
                    {
                        Label wronganswer = (Label)ri.FindControl("userselectedans");
                        wronganswer.Text = "The Selected Answer <b>" + rb1.Text.ToString() + "</b> Is Wrong!";
                        wronganswer.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }


            foreach (RepeaterItem ri in Repeater1.Items)
            {
                RadioButton rb2 = (RadioButton)ri.FindControl("RadioButton2");
                Label labcorrect = (Label)ri.FindControl("labcorrected");
                labcorrect.Visible = true;
                if (rb2.Checked == true)
                {
                    if (rb2.Text.Equals(labcorrect.Text))
                    {
                        count++;
                        Label userselected = (Label)ri.FindControl("userselectedans");
                        userselected.Text = "The Selected Answer is <b>" + rb2.Text.ToString() + "</b>";
                        userselected.ForeColor = System.Drawing.Color.Green;

                    }
                    else
                    {
                        Label wronganswer = (Label)ri.FindControl("userselectedans");
                        wronganswer.Text = "The Selected Answer <b>" + rb2.Text.ToString() + "</b> Is Wrong!";
                        wronganswer.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }


            foreach (RepeaterItem ri in Repeater1.Items)
            {
                RadioButton rb3 = (RadioButton)ri.FindControl("RadioButton3");
                Label labcorrect = (Label)ri.FindControl("labcorrected");
                labcorrect.Visible = true;
                if (rb3.Checked == true)
                {
                    if (rb3.Text.Equals(labcorrect.Text))
                    {
                        count++;
                        Label userselected = (Label)ri.FindControl("userselectedans");
                        userselected.Text = "The Selected Answer is <b>" + rb3.Text.ToString() + "</b>";
                        userselected.ForeColor = System.Drawing.Color.Green;

                    }
                    else
                    {
                        Label wronganswer = (Label)ri.FindControl("userselectedans");
                        wronganswer.Text = "The Selected Answer <b>" + rb3.Text.ToString() + "</b> Is Wrong!";
                        wronganswer.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }




            foreach (RepeaterItem ri in Repeater1.Items)
            {
                RadioButton rb4 = (RadioButton)ri.FindControl("RadioButton4");
                Label labcorrect = (Label)ri.FindControl("labcorrected");
                labcorrect.Visible = true;
                if (rb4.Checked == true)
                {
                    if (rb4.Text.Equals(labcorrect.Text))
                    {
                        count++;
                        Label userselected = (Label)ri.FindControl("userselectedans");
                        userselected.Text = "The Selected Answer is <b>" + rb4.Text.ToString() + "</b>";
                        userselected.ForeColor = System.Drawing.Color.Green;

                    }
                    else
                    {
                        Label wronganswer = (Label)ri.FindControl("userselectedans");
                        wronganswer.Text = "The Selected Answer <b>" + rb4.Text.ToString() + "</b> Is Wrong!";
                        wronganswer.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }

           
            //connection.Open();
            MySqlCommand cmd = new MySqlCommand("insert into student_result values (null,@p1,@p2) ", connection);
            String id = Session["id"].ToString();
            cmd.Parameters.AddWithValue("@p1", id);
            cmd.Parameters.AddWithValue("@p2", count);
            cmd.ExecuteNonQuery();
            Label2.Text = " Your marks is: " + count.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("onlineexam.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Button1_Click(null, null);
            
           Server.Transfer("ResultPage.aspx");
           //Response.Redirect("ResultPage.aspx ? marks="+count);
        }
    }
}