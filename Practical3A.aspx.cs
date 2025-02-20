using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace C__Practical
{
    public partial class Practical3A : System.Web.UI.Page
    {
        Label output;
        Label text, sizelb, fontStyle, fontColor;
        TextBox textbox, sizetb;
        CheckBoxList checkBoxs;
        RadioButtonList radioButtons;
        ListItem item;
        protected void Page_Load(object sender, EventArgs e)
        {
            output = new Label() { Text = "{OUTPUT TEXT}" };
            fontStyle = new Label() { Text = "Font Style" };
            fontColor = new Label() { Text = "Font Color" };
            text = new Label() { Text = "Enter Text &nbsp;" };
            textbox = new TextBox() { AutoPostBack = true };
            textbox.TextChanged += Textbox_TextChanged;
            sizelb = new Label() { Text = "Enter Size &nbsp;" };
            sizetb = new TextBox() { AutoPostBack = true };
            sizetb.TextChanged += Sizetb_TextChanged;
            checkBoxs = new CheckBoxList() { AutoPostBack = true, RepeatDirection = RepeatDirection.Horizontal };
            checkBoxs.SelectedIndexChanged += CheckBoxs_SelectedIndexChanged;


            item = new ListItem("Bold");
            checkBoxs.Items.Add(item);

            item = new ListItem("Italic");
            checkBoxs.Items.Add(item);

            item = new ListItem("Underline");
            checkBoxs.Items.Add(item);

            radioButtons = new RadioButtonList() { AutoPostBack = true, RepeatDirection = RepeatDirection.Horizontal};
            radioButtons.SelectedIndexChanged += RadioButtons_SelectedIndexChanged;

            item = new ListItem("Red");
            radioButtons.Items.Add(item);

            item = new ListItem("Green");
            radioButtons.Items.Add(item);

            item = new ListItem("Blue");
            radioButtons.Items.Add(item);
            
            form1.Controls.Add(output);
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(text);
            form1.Controls.Add(textbox);
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(sizelb);
            form1.Controls.Add(sizetb);
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(fontStyle);
            form1.Controls.Add(checkBoxs);
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(fontColor);
            form1.Controls.Add(radioButtons);
        }

        private void Sizetb_TextChanged(object sender, EventArgs e)
        {
            output.Font.Size = int.Parse(sizetb.Text);
        }

        private void RadioButtons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(radioButtons.SelectedIndex == 0)
            {
                output.BackColor = System.Drawing.Color.Red;
            }
            if(radioButtons.SelectedIndex == 1)
            {
                output.BackColor= System.Drawing.Color.Green;
            }
            if (radioButtons.SelectedIndex == 2)
            {
                output.BackColor = System.Drawing.Color.Blue;
            }
        }

        private void CheckBoxs_SelectedIndexChanged(object sender, EventArgs e)
        {
            output.Font.Bold = false;
            output.Font.Italic = false;
            output.Font.Underline = false;

            foreach (ListItem item in checkBoxs.Items)
            {
                if (item.Selected)
                {
                    if (item.Text == "Bold")
                    {
                        output.Font.Bold = true;
                    }
                    else if (item.Text == "Italic")
                    {
                        output.Font.Italic = true;
                    }
                    else if (item.Text == "Underline")
                    {
                        output.Font.Underline = true;
                    }
                }
            }
        }

        private void Textbox_TextChanged(object sender, EventArgs e)
        {
            output.Text = textbox.Text;
        }
    }
}