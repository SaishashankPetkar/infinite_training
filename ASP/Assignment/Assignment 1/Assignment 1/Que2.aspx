<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Que2.aspx.cs" Inherits="Assignment_1.Que2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Select the car whose image and price you want to see:</h1>
            <asp:DropDownList ID="DL1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DL1_SelectedIndexChanged">
                <asp:ListItem Value="Select" Text="Select"></asp:ListItem>
                <asp:ListItem Value="Lamborghini" Text="Lamborghini"></asp:ListItem>
                <asp:ListItem Value="Bugatti" Text="Bugatti"></asp:ListItem>
                <asp:ListItem Value="Bentley" Text="Bentley"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" Width="426px"/>
            <br />
            <br />
            <asp:Button ID="BtnGetPrice" runat="server" Text="Get Price" OnClick="BtnGetPrice_Click" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
