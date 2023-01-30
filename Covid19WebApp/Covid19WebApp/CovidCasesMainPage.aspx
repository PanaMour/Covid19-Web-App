<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CovidCasesMainPage.aspx.cs" Inherits="Covid19WebApp.CovidCasesMainPage" Theme="" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Covid Cases Main Page</title>
</head>
<body style="background-image: url('covid.jpg');">
    <form id="form1" runat="server">
        <div style="text-align:center; height: 649px; background-image: url('covid.jpg');">
            <asp:Label ID="Label1" runat="server" Font-Size="50pt" Text="Covid Cases" ForeColor="#99FFCC"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Insert" BackColor="Red" BorderStyle="Outset" Font-Bold="True" Font-Names="Times New Roman" Font-Size="X-Large" Font-Underline="False" Height="50px" OnClick="Button1_Click" Width="120px" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Display" BackColor="Red" BorderStyle="Outset" Font-Bold="True" Font-Names="Times New Roman" Font-Size="X-Large" Font-Underline="False" Height="50px" OnClick="Button2_Click" Width="120px" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Delete" BackColor="Red" BorderStyle="Outset" Font-Bold="True" Font-Names="Times New Roman" Font-Size="X-Large" Font-Underline="False" Height="50px" OnClick="Button3_Click" Width="120px" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" Text="Edit" BackColor="Red" BorderStyle="Outset" Font-Bold="True" Font-Names="Times New Roman" Font-Size="X-Large" Font-Underline="False" Height="50px" OnClick="Button4_Click" Width="120px" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Search" BackColor="Red" BorderStyle="Outset" Font-Bold="True" Font-Names="Times New Roman" Font-Size="X-Large" Font-Underline="False" Height="50px" Width="120px" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button6" runat="server" BackColor="Red" BorderStyle="Outset" Font-Bold="True" Font-Names="Times New Roman" Font-Size="X-Large" Height="50px" OnClick="Button6_Click" Text="Statistics" Width="120px" />
        </div>
    </form>
</body>
</html>
