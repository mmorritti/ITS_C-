<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WATest.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title id="pageTitle" runat="server"></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>

                <label id="label2" runat="server">Testo</label> <!-- HTML -->
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label> <!-- ASP.NET -->

                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">LinkButton</asp:LinkButton>
                <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>

            </div>
        </form>
    </body>
</html>
