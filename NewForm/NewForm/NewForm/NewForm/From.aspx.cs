using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewForm
{
    public partial class From : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    string selectedValue = RadioButtonList1.SelectedValue;
        //    Label1.Text = "You selected: " + selectedValue;
        //}

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Page2.aspx");
        }

    }
}