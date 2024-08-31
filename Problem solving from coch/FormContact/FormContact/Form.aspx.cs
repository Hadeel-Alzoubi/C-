using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormContact
{
    public partial class Form : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Contact.aspx");
        }

        //protected void Submit(object sender, EventArgs e)
        //{
        //    //Submit(sender, e);
        //    Response.Redirect("Page2.aspx");
        //}
    }
}