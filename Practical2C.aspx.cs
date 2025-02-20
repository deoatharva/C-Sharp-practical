using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace C__Practical
{
    public partial class Practical2C : System.Web.UI.Page
    {
        interface Area
        {
            double show(double s);
        }
        class Circle : Area
        {
            public double show(double s)
            {
                return (3.14 * s * s);
            }
        }

        Label input, circle;
        TextBox textBox1;
        Button result;
        protected void Page_Load(object sender, EventArgs e)
        {
            input = new Label() { Text = "Enter Value: " };
            circle = new Label();
            textBox1 = new TextBox();
            result = new Button() { Text = "Submit" };
            result.Click += Result_Click;

            form1.Controls.Add(input);
            form1.Controls.Add(textBox1);
            form1.Controls.Add(new LiteralControl("<br /><br />"));
            form1.Controls.Add(result);
            form1.Controls.Add(new LiteralControl("<br /><br />"));
            form1.Controls.Add(circle);
        }

        private void Result_Click(object sender, EventArgs e)
        {
            double n = double.Parse(textBox1.Text);
            Circle c1 = new Circle();
            double y = c1.show(n);

            circle.Text = "Area of Rect: " + y;
        }
    }
}