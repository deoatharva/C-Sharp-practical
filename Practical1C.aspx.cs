using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace C__Practical
{
    public partial class Practical1C : System.Web.UI.Page
    {
        Label lb, fiboResult, primeResult;
        TextBox tb;
        Button fiboBtn, primeBtn;
        protected void Page_Load(object sender, EventArgs e)
        {
            lb = new Label() { Text = "Enter the number: " };
            fiboResult = new Label();
            primeResult = new Label();
            tb = new TextBox();
            fiboBtn = new Button() { Text = "Fibonacci" };
            primeBtn = new Button() { Text = "Prime" };

            fiboBtn.Click += FiboSeries;
            primeBtn.Click += CheckPrime;

            form1.Controls.Add(lb);
            form1.Controls.Add(tb);
            form1.Controls.Add(new LiteralControl("<br /><br />"));
            form1.Controls.Add(fiboBtn);
            form1.Controls.Add(new LiteralControl("<br /><br />"));
            form1.Controls.Add(fiboResult);
            form1.Controls.Add(new LiteralControl("<br /><br />"));
            form1.Controls.Add(primeBtn);
            form1.Controls.Add(new LiteralControl("<br /><br />"));
            form1.Controls.Add(primeResult);

        }

        private void CheckPrime(object sender, EventArgs e)
        {
            int n, i, s = 0;
            n = int.Parse(tb.Text);
            if (n == 0 || n == 1)
                s = 1;
            for (i = 2; i <= n / 2; ++i)
            {
                if (n % i == 0)
                {
                    s = 1;
                    break;
                }
            }
            if (s == 0)
            {
                primeResult.Text = "The given number is prime"; 
            }
            else
            {
                primeResult.Text = "The given number is not prime";
            }
        }

        private void FiboSeries(object sender, EventArgs e)
        {
            int a, b, c, i, n;
            a = 0;
            b = 1;
            fiboResult.Text = a + " " + b;
            n = int.Parse(tb.Text);
            for (i = 1; i <= n; ++i)
            {
                c = a + b;
                fiboResult.Text += " " + c;
                a = b;
                b = c;
            }
        }
    }
}