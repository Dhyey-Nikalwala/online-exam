using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineExam
{
    public partial class ResultPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Page lastPage = (Page)Context.Handler;
                Label1.Text = ((Label)lastPage.FindControl("Label2")).Text;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("onlineexam.aspx");
        }
    }
}