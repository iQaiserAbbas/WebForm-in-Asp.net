using System;

namespace Assignment02
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Application["x"] == null)
            {
                Application["x"] = 1;
            }
            else
            {
                Application["x"] = (int)Application["x"] + 1;
            }
            Response.Write("value of a shared integer " + (int)Application["x"]);
        }
    }
}