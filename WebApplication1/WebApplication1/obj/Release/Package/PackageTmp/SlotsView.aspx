<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SlotsView.aspx.cs" Inherits="WebApplication1.SlotsView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Examonitor</title>
</head>
<body>
    <asp:Image  ID="Logo" runat="server" ImageUrl="~/images/artesis.jpg" 
                    BorderStyle="None" width="370" />

    <h2>Toezichtsbeurten BLS</h2>
<br />
<span style="color:red"></span>
<br />
<br />
<br />
Toezichtsbeurten voor :  Antwerpen
<br />
<br />
<a href="/ReservationsView.aspx">Mijn reservaties</a>
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
    <th>Totaal</th>
    <th>Vrij</th>
    <th></th>
  </tr>
    </table>
<br />
<br />

</body>
</html>
