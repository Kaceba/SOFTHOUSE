<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaSpese.aspx.cs" Inherits="ModificaSpesePopUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="mod" runat="server">
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Azienda"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Tipologia Spesa"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="ddlAzienda" runat="server"></asp:DropDownList>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlTipoSpesa" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Importo"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Data Spesa"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtImporto" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDataSpesa" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnModifica" runat="server" Text="Modifica" OnClick="btnModifica_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
