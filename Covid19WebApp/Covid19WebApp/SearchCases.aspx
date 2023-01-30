<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchCases.aspx.cs" Inherits="Covid19WebApp.SearchCases" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search Case</title>
</head>
<body style="background-color: #ffffcc;">
    <form id="form1" runat="server">
        <div style="text-align: center; font-size: large; font-family: 'Times New Roman', Times, serif;">
            <asp:Label ID="Label1" runat="server" Font-Size="50pt" Text="Search Case"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            Search Case based on Full Name:<br />
            <asp:TextBox ID="TextBox10" runat="server" autocomplete="off" Height="20px" Font-Size="Large"></asp:TextBox>
            <br />
            <br />
            Search Case based on Email:<br />
            <asp:TextBox ID="TextBox11" runat="server" autocomplete="off" Height="20px" Font-Size="Large"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Search" Font-Size="Large" Height="50px" Width="100px" />
            <br />
            <div style="text-align: left; margin-left: 661px;">
            <asp:Label ID="Label2" runat="server" BackColor="#CCFFCC" Font-Size="Large"></asp:Label>
            </div>
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Main Page" Font-Size="Large" Height="50px" Width="100px" />
        </div>
    </form>
</body>
</html>
