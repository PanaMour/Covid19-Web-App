<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditCases.aspx.cs" Inherits="Covid19WebApp.EditCases" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Case</title>
</head>
<body style="background-color: #ccccff;">
    <form id="form1" runat="server">
        <div style="text-align: center; font-size: x-large">
            <asp:Label ID="Label1" runat="server" Font-Size="50pt" Text="Edit Case"></asp:Label>
            <br />
            <br />
            Write the Full Name of the Case you want to edit:<br />
            <asp:TextBox ID="TextBox9" runat="server" autocomplete="off" placeholder="Name Surname" Height="20px"></asp:TextBox>
            <br />
            <div style="text-align: center; background-color: #CC99FF">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="20pt" Text="Edit the Case's Information"></asp:Label>
                <br />
                <br />
            Full Name&nbsp;:&nbsp;<br />
            <asp:TextBox ID="TextBox1" runat="server" autocomplete="off" placeholder="Name Surname" Height="20px"></asp:TextBox>
                <br />
            <br />
            Email :<br />
            <asp:TextBox ID="TextBox2" runat="server" autocomplete="off" placeholder="email@address.com" Height="20px"></asp:TextBox>
                <br />
            <br />
            Phone Number :<br />
            <asp:TextBox ID="TextBox3" runat="server" autocomplete="off" placeholder="0000000000" maxlength="10" Height="20px"></asp:TextBox>
                <br />
            <br />
            Gender :<br />
            <asp:DropDownList ID="DropDownList1" runat="server" Width="100px">
                <asp:ListItem Value="Male"></asp:ListItem>
                <asp:ListItem Value="Female"></asp:ListItem>
            </asp:DropDownList>
                <br />
            <br />
            Date of Birth :<br />
            <asp:TextBox ID="TextBox5" runat="server" autocomplete="off" placeholder="dd/mm/yyyy" Height="20px"></asp:TextBox>
                <br />
            <br />
            Underlying Diseases :<br />
            <asp:TextBox ID="TextBox6" runat="server" autocomplete="off" placeholder="Disease1, Disease2..." Height="20px"></asp:TextBox>
                <br />
            <br />
            Address :<br />
            <asp:TextBox ID="TextBox7" runat="server" autocomplete="off" placeholder="Address, Street Number" Height="20px"></asp:TextBox>
                <br />
            <br />
            Date of Case :<br />
            <asp:TextBox ID="TextBox8" runat="server" autocomplete="off" placeholder="dd/mm/yyyy" Height="20px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Edit Case" Font-Size="Large" Height="50px" Width="100px" />
                <br />
            </div>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Font-Size="Large" Height="50px" OnClick="Button2_Click" Text="Main Page" Width="100px" />
            <br />
        </div>
    </form>
</body>
</html>
