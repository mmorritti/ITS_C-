<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WATestFirst_empty_.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title id = "pageTitle" runat = "server"></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label> <br />
            <asp:Button ID="Button1" runat="server" Text="Cliccami" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
