﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminCampus.aspx.cs" Inherits="WebApplication1.AdminCampus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
        <tr>
            <td colspan="2" align="center">Nieuwe Campus Toevoegen</td>
        </tr>
        <tr>
            <td>Plaats:</td>
            <td>
                <asp:TextBox ID="txtboxCampusPlaats" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="btnCampus" runat="server" Text="Toevoegen" OnClick="btnCampus_Click" />
            </td>
        </tr>



    </table>
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="dataSourceCampussen">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Plaats" HeaderText="Plaats" SortExpression="Plaats" />
            </Columns>
        </asp:GridView>
        <asp:LinqDataSource ID="dataSourceCampussen" runat="server" ContextTypeName="WebApplication1.DatabaseDataClassesDataContext" EntityTypeName="" TableName="tblCampus">
        </asp:LinqDataSource>
    </form>
</body>
</html>
