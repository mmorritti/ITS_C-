<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp2_counter._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>PROVA COUNTER</h1>
        <p class="lead">&nbsp;</p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" BackColor="#3366FF" BorderColor="Red" BorderStyle="Double" CssClass="active" OnClick="Button1_Click" Text="INIZIO" />
        </p>
    </div>

</asp:Content>
