using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace C__Practical
{
    public partial class UserControl_4C_ : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ClickMe(object sender, EventArgs e)
        {
            lb.Text = "Button Clicked";
            lb.ForeColor = System.Drawing.Color.Green;
            lb.Font.Bold = true;
        }
    }
}