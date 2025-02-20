using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace C__Practical
{
    public partial class Practical3B : System.Web.UI.Page
    {
        Label resultLabel;
        Calendar calendar;
        protected void Page_Load(object sender, EventArgs e)
        {
            calendar = new Calendar();
            calendar.SelectionChanged += Calendar_SelectionChanged;
            calendar.DayRender += Calendar_DayRender;

            resultLabel = new Label();
            resultLabel.Text = "Please select a date.";
            resultLabel.Font.Size = 14;
            resultLabel.ForeColor = System.Drawing.Color.Blue;

            form1.Controls.Add(calendar);
            form1.Controls.Add(new LiteralControl("<br/>"));
            form1.Controls.Add(resultLabel);
        }

        private void Calendar_SelectionChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = calendar.SelectedDate;

            if (selectedDate.Month == 10 && selectedDate.Day == 2)
            {
                resultLabel.Text = "You selected: " + selectedDate.ToShortDateString() + " - Gandhi Jayanti (Holiday)";
                resultLabel.ForeColor = System.Drawing.Color.Red;
            }
            else if (selectedDate.Month == 10 && selectedDate.Day == 31)
            {
                resultLabel.Text = "You selected: " + selectedDate.ToShortDateString() + " - Diwali (Holiday)";
                resultLabel.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                resultLabel.Text = "You selected: " + selectedDate.ToShortDateString();
                resultLabel.ForeColor = System.Drawing.Color.Blue;
            }
        }

        protected void Calendar_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.Date.Month == 10 && e.Day.Date.Day == 2)
            {
                e.Cell.BackColor = System.Drawing.Color.Yellow;
                e.Cell.ToolTip = "Gandhi Jayanti";
            }
            if (e.Day.Date.Month == 10 && e.Day.Date.Day == 31)
            {
                e.Cell.BackColor = System.Drawing.Color.Yellow;
                e.Cell.ToolTip = "Diwali";
            }
        }
    }
}