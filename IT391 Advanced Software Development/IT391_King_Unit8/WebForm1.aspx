<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="IT391_King_Unit8.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="label1" Width="75" runat="server" Text="Street"></asp:Label>
            <asp:TextBox ID="txtStreet" Width="225" runat="server" Text="333 E Trade Street"></asp:TextBox>
            <p>
                <asp:Label ID="label2" Width="75" runat="server" Text="City"></asp:Label>
                <asp:TextBox ID="txtCity" Width="150" runat="server" Text="Charlotte"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="label3" Width="75" runat="server" Text="State"></asp:Label>
                <asp:TextBox ID="txtState" Width="150" runat="server" Text="North Carolina"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="label4" Width="75" runat="server" Text="Zip"></asp:Label>
                <asp:TextBox ID="txtZip" Width="150" runat="server" Text="28202"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="btnMap" runat="server" OnClick="btnMap_Click" Text="Get Map" />
            </p>
        </div>
    </form>
</body>
</html>