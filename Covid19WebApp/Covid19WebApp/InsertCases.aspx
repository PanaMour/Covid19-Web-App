<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertCases.aspx.cs" Inherits="Covid19WebApp.InsertCases" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Insert Case</title>
</head>
<body style="background-color: #ffcc66">
    <form id="form2" runat="server">
        <div style="text-align: center; font-size: x-large; height: 759px;">
            <asp:Label ID="Label1" runat="server" Font-Size="50pt" Text="Insert Case"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            Full Name&nbsp;:&nbsp;<br />
            <asp:TextBox ID="TextBox1" runat="server" autocomplete="off" placeholder="Name Surname" Height="20px"></asp:TextBox>
            <br />
            Email :<br />
            <asp:TextBox ID="TextBox2" runat="server" autocomplete="off" placeholder="email@address.com" Height="20px"></asp:TextBox>
            <br />
            Phone Number :<br />
            <asp:TextBox ID="TextBox3" runat="server" autocomplete="off" placeholder="0000000000" maxlength="10" Height="20px"></asp:TextBox>
            <br />
            Gender :<br />
            <asp:DropDownList ID="DropDownList1" runat="server" Width="100px">
                <asp:ListItem Value="Male"></asp:ListItem>
                <asp:ListItem Value="Female"></asp:ListItem>
            </asp:DropDownList>
            <br />
            Date of Birth :<br />
            <asp:TextBox ID="TextBox5" runat="server" autocomplete="off" placeholder="dd/mm/yyyy" Height="20px"></asp:TextBox>
            <br />
            Underlying Diseases :<br />
            <asp:TextBox ID="TextBox6" runat="server" autocomplete="off" placeholder="Disease1, Disease2..." Height="20px"></asp:TextBox>
            <br />
            Address :<br />
            <asp:TextBox ID="TextBox7" runat="server" autocomplete="off" placeholder="Address, Street Number" Height="20px"></asp:TextBox>
            <br />
            Date of Case :<br />
            <asp:TextBox ID="TextBox8" runat="server" autocomplete="off" placeholder="dd/mm/yyyy" Height="20px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert Case" Height="50px" Width="100px" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Main Page" Height="50px" Width="100px" />
        </div>
    </form>
</body>
</html>
