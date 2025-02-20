using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace C__Practical
{
    public partial class Practical4C : System.Web.UI.Page
    {
        PlaceHolder PlaceHolder;
        protected void Page_Load(object sender, EventArgs e)
        {
            var userControl = Page.LoadControl("~/UserControl(4C).ascx");

            PlaceHolder = new PlaceHolder();
            PlaceHolder.Controls.Add(userControl);

            form1.Controls.Add(PlaceHolder);
        }
    }
}