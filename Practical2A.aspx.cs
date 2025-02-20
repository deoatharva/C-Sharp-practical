using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace C__Practical
{
    public partial class Practical2A : System.Web.UI.Page
    {
        Label boxResult, unboxResult, input;
        TextBox textBox;
        Button Box_Unbox;
        protected void Page_Load(object sender, EventArgs e)
        {
            boxResult = new Label() { Text = "BOX VALUE: " };
            unboxResult = new Label() { Text = "UNBOX VALUE: " };
            input = new Label() { Text = "Enter Value &nbsp;" };
            textBox = new TextBox();
            Box_Unbox = new Button() { Text = "Box & Unbox" };

            Box_Unbox.Click += Box_Unbox_Click;

            form1.Controls.Add(input);
            form1.Controls.Add(textBox);
            form1.Controls.Add(new LiteralControl("<br /><br />"));
            form1.Controls.Add(Box_Unbox);
            form1.Controls.Add(new LiteralControl("<br /><br />"));
            form1.Controls.Add(boxResult);
            form1.Controls.Add(new LiteralControl("<br /><br />"));
            form1.Controls.Add(unboxResult);
        }

        private void Box_Unbox_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBox.Text);

            object box = value;
            boxResult.Text = "BOX VALUE: " + value;

            int unbox = (int)box;
            unboxResult.Text = "UNBOX VALUE: " + unbox;
        }
    }
}