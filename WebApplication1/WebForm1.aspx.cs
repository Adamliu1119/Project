using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static int c = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            c++;
            if (c < 3)
                Label1.Text = c.ToString();
            else
            {
                Button1.Text = "X";
                Timer1.Enabled = false;
            }
        }
    }
}