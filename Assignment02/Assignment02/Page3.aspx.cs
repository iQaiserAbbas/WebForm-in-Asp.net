using System;
using System.Web;

namespace Assignment02
{
    public partial class Page3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Seconds"] == null)
            {
                HttpCookie cookie = new HttpCookie("ExpirationCookie");
                cookie.Expires = DateTime.Now.AddSeconds(5);

                Response.Cookies.Add(cookie);
                Session["Seconds"] = Response.Cookies["ExpirationCookie"].Expires.Second;
            }

            int TimeLeft = (int)(Session["Seconds"]) - DateTime.Now.Second;
            if (TimeLeft > 0)
            {
                Response.Write("This Page is expiring after " + TimeLeft + " Seconds");
            }
            else
            {
                Response.Write("page expired");
            }
        }
    }
}