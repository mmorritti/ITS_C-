<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Persone.aspx.cs" Inherits="WATest.Persone" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>

            <asp:SqlDataSource 
                ID="SqlDataSource1" 
                runat="server" 
                ConnectionString="<%$ ConnectionStrings:AdventureWorks %>" 
                SelectCommand="SELECT TOP 100 * FROM [Person].[Person]" 
                DeleteCommand="DELETE FROM [Person].[Person] WHERE [BusinessEntityID] = @BusinessEntityID" 
                InsertCommand="INSERT INTO [Person].[Person] ([BusinessEntityID], [PersonType], [NameStyle], [Title], [FirstName], [MiddleName], [LastName], [Suffix], [EmailPromotion], [AdditionalContactInfo], [Demographics], [rowguid], [ModifiedDate]) VALUES (@BusinessEntityID, @PersonType, @NameStyle, @Title, @FirstName, @MiddleName, @LastName, @Suffix, @EmailPromotion, @AdditionalContactInfo, @Demographics, @rowguid, @ModifiedDate)" 
                UpdateCommand="UPDATE [Person].[Person] SET [PersonType] = @PersonType, [NameStyle] = @NameStyle, [Title] = @Title, [FirstName] = @FirstName, [MiddleName] = @MiddleName, [LastName] = @LastName, [Suffix] = @Suffix, [EmailPromotion] = @EmailPromotion, [AdditionalContactInfo] = @AdditionalContactInfo, [Demographics] = @Demographics, [rowguid] = @rowguid, [ModifiedDate] = @ModifiedDate WHERE [BusinessEntityID] = @BusinessEntityID">
                <DeleteParameters>
                    <asp:Parameter Name="BusinessEntityID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="BusinessEntityID" Type="Int32" />
                    <asp:Parameter Name="PersonType" Type="String" />
                    <asp:Parameter Name="NameStyle" Type="Boolean" />
                    <asp:Parameter Name="Title" Type="String" />
                    <asp:Parameter Name="FirstName" Type="String" />
                    <asp:Parameter Name="MiddleName" Type="String" />
                    <asp:Parameter Name="LastName" Type="String" />
                    <asp:Parameter Name="Suffix" Type="String" />
                    <asp:Parameter Name="EmailPromotion" Type="Int32" />
                    <asp:Parameter Name="AdditionalContactInfo" Type="Object" />
                    <asp:Parameter Name="Demographics" Type="Object" />
                    <asp:Parameter Name="rowguid" Type="Object" />
                    <asp:Parameter Name="ModifiedDate" Type="DateTime" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="PersonType" Type="String" />
                    <asp:Parameter Name="NameStyle" Type="Boolean" />
                    <asp:Parameter Name="Title" Type="String" />
                    <asp:Parameter Name="FirstName" Type="String" />
                    <asp:Parameter Name="MiddleName" Type="String" />
                    <asp:Parameter Name="LastName" Type="String" />
                    <asp:Parameter Name="Suffix" Type="String" />
                    <asp:Parameter Name="EmailPromotion" Type="Int32" />
                    <asp:Parameter Name="AdditionalContactInfo" Type="Object" />
                    <asp:Parameter Name="Demographics" Type="Object" />
                    <asp:Parameter Name="rowguid" Type="Object" />
                    <asp:Parameter Name="ModifiedDate" Type="DateTime" />
                    <asp:Parameter Name="BusinessEntityID" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
