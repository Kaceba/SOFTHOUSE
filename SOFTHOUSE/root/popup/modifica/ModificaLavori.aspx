<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModificaLavori.aspx.cs" Inherits="ModificaLavori" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="mod" runat="server">
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Personale"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Commessa"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="ddlPersonale" runat="server"></asp:DropDownList>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlCommessa" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Data Lavoro"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Ore Lavoro"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtDataLavoro" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="txtOreLavoro" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Trasferta"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Kilometri"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtTrasferta" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="txtKm" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Pasti"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label8" runat="server" Text="Pernottamenti"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtPasti" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPernottamenti" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnModifica" runat="server" Text="Modifica" OnClick="btnModifica_Click" />
                    </td>
                    <td></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
