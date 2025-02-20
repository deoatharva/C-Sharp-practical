using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace C__Practical
{
    public partial class Practical2B : System.Web.UI.Page
    {
        public delegate int MathOperation(int a,int b);

        Label label1, label2, addlb, sublb;
        TextBox textBox1, textBox2;
        Button result;
        protected void Page_Load(object sender, EventArgs e)
        {
            label1 = new Label() { Text = "Enter Number 1 " };
            label2 = new Label() { Text = "Enter Number 2 " };
            addlb = new Label() { Text = "Addition: " };
            sublb = new Label() { Text = "Subtraction: " };
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            result = new Button() { Text = "Submit" };

            result.Click += Result_Click;

            form1.Controls.Add(label1);
            form1.Controls.Add(textBox1);
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(label2);
            form1.Controls.Add(textBox2);
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(result);
            form1.Controls.Add(new LiteralControl("<br /> <br />"));
            form1.Controls.Add(addlb);
            form1.Controls.Add(new LiteralControl("<br /><br />"));
            form1.Controls.Add(sublb);
        }

        int Add(int a,int b)
        { 
            return a + b; 
        }
        int Sub(int a,int b)
        {
            return a - b;
        }

        private void Result_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            MathOperation add = new MathOperation(Add);
            MathOperation sub = new MathOperation(Sub);

            addlb.Text = "Addition: " + add(a, b).ToString();
            sublb.Text = "Subtraction: " + sub(a, b).ToString();

        }
    }
}