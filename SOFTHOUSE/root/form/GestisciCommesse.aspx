<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GestisciCommesse.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <%--javascript popup--%>
    <link rel="stylesheet" href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.10/themes/base/jquery-ui.css" type="text/css" media="all" />
    <link rel="stylesheet" href="http://static.jquery.com/ui/css/demo-docs-theme/ui.theme.css" type="text/css" media="all" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.5.1/jquery.min.js"></script>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.10/jquery-ui.min.js"></script>
    <script src="../../JS/JS.js"></script>
    <%--css--%>
    <%--<link href="../../../CSS/CSS.css" rel="stylesheet" />--%>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <table>
        <tr>
            <td colspan="3">
                <asp:GridView ID="griglia" runat="server" DataKeyNames="CodiceCommessa" OnSelectedIndexChanged="griglia_SelectedIndexChanged" OnRowDataBound="griglia_RowDataBound">
                    <Columns>
                        <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
            </td>
            <tr>
                <td colspan="3">
                    <a id="btnInserisci" href="../popup/inserisci/InserisciCommesse.aspx">bottone per InsCommesse (placeholder)</a>
                    <a id="btnModifica" href="../popup/modifica/ModificaCommesse.aspx">bottone per ModCommesse (placeholder) </a>
                    <asp:Button ID="btnRicarica" runat="server" Text="Ricarica griglia" OnClick="btnRicarica_Click" />
                </td>
            </tr>
    </table>

</asp:Content>

