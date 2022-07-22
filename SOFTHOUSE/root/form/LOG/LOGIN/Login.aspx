<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

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
            <%--login--%>
            <asp:Label ID="lblLogin" runat="server" Text="LOGIN"></asp:Label><br />
            <%--inserimento mail--%>
            <asp:TextBox ID="txtEmail" runat="server">Email</asp:TextBox><br />
            <%--inserimento password--%>
            <asp:TextBox ID="txtPswd" runat="server">Password</asp:TextBox><br />
            <%--bottoni--%>
            <div class="conferma">
                <asp:Button ID="btnLogin" runat="server" Text="LOGIN" OnClick="btnLogin_Click" />
            </div>
            <br />
            <div class="registrazione">
                <asp:Label ID="lblRegistrazione" runat="server" Text="Non sei registrato?"></asp:Label><a href="../REGISTRAZIONE/Registrazione.aspx"><u>CLICCA QUI</u></a>
            </div>
        </div>      
    </form>
</body>
</html>
