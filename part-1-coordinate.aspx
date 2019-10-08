<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="part-1-coordinate.aspx.cs" Inherits="N01329988_BonusAssignment.part_1_coordinate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Part-1-Coordinate</title>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <h2>Enter the X-axis value :</h2>
            <asp:TextBox runat="server" ID="x"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="x" EnableClientScript="true"
               ErrorMessage="Please Enter a non-zero value.."></asp:RequiredFieldValidator>
        </section>

        <section>
            <h2>Enter the Y-axis value :</h2>
            <asp:TextBox runat="server" ID="y"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ControlToValidate="y" EnableClientScript="true"
                ErrorMessage="Please enter a non-zero value.."></asp:RequiredFieldValidator>
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
