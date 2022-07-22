<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaNews.aspx.cs" Inherits="root_popup_modifica_modificanews" %>

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
                    <asp:Label ID="Label1" runat="server" Text="Azienda di riferimento: "></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlAzienda" runat="server"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Data: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDataNews" runat="server" TextMode="Date"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Titolo: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTitolo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="News:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNews" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:Button ID="btnInserisci" runat="server" Text="Inserisci" OnClick="btnInserisci_Click" />
    </form>
</body>
</html>
