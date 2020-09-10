<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prodotti.aspx.cs" Inherits="WATest.Prodotti" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlProdotti" runat="server"></asp:DropDownList><br />
            <asp:Button ID="bExecute" runat="server" Text="Esegui" OnClick="bExecute_Click" />
            <asp:Label ID="lProductName" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
