﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (pencilRadioButton.Checked)
            {
                resultLabel.Text = "You selected Pencil";
                resultImage.ImageUrl = "../pencil.png";
            }


            else if (penRadioButton.Checked)
            {
                resultLabel.Text = "You selected Pen";
                resultImage.ImageUrl = "../pen.png";

            }

            else if (phoneRadioButton.Checked)
            {
                resultLabel.Text = "You selected Phone";
                resultImage.ImageUrl = "../phone.png";

            }

            else if (tabletRadioButton.Checked)
            {
                resultLabel.Text = "You selected Tablet";
                resultImage.ImageUrl = "../tablet.png";

            }
        }
    }
}