using System;

namespace Assignment02
{
    public partial class Page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["x"] == null)
            {
                Session["x"] = 1;
            }
            else
            {
                Session["x"] = (int)Session["x"] + 1;
            }
            Response.Write("value of a shared integer " + (int)Session["x"]);
        }
    }
}