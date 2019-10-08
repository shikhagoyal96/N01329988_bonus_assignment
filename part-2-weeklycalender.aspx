<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="part-2-weeklycalender.aspx.cs" Inherits="N01329988_BonusAssignment.part_2_weeklycalender" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Part-2-Weekly-Calender</title>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <h2>Select the day of the week working:</h2>
            <asp:CheckBoxList runat="server" ID="weekdays">
                <asp:ListItem Value="monday">Monday</asp:ListItem> 
                <asp:ListItem Value="tuesday">Tuesday</asp:ListItem> 
                <asp:ListItem Value="wednesday">Wednesday</asp:ListItem> 
                <asp:ListItem Value="thursday">Thursday</asp:ListItem> 
                <asp:ListItem Value="friday">Friday</asp:ListItem> 
                <asp:ListItem Value="saturday">Saturday</asp:ListItem> 
                <asp:ListItem Value="sunday">Sunday</asp:ListItem> 
            </asp:CheckBoxList>
        </section>

        <section>
            <input type="submit" value="submit" />
        </section>
        
        <section>
            <asp:ValidationSummary runat="server" ShowSummary="true" />
        </section>

        <section id="confirmation" runat="server"></section>

        
    </form>
</body>
</html>
