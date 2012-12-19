using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVælgSpørgeskema_Click(object sender, EventArgs e)
        {
            if (DDSpørgeskema.SelectedItem.Text == "Spørgeskema 1")
            {

                Label1.Text = "Navn: ";
                Label1.Visible = true;
                DropDownList1.Visible = false;
                txt1.Visible = true;
                CheckBoxList1.Visible = false;

                Label2.Text = "Navn: ";
                Label2.Visible = true;
                DropDownList2.Visible = false;
                txt2.Visible = true;
                CheckBoxList2.Visible = false;


                //TextBox myTextBox = new TextBox();
                //myTextBox.Text = "Content here";
                //this.txt1.Controls.Add(myTextBox);
                //myTextBox.Visible = true;
                //myTextBox.


            }
        }
    }
}