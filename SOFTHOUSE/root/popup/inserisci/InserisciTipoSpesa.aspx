﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InserisciTipoSpesa.aspx.cs" Inherits="root_popup_inserisci_InserisciTipoSpesa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtTipoSpesa" runat="server"></asp:TextBox>
            <asp:Button ID="btnInvia" runat="server" Text="Invia" OnClick="btnInvia_Click" />
        </div>
    </form>
</body>
</html>
