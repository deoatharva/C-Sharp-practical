using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace C__Practical
{
    public partial class Practical1B : System.Web.UI.Page
    {
        TextBox tb;
        Button btn;
        Label resultlb, lb;
        protected void Page_Load(object sender, EventArgs e)
        {
            lb = new Label() { Text = "Enter the number: " };
            tb = new TextBox();
            btn = new Button() { Text = "Submit" };
            resultlb = new Label();


            btn.Click += MakeFloydTriangle;


            form1.Controls.Add(lb);
            form1.Controls.Add(tb);
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(btn);
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(resultlb);
        }
        protected void MakeFloydTriangle(object sender, EventArgs e)
        {
            resultlb.Text = "";
            int n = System.Convert.ToInt32(tb.Text);
            int val = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    resultlb.Text += val + " ";
                    val++;
                }
                resultlb.Text += "<br>";
            }
        }
    }
}