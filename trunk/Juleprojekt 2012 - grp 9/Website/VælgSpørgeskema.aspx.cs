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
                // Spørgeskema skal have Spørgsmålsnavn, svartype, svarmuligheder
                // Den skal gemme spørgsmålnavn plus svar

                string spørgsmålNavn = "";
                string svarMuligheder;
                short svarType = -1; // -1 er udefineret, 0 er textbox, 1 er ét svar, 2 er flere svar


                int spørgsmålNr = 0;


                //string nuvLabel = "Label" + spørgsmålNr.ToString();
                //Label1.Text = spørgsmålNavn + " ";
                //Label1.Visible = true;


                if (spørgsmålNr == 1)
                {
                    #region Spørgsmål 1
                    Label1.Text = spørgsmålNavn;
                    Label1.Visible = true;

                    if (svarType == 0)
                    {
                        txt1.Visible = true;
                        DropDownList1.Visible = false;
                        CheckBoxList1.Visible = false;
                    }
                    else if (svarType == 1)
                    {
                        txt1.Visible = false;
                        DropDownList1.Visible = true;
                        CheckBoxList1.Visible = false;
                    }
                    else if (svarType == 2)
                    {
                        txt1.Visible = false;
                        DropDownList1.Visible = false;
                        CheckBoxList1.Visible = true;
                    }
                    #endregion
                }
                else if (spørgsmålNr == 2)
                {
                    #region Spørgsmål 2
                    Label2.Text = spørgsmålNavn;
                    Label2.Visible = true;

                    if (svarType == 0)
                    {
                        txt2.Visible = true;
                        DropDownList2.Visible = false;
                        CheckBoxList2.Visible = false;
                    }
                    else if (svarType == 1)
                    {
                        txt2.Visible = false;
                        DropDownList2.Visible = true;
                        CheckBoxList2.Visible = false;
                    }
                    else if (svarType == 2)
                    {
                        txt2.Visible = false;
                        DropDownList2.Visible = false;
                        CheckBoxList2.Visible = true;
                    }
                    #endregion
                }
                else if (spørgsmålNr == 3)
                {
                    #region Spørgsmål 3
                    Label3.Text = spørgsmålNavn;
                    Label3.Visible = true;

                    if (svarType == 0)
                    {
                        txt3.Visible = true;
                        DropDownList3.Visible = false;
                        CheckBoxList3.Visible = false;
                    }
                    else if (svarType == 1)
                    {
                        txt3.Visible = false;
                        DropDownList3.Visible = true;
                        CheckBoxList3.Visible = false;
                    }
                    else if (svarType == 2)
                    {
                        txt3.Visible = false;
                        DropDownList3.Visible = false;
                        CheckBoxList3.Visible = true;
                    }
                    #endregion
                }
                else if (spørgsmålNr == 4)
                {
                    #region Spørgsmål 4
                    Label4.Text = spørgsmålNavn;
                    Label4.Visible = true;

                    if (svarType == 0)
                    {
                        txt4.Visible = true;
                        DropDownList4.Visible = false;
                        CheckBoxList4.Visible = false;
                    }
                    else if (svarType == 1)
                    {
                        txt4.Visible = false;
                        DropDownList4.Visible = true;
                        CheckBoxList4.Visible = false;
                    }
                    else if (svarType == 2)
                    {
                        txt4.Visible = false;
                        DropDownList4.Visible = false;
                        CheckBoxList4.Visible = true;
                    }
                    #endregion
                }
                else if (spørgsmålNr == 5)
                {
                    #region Spørgsmål 5
                    Label5.Text = spørgsmålNavn;
                    Label5.Visible = true;

                    if (svarType == 0)
                    {
                        txt5.Visible = true;
                        DropDownList5.Visible = false;
                        CheckBoxList5.Visible = false;
                    }
                    else if (svarType == 1)
                    {
                        txt5.Visible = false;
                        DropDownList5.Visible = true;
                        CheckBoxList5.Visible = false;
                    }
                    else if (svarType == 2)
                    {
                        txt5.Visible = false;
                        DropDownList5.Visible = false;
                        CheckBoxList5.Visible = true;
                    }
                    #endregion
                }
                else if (spørgsmålNr == 6)
                {
                    #region Spørgsmål 6
                    Label6.Text = spørgsmålNavn;
                    Label6.Visible = true;

                    if (svarType == 0)
                    {
                        txt6.Visible = true;
                        DropDownList6.Visible = false;
                        CheckBoxList6.Visible = false;
                    }
                    else if (svarType == 1)
                    {
                        txt6.Visible = false;
                        DropDownList6.Visible = true;
                        CheckBoxList6.Visible = false;
                    }
                    else if (svarType == 2)
                    {
                        txt6.Visible = false;
                        DropDownList6.Visible = false;
                        CheckBoxList6.Visible = true;
                    }
                    #endregion
                }
                else if (spørgsmålNr == 7)
                {
                    #region Spørgsmål 7
                    Label7.Text = spørgsmålNavn;
                    Label7.Visible = true;

                    if (svarType == 0)
                    {
                        txt7.Visible = true;
                        DropDownList7.Visible = false;
                        CheckBoxList7.Visible = false;
                    }
                    else if (svarType == 1)
                    {
                        txt7.Visible = false;
                        DropDownList7.Visible = true;
                        CheckBoxList7.Visible = false;
                    }
                    else if (svarType == 2)
                    {
                        txt7.Visible = false;
                        DropDownList7.Visible = false;
                        CheckBoxList7.Visible = true;
                    }
                    #endregion
                }
                else if (spørgsmålNr == 8)
                {
                    #region Spørgsmål 8
                    Label8.Text = spørgsmålNavn;
                    Label8.Visible = true;

                    if (svarType == 0)
                    {
                        txt8.Visible = true;
                        DropDownList8.Visible = false;
                        CheckBoxList8.Visible = false;
                    }
                    else if (svarType == 1)
                    {
                        txt8.Visible = false;
                        DropDownList8.Visible = true;
                        CheckBoxList8.Visible = false;
                    }
                    else if (svarType == 2)
                    {
                        txt8.Visible = false;
                        DropDownList8.Visible = false;
                        CheckBoxList8.Visible = true;
                    }
                    #endregion
                }
                else if (spørgsmålNr == 9)
                {
                    #region Spørgsmål 9
                    Label9.Text = spørgsmålNavn;
                    Label9.Visible = true;

                    if (svarType == 0)
                    {
                        txt9.Visible = true;
                        DropDownList9.Visible = false;
                        CheckBoxList9.Visible = false;
                    }
                    else if (svarType == 1)
                    {
                        txt9.Visible = false;
                        DropDownList9.Visible = true;
                        CheckBoxList9.Visible = false;
                    }
                    else if (svarType == 2)
                    {
                        txt9.Visible = false;
                        DropDownList9.Visible = false;
                        CheckBoxList9.Visible = true;
                    }
                    #endregion
                }
                else if (spørgsmålNr == 10)
                {
                    #region Spørgsmål 10
                    Label10.Text = spørgsmålNavn;
                    Label10.Visible = true;

                    if (svarType == 0)
                    {
                        txt10.Visible = true;
                        DropDownList10.Visible = false;
                        CheckBoxList10.Visible = false;
                    }
                    else if (svarType == 1)
                    {
                        txt1.Visible = false;
                        DropDownList10.Visible = true;
                        CheckBoxList10.Visible = false;
                    }
                    else if (svarType == 2)
                    {
                        txt1.Visible = false;
                        DropDownList10.Visible = false;
                        CheckBoxList10.Visible = true;
                    }
                    #endregion
                }












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