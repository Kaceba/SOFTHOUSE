<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EliminaNews.aspx.cs" Inherits="root_popup_elimina_EliminaNews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <%--<asp:Label ID="Label1" runat="server" Text="!ATTENZIONE!<br/> Una volta eliminati i dati non saranno più recuperabili.<br/>Procedere?"></asp:Label>--%>
                    <asp:Literal ID="Literal1" runat="server">ATTENZIONE! <br/><br /> Una volta eliminati i dati non saranno più recuperabili.<br /><br /> Procedere?<br /></asp:Literal>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnElimina" runat="server" Text="Elimina" OnClick="btnElimina_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
