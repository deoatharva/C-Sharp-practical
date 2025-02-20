using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace C__Practical
{
    public partial class Practical4A : System.Web.UI.Page
    {
        Label namelb, emaillb, passwordlb, repasswordlb, result;
        TextBox nametb, emailtb, passwordtb, repasswordtb;
        Button submit;
        RequiredFieldValidator isNameEmpty, isEmailEmpty, isPasswordEmpty, isRePasswordEmpty;
        CompareValidator isPasswordValid;
        RegularExpressionValidator isEmailValid;
        protected void Page_Load(object sender, EventArgs e)
        {
            submit = new Button() { Text = "Submit" };
            submit.Click += CheckValidation;

            namelb = new Label() { Text = "Name: " };
            emaillb = new Label() { Text = "Email: " };
            passwordlb = new Label() { Text = "Password: " };
            repasswordlb = new Label() { Text = "Confirm Password: " };
            result = new Label();

            nametb = new TextBox() { ID = "Name" };
            isNameEmpty = new RequiredFieldValidator()
            {
                ControlToValidate = nametb.ID,
                ErrorMessage = "Name is required",
                ForeColor = System.Drawing.Color.Red
            };

            emailtb = new TextBox() { ID = "Email" };
            isEmailEmpty = new RequiredFieldValidator()
            {
                ControlToValidate = emailtb.ID,
                ErrorMessage = "Email is required",
                ForeColor = System.Drawing.Color.Red
            };

            isEmailValid = new RegularExpressionValidator()
            {
                ControlToValidate =emailtb.ID,
                ErrorMessage = "Enter proper email",
                ValidationExpression = @"[\w\.-]+@[a-zA-Z\d-]+\.[a-zA-Z]{2,6}",
                ForeColor = System.Drawing.Color.Red
            };

            passwordtb = new TextBox() { ID = "Password", TextMode = TextBoxMode.Password };
            isPasswordEmpty = new RequiredFieldValidator()
            {
                ControlToValidate = passwordtb.ID,
                ErrorMessage = "Password is required",
                ForeColor = System.Drawing.Color.Red
            };

            repasswordtb = new TextBox() { ID = "RePassword", TextMode = TextBoxMode.Password };
            isRePasswordEmpty = new RequiredFieldValidator()
            {
                ControlToValidate = repasswordtb.ID,
                ErrorMessage = "Confirm Password is required",
                ForeColor = System.Drawing.Color.Red
            };

            isPasswordValid = new CompareValidator()
            {
                ControlToCompare = passwordtb.ID,
                ControlToValidate = repasswordtb.ID,
                ErrorMessage = "Password Should Match",
                Operator = ValidationCompareOperator.Equal,
                Type = ValidationDataType.String,
                ForeColor = System.Drawing.Color.Red
            };

            form1.Controls.Add(namelb);
            form1.Controls.Add(nametb);
            form1.Controls.Add(isNameEmpty);
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(emaillb);
            form1.Controls.Add(emailtb);
            form1.Controls.Add(isEmailEmpty);
            form1.Controls.Add(isEmailValid);
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(passwordlb);
            form1.Controls.Add(passwordtb);
            form1.Controls.Add(isPasswordEmpty);
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(repasswordlb);
            form1.Controls.Add(repasswordtb);
            form1.Controls.Add(isRePasswordEmpty);
            form1.Controls.Add(isPasswordValid);
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(submit);
            form1.Controls.Add(result);
        }

        private void CheckValidation(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                result.Text = "Thank You!";
            }
        }
    }
}