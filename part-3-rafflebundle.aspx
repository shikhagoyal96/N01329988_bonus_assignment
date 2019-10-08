<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="part-3-rafflebundle.aspx.cs" Inherits="N01329988_BonusAssignment.part_3_rafflebundle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <h2>Enter the number of tickets you want to order:</h2>
            <asp:TextBox runat="server" ID="tickets_ordered"></asp:TextBox>
        </section>

        <section>
            <input type="submit" value="submit" />
        </section>

        <section>
            <asp:ValidationSummary runat="server" ShowSummary="true" />
        </section>

        <section id="confirmation" runat="server">

        </section>

        
       
    </form>
</body>
</html>
