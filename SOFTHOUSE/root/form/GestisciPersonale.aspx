<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GestisciPersonale.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <%--javascript popup--%>
    <link rel="stylesheet" href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.10/themes/base/jquery-ui.css" type="text/css" media="all" />
    <link rel="stylesheet" href="http://static.jquery.com/ui/css/demo-docs-theme/ui.theme.css" type="text/css" media="all" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.5.1/jquery.min.js"></script>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.10/jquery-ui.min.js"></script>
    <script src="../../JS/JS.js"></script>
    <%--css--%>
    <%--<link href="../../../CSS/CSS.css" rel="stylesheet" />--%>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:GridView ID="griglia" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="griglia_SelectedIndexChanged" DataKeyNames="CodicePersonale" OnRowDataBound="griglia_RowDataBound"></asp:GridView>

    <p>
        <%--Bottoni per interagire con i dati della griglia, utilizzano gli script di jquery--%>

        <a id="btnInserisci" href="../popup/inserisci/InserisciPersonale.aspx">bottone per InsPersonale (placeholder)</a>
        <a id="btnModifica" href="../popup/modifica/ModificaPersonale.aspx">bottone per ModPersonale (placeholder) </a>

        <%--Bottone che aggiorna la griglia con i dati inseriti o modificati--%>

        <asp:Button ID="btnAggiornaGriglia" runat="server" Text="Aggiorna" OnClick="btnAggiornaGriglia_Click" />
    </p>

</asp:Content>

