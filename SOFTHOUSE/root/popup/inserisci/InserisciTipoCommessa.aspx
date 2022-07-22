<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InserisciTipoCommessa.aspx.cs" Inherits="InserisciTipiCommesse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtTipoCommessa" runat="server"></asp:TextBox>
            <asp:Button ID="btnInvia" runat="server" Text="Invia" OnClick="btnInvia_Click" />
        </div>
    </form>
</body>
</html>
