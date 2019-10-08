using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace N01329988_BonusAssignment
{
    public partial class part_3_rafflebundle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();

                if (Page.IsValid)
                {
                    int ticket_number = Convert.ToInt32(tickets_ordered.Text);//converting string value to int
                    double total = 0.0;
                    int temp = 0;
                    int remainder = 0;
                    if (ticket_number <= 50)//to check for ticket number below the value 50
                    {
                        confirmation.InnerHtml = " ";
                        for (int i = 1; i <= ticket_number; i++)
                        {
                            confirmation.InnerHtml += "You received a bundle of 1! That's " + i + "ticket(s)!<br>";
                        }
                        total = (ticket_number * 0.25);//calculating total amount
                        confirmation.InnerHtml += "Your total ticket(s) is " + ticket_number + " and your cost is $" + total + "cad<br>";
                    }
                    
                    else if (ticket_number >= 51 && ticket_number <= 150)//to check for tickets number between 51 and 150 also included
                    {
                            confirmation.InnerHtml = " ";
                            remainder = (ticket_number % 2);
                            for (int i = 2; i <= (ticket_number - remainder); i = i + 2)
                            {
                                confirmation.InnerHtml += "You received a bundle of 2! That's " + i + "ticket(s)!<br>";
                                temp = i;
                            }
                            confirmation.InnerHtml += "Your leftover is "+remainder+" ticket(s). That's " + ticket_number + "ticket(s)!<br>";
                            total = (ticket_number * 0.25);//calculating total amount
                        confirmation.InnerHtml += "Your total ticket(s) is " + ticket_number + " and your cost is $" + total + "cad!<br>";
                        }
                    

                    else if(ticket_number >= 151 && ticket_number <= 300)//to check for tickets number between 151 and 300 also included
                    {
                            confirmation.InnerHtml = " ";
                            remainder = (ticket_number % 3);
                            for (int i = 3; i <= (ticket_number - remainder); i = i + 3)
                            {
                                confirmation.InnerHtml += "You received a bundle of 3! That's " + i + "ticket(s)!<br>";
                                temp = i;
                            }
                            confirmation.InnerHtml += "Your leftover is "+remainder+" ticket(s). That's " + ticket_number + "ticket(s)!<br>";
                            total = (ticket_number * 0.25);//calculating total amount
                        confirmation.InnerHtml += "Your total ticket(s) is " + ticket_number + " and your cost is $" + total + "cad!<br>";
                        }
                    
                    else if(ticket_number >= 301)//to check for tickets number above 301 also included
                    {
                        confirmation.InnerHtml = " ";
                        remainder = (ticket_number % 5);
                        for (int i = 5; i <= (ticket_number - remainder); i = i + 5)
                        {
                            confirmation.InnerHtml += "You received a bundle of 5! That's " + i + "ticket(s)!<br>";
                            temp = i;
                        }
                        confirmation.InnerHtml += "Your leftover is " + remainder + " ticket(s). That's " + ticket_number + "ticket(s)!<br>";
                        total = (ticket_number * 0.25);//calculating total amount
                        confirmation.InnerHtml += "Your total ticket(s) is " + ticket_number + " and your cost is $" + total + "cad!<br>";
                    }
                }
            }
        }
    }
}