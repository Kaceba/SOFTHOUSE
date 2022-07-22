<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InserisciAzienda.aspx.cs" Inherits="root_popup_inserisci_inserisciazienda" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>



</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="ragione sociale: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtRagioneSociale" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Partita Iva: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPartitaIva" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Indirizzo: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtIndirizzo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Città: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCitta" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Cap: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCap" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Provincia: "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtProvincia" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <asp:Button ID="BtnInserisci" runat="server" Text="Inserisci" OnClick="BtnInserisci_Click" />
        </div>
    </form>
</body>
</html>
