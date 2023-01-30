<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayCases.aspx.cs" Inherits="Covid19WebApp.DisplayCases" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Display Cases</title>
</head>
<body style="background-color: #99ccff;">
    <form id="form1" runat="server">
        <div style="font-size: large; text-align: center">
            <asp:Label ID="Label1" runat="server" Font-Size="50pt" Text="Display Cases"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" style="margin-left: auto;margin-right: auto">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <br />
&nbsp;<br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Main Page" Width="100px" Font-Size="Large" Height="50px" />
        </div>
    </form>
</body>
</html>
