<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InserisciCommesse.aspx.cs" Inherits="InserisciCommesse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Azienda"></asp:Label></td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Cliente"></asp:Label></td>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Tipo Commessa"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:DropDownList ID="ddlAzienda" runat="server"></asp:DropDownList></td>
                    <td>
                        <asp:DropDownList ID="ddlCliente" runat="server"></asp:DropDownList></td>
                    <td>
                        <asp:DropDownList ID="ddlTipoCommessa" runat="server"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Data Inizio Commessa"></asp:Label></td>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="data Fine Commessa"></asp:Label></td>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Importo Totale"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtDataInizio" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDataFine" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="txtImportoTotale" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Importo Orario"></asp:Label></td>
                    <td>
                        <asp:Label ID="Label8" runat="server" Text="Importo Mensile"></asp:Label></td>
                    <td>
                        <asp:Label ID="Label9" runat="server" Text="Importo Trasferta"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtImportoOrario" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="txtImportoMensile" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="txtImportoTrasferta" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label10" runat="server" Text="Importo Km"></asp:Label></td>
                    <td class="auto-style1">
                        <asp:Label ID="Label11" runat="server" Text="Importo Pasti"></asp:Label></td>
                    <td class="auto-style1">
                        <asp:Label ID="Label12" runat="server" Text="Importo Pernottamenti"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtImportoKm" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="txtImportoPasti" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="txtImportoPernottamenti" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label13" runat="server" Text="Commessa Chiusa (placeholder)"></asp:Label>
                    </td>
                    <td colspan="2">
                        <asp:Label ID="Label14" runat="server" Text="Descrizione Commessa"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:RadioButton ID="rdb1" runat="server" GroupName="Commessa" Checked="True" Text="Aperta" />
                        <asp:RadioButton ID="rdb2" runat="server" GroupName="Commessa" Text="Chiusa" />
                    </td>
                    <td>

                        <asp:TextBox ID="txtDescrizioneCommessa" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnInserisci" runat="server" Text="Inserisci" OnClick="btnInserisci_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
