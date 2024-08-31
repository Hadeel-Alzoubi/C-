using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationTEST
{
    public partial class Info : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string file = Server.MapPath("~/text.txt");

            if (!File.Exists(file))
            {
                using (StreamWriter w = File.CreateText(file))
                {
                    w.WriteLine("This is my FIRST try");
                }
            }
            else
            {
                using (StreamWriter w = File.AppendText(file))
                {
                    w.WriteLine(name.Text);
                    w.WriteLine(Id.Text);
                }
            }
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm.aspx");
        }
    }
}