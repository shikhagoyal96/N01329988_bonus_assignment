﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace N01329988_BonusAssignment
{
    public partial class part_1_coordinate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack)
            {
                Page.Validate();

                if(Page.IsValid)
                {
                    int xcoordinate = Convert.ToInt32(x.Text);
                    int ycoordinate = Convert.ToInt32(y.Text);

                    confirmation.InnerHtml += "Result is.." + "<br>";
                    if (xcoordinate > 0)
                    {
                        if (ycoordinate > 0)
                        {
                            confirmation.InnerHtml = "(" + xcoordinate + "," + ycoordinate + ") falls in quadrant 1." + "<br>";//printing quadrant 1 
                        }
                        else
                        {
                            confirmation.InnerHtml = "(" + xcoordinate + "," + ycoordinate + ") falls in quadrant 4." + "<br>";//printing quadrant 4
                        }
                    }
                    else
                    {
                        if (ycoordinate > 0)
                        {
                            confirmation.InnerHtml = "(" + xcoordinate + "," + ycoordinate + ") falls in quadrant 2." + "<br>";//printing quadrant 2
                        }
                        else
                        {
                            confirmation.InnerHtml = "(" + xcoordinate + "," + ycoordinate + ") falls in quadrant 3." + "<br>";//printing quadrant 3
                        }
                    }
                }
            }
        }
    }
}