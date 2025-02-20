using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace C__Practical
{
    public partial class Practical4B : System.Web.UI.Page
    {
        AdRotator adRotator;
        protected void Page_Load(object sender, EventArgs e)
        {
            adRotator = new AdRotator() { AdvertisementFile = "~/AdRotator(4B).xml", Target = "_blank" };

            form1.Controls.Add(adRotator);
        }
    }
}