using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace C__Practical
{
    public partial class Practical1A : System.Web.UI.Page
    {
        Label lb1, lb2, add, sub, mul, div;
        TextBox tb1, tb2;
        Button btn;

        protected void Page_Load(object sender, EventArgs e)
        {
            lb1 = new Label() { Text = "Number 1"};
            lb2 = new Label() { Text = "Number 2" };
            add = new Label();
            sub = new Label();
            mul = new Label();
            div = new Label();

            tb1 = new TextBox();
            tb2 = new TextBox();

            btn = new Button() { Text = "Submit" };
            btn.Click += showResult;

            form1.Controls.Add(lb1);
            form1.Controls.Add(tb1);
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(lb2);
            form1.Controls.Add(tb2);
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(btn);
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(add);
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(sub);
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(mul);
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(div);
        }

        private void showResult(object sender, EventArgs e)
        {
            int a = int.Parse(tb1.Text);
            int b = int.Parse(tb2.Text);

            add.Text = "Addition: " + (a+b);
            sub.Text = "Subtraction: " + (a-b);
            mul.Text = "Multiplication: " + (a*b);
            div.Text = "Division: " + (a/b);
        }
    }
}