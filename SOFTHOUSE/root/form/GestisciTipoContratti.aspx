﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GestisciTipoContratti.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <%--javascript popup--%>
    <link rel="stylesheet" href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.10/themes/base/jquery-ui.css" type="text/css" media="all" />
    <link rel="stylesheet" href="http://static.jquery.com/ui/css/demo-docs-theme/ui.theme.css" type="text/css" media="all" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.5.1/jquery.min.js"></script>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.10/jquery-ui.min.js"></script>
    <script src="../../JS/JS.js"></script>
    <%--css--%>
    <link href="../../../CSS/CSS.css" rel="stylesheet" />

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">



    <div id="menu">
        <div class="contieni_bottoni">
            <%--Bottoni per interagire con i dati della griglia, utilizzano gli script di jquery--%>
            <div class="bottoni"><a id="btnInserisci" href="../popup/inserisci/InserisciTipoContratto.aspx">Inserisci Dati</a></div>
            <br />
            <div class="bottoni"><a id="btnModifica" href="../popup/modifica/ModificaTipoContratto.aspx">Modifica Dati</a></div>
            <br />
            <%--Bottone che aggiorna la griglia con i dati inseriti o modificati--%>
            <div class="bottoni">
                <asp:Button ID="aggiornaGriglia"  CssClass="aggiorna_griglia" runat="server" Text="Aggiorna griglia" OnClick="aggiornaGriglia_Click" />
            </div>
        </div>
    </div>
    <%--Griglia per visualizzare i dati--%>
    <asp:GridView ID="griglia" CssClass="griglia" runat="server" DataKeyNames="CodiceTipoContratto" OnSelectedIndexChanged="griglia_SelectedIndexChanged">
        <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Seleziona" />
        </Columns>
    </asp:GridView>

    
        <%--Bottoni per interagire con i dati della griglia, utilizzano gli script di jquery--%>

        <%--<a id="btnInserisci" href="../popup/inserisci/InserisciTipoContratto.aspx">bottone per InsTipoContratto (placeholder) </a>
        <a id="btnModifica" href="../popup/modifica/ModificaTipoContratto.aspx">bottone per ModTipoContratto (placeholder) </a>--%>

        <%--Bottone che aggiorna la griglia con i dati inseriti o modificati--%>

        <%--<asp:Button ID="aggiornaGriglia" runat="server" Text="Aggiorna Griglia" OnClick="aggiornaGriglia_Click" />
    </p>--%>

</asp:Content>

