<%@ Page Language="C#" AutoEventWireup="true" CodeFile="abilitautente.aspx.cs" Inherits="ABILITAUTENTE_Default" %>

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
                    <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblStato" runat="server" Text="Stato: "></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlStato" runat="server" DataSourceID="SOFTWEREHOUSEConnectionString">
                        <asp:ListItem Value="1">abilitato</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem Value="0">disabilitato</asp:ListItem>
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SOFTWEREHOUSEConnectionString" runat="server"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnModifica" runat="server" Text="Modifica" OnClick="btnModifica_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
