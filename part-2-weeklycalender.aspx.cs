using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace N01329988_BonusAssignment
{
    public partial class part_2_weeklycalender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();

                if (Page.IsValid)
                {
                    foreach (ListItem weekday in weekdays.Items)
                    {
                        if (weekday.Selected == true)//for checking whether the checkboxes are selected
                        {
                            for (int i = 1; i <= 31; )//loop running for the month of october days 1-31
                            {
                                if(i!=32)//runs the loop if the number of days doesn't exceed 31
                                {
                                    if (weekday.Value == "tuesday")//checking whether the selected value is tuesday
                                    {
                                        confirmation.InnerHtml += "Oct " + i++ + " is a Tuesday!Time to work<br>";//printing if tuesday is the working day
                                    }
                                    else
                                    {
                                        confirmation.InnerHtml += "Oct " + i++ + " is a Tuesday!Time to have fun<br>";//printing if tuesday is not the working day
                                    }
                                }
                                if (i != 32)
                                {
                                    if (weekday.Value == "wednesday")//checking whether the selected value is wednesday
                                    {
                                        confirmation.InnerHtml += "Oct " + i++ + " is a Wednesday!Time to work<br>";//printing if wednesday is the working day
                                    }
                                    else
                                    {
                                        confirmation.InnerHtml += "Oct " + i++ + " is a Wednesday!Time to have fun<br>";//printing if wednesday is not the working day
                                    }
                                }
                                if (i != 32)
                                {
                                    if (weekday.Value == "thursday")//checking whether the selected value is thursday
                                    {
                                        confirmation.InnerHtml += "Oct " + i++ + " is a Thursday!Time to work<br>";//printing if thursday is the working day
                                    }
                                    else
                                    {
                                        confirmation.InnerHtml += "Oct " + i++ + " is a Thursday!Time to have fun<br>";//printing if thursday is not the working day
                                    }
                                }
                                if (i != 32)
                                {
                                    if (weekday.Value == "friday")//checking whether the selected value is friday
                                    {
                                        confirmation.InnerHtml += "Oct " + i++ + " is a Friday!Time to work<br>";//printing if friday is the working day
                                    }
                                    else
                                    {
                                        confirmation.InnerHtml += "Oct " + i++ + " is a Friday!Time to have fun<br>";//printing if friday is not the working day
                                    }
                                }
                                if (i != 32)
                                {
                                    if (weekday.Value == "saturday")//checking whether the selected value is saturday
                                    {
                                        confirmation.InnerHtml += "Oct " + i++ + " is a Saturday!Time to work<br>";//printing if saturday is the working day
                                    }
                                    else
                                    {
                                        confirmation.InnerHtml += "Oct " + i++ + " is a Saturday!Time to have fun<br>";//printing if saturday is not the working day
                                    }
                                }
                                if (i != 32)
                                { 
                                     if (weekday.Value == "sunday")//checking whether the selected value is sunday
                                    {
                                          confirmation.InnerHtml += "Oct " + i++ + " is a Sunday!Time to work<br>";//printing if sunday is the working day
                                    }
                                     else
                                     {
                                         confirmation.InnerHtml += "Oct " + i++ + " is a Sunday!Time to have fun<br>";//printing if sunday is not the working day
                                    }
                                }
                                if (i != 32)
                                {
                                    if (weekday.Value == "monday")//checking whether the selected value is monday
                                    {
                                        confirmation.InnerHtml += "Oct " + i++ + " is a Monday!Time to work<br>";//printing if monday is the working day
                                    }
                                    else
                                    {
                                        confirmation.InnerHtml += "Oct " + i++ + " is a Monday!Time to have fun<br>";//printing if monday is not the working day
                                    }
                                }
                            }  
                        }
                    }
                }
            }
        }
    }
}