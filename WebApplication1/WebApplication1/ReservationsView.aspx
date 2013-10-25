<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReservationsView.aspx.cs" Inherits="WebApplication1.ReservationsView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<asp:Image  ID="Logo" runat="server" ImageUrl="~/images/artesis.jpg" 
                    BorderStyle="None" width="370" />

    <h2>Mijn reservaties</h2>
<br />
<br />
<br />
<br />
<a href="/SlotsView.aspx">Terug naar overzicht</a>
<br />
<br />
<br />
<table>
  <tr>
    <th>Datum</th>
    <th>Begin</th>
    <th>Einde</th>
    <th>Duur</th>
    <th>Digitaal</th>
    <th>Locatie</th>
    <th></th>
  </tr>
    </table>
</body>
</html>
