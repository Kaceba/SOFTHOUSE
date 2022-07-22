<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InserisciPersonale.aspx.cs" Inherits="root_popup_inserisci_inseriscipersonale" %>

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
                    <asp:Label ID="Label2" runat="server" Text="Azienda: "></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlAzienda" runat="server"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Tipo Contratto: "></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlTipoContratto" runat="server"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Ragione sociale: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtRagioneSociale" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Cognome: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCognome" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Nome: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Partita Iva: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPartitaIva" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Codice fiscale: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCodiceFiscale" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label9" runat="server" Text="Indirizzo: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtIndirizzo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label10" runat="server" Text="Città: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCitta" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label11" runat="server" Text="Provincia: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtProvincia" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label12" runat="server" Text="CAP: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCap" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label13" runat="server" Text="Data di nascita: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDataNascita" runat="server" TextMode="Date"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label14" runat="server" Text="Costo mensile: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCostoMensile" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label15" runat="server" Text="Data inizio collaborazione: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDataInizioCollaborazione" runat="server" TextMode="Date"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label16" runat="server" Text="Data fine collaborazione: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDataFineCollaborazione" runat="server" TextMode="Date"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnInvia" runat="server" Text="Invia" OnClick="btnInvia_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
