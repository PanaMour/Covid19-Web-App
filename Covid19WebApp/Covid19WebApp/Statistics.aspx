<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Statistics.aspx.cs" Inherits="Covid19WebApp.Statistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Statistics</title>
</head>
<body style="background-color: #ffffcc;">
    <form id="form1" runat="server">
        <div style="font-size: x-large; text-align: center; height: 1033px;">
            <asp:Label ID="Label1" runat="server" Font-Size="50pt" Text="Statistics"></asp:Label>
            <br />
            <br />
            <asp:Chart ID="Chart1" runat="server" Height="400px" ImageStorageMode="UseImageLocation" TabIndex="3" Width="500px">
                <Series>
                    <asp:Series ChartType="Pie" Legend="Legend1" Name="Series1">
                    </asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </ChartAreas>
                <Legends>
                    <asp:Legend Name="Legend1">
                    </asp:Legend>
                </Legends>
            </asp:Chart>
            <br />
            <br />
            <asp:Chart ID="Chart2" runat="server" Height="400px" ImageStorageMode="UseImageLocation" Width="500px">
                <Series>
                    <asp:Series ChartType="Pie" Legend="Legend1" Name="Series1">
                    </asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </ChartAreas>
                <Legends>
                    <asp:Legend Name="Legend1">
                    </asp:Legend>
                </Legends>
            </asp:Chart>
            <br />
            <br />
            <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Main Page" Font-Size="Large" Height="50px" Width="100px" />
        </div>
    </form>
</body>
</html>
