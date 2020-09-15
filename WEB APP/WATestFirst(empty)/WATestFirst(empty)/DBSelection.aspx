<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DBSelection.aspx.cs" Inherits="WATestFirst_empty_.DBSelection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlProdotti" runat="server" ></asp:DropDownList> <br /> 
            <asp:Button ID="Button1" runat="server" Text="Seleziona" OnClick  ="bExecute_Click" />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            

        </div>
       
            

        
    </form>
</body>
</html>
