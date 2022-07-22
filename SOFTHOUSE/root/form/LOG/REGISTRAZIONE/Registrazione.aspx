<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registrazione.aspx.cs" Inherits="root_REGISTRAZIONE_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../../../../CSS/login_registrazione.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="formLogin">
            <asp:Label ID="lblLogin" runat="server" Text="REGISTRAZIONE"></asp:Label>
            <%--inserimento mail--%>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br />
            <div class="conferma">
                <asp:Button ID="btnLogin" runat="server" Text="REGISTRATI" OnClick="btnRegistrazione_Click" />
            </div>
        </div>


    </form>
</body>
</html>
