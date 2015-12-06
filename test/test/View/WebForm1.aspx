<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="test.View.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Please enter the item number and text input to search. "></asp:Label><br />
        <asp:TextBox ID="TextBox1" runat="server" Text="item number"></asp:TextBox><br /><br />
        <asp:TextBox ID="TextBox2" runat="server" Text="free text"></asp:TextBox><br /><br /><br /><br /><br />
        <asp:Button ID="Button1" runat="server" Text="Search" /><br /><br /><br /><br />
        <asp:ListView ID="ListView1" runat="server"></asp:ListView>

    </div>
    </form>
</body>
</html>
