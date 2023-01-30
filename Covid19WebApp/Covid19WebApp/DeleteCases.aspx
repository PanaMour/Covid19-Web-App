<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteCases.aspx.cs" Inherits="Covid19WebApp.DeleteCases" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delete Case</title>
</head>
<body style="background-color: #ff66ff;">
    <form id="form1" runat="server">
        <div style="font-size: x-large; text-align: center">
            <asp:Label ID="Label1" runat="server" Font-Size="50pt" Text="Delete Case"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            Write the Full Name of the Case you want&nbsp; to delete:<br />
            <br />
            <asp:TextBox ID="TextBox9" runat="server" autocomplete="off" Height="20px" Width="200px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" Font-Size="Large" Height="50px" Width="100px" />
            <br />
            <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Main Page" Font-Size="Large" Height="50px" Width="100px" />
        </div>
    </form>
</body>
</html>
