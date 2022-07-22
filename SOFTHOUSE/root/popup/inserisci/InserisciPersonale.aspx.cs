using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class root_popup_inserisci_inseriscipersonale : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CaricaAziende();
            CaricaTipoContratto();
        }
    }

    protected void CaricaAziende()
    {
        AZIENDE a = new AZIENDE();

        ddlAzienda.DataSource = a.SELECTFORDDL();
        ddlAzienda.DataTextField = "RagioneSociale";
        ddlAzienda.DataValueField = "CodiceAzienda";

        ddlAzienda.DataBind();
    }

    protected void CaricaTipoContratto()
    {
        TIPOLOGIECONTRATTI TC = new TIPOLOGIECONTRATTI();

        ddlTipoContratto.DataSource = TC.SELECTFORDDL();
        ddlTipoContratto.DataTextField = "DescrizioneTipoContratto";
        ddlTipoContratto.DataValueField = "CodiceTipoContratto";

        ddlTipoContratto.DataBind();
    }

    protected void btnInvia_Click(object sender, EventArgs e)
    {
        //dichiaro variabili

        #region "CONTROLLI FORMALI"

        //CommessaChiusa();
        //controlli formali
        if (string.IsNullOrEmpty(txtRagioneSociale.Text) || string.IsNullOrEmpty(txtCognome.Text) || string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtPartitaIva.Text)
             || string.IsNullOrEmpty(txtCodiceFiscale.Text) || string.IsNullOrEmpty(txtIndirizzo.Text) || string.IsNullOrEmpty(txtCitta.Text) || string.IsNullOrEmpty(txtProvincia.Text)
             || string.IsNullOrEmpty(txtCitta.Text) || string.IsNullOrEmpty(txtProvincia.Text) || string.IsNullOrEmpty(txtCap.Text) || string.IsNullOrEmpty(txtDataNascita.Text) 
             || string.IsNullOrEmpty(txtCostoMensile.Text) || string.IsNullOrEmpty(txtDataInizioCollaborazione.Text) || string.IsNullOrEmpty(txtDataFineCollaborazione.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione!", "alert('Dati non validi')", true);
            return;
        }

        #endregion

        int CodiceAzienda = int.Parse(ddlAzienda.SelectedValue);
        int CodiceTipoContratto = int.Parse(ddlTipoContratto.SelectedValue);
        string RagioneSociale = txtRagioneSociale.Text.ToString();
        string Cognome = txtCognome.Text.ToString();
        string Nome = txtNome.Text.ToString();
        string PartitaIva = txtPartitaIva.Text.ToString();
        string CodiceFiscale = txtCodiceFiscale.Text.ToString();
        string Indirizzo = txtIndirizzo.Text.ToString();
        string Citta = txtCitta.Text.ToString();
        string Provincia = txtProvincia.Text.ToString();
        string Cap = txtCap.Text.ToString();
        string DataNascita = txtDataNascita.Text.ToString();
        string CostoMensile = txtCostoMensile.Text.ToString();
        string DataInizoCollaborazione = txtDataInizioCollaborazione.Text.ToString();
        string DataFineCollaborazione = txtDataFineCollaborazione.Text.ToString();

        //inserisco
        PERSONALE.AGGIORNADB c = new PERSONALE.AGGIORNADB();
        c.CodiceAzienda = CodiceAzienda;
        c.CodiceTipoContratto = CodiceTipoContratto;
        c.RagioneSociale = RagioneSociale;
        c.Cognome = Cognome;
        c.Nome = Nome;
        c.PartitaIva = PartitaIva;
        c.CodiceFiscale = CodiceFiscale;
        c.Indirizzo = Indirizzo;
        c.Citta = Citta;
        c.Provincia = Provincia;
        c.Cap = Cap;
        c.DataNascita = DataNascita;
        c.CostoMensile = CostoMensile;
        c.DataInizioCollaborazione = DataInizoCollaborazione;
        c.DataFineCollaborazione = DataFineCollaborazione;

        c.INSERT();

        //pulisco i campi
        txtRagioneSociale.Text = "";
        txtCognome.Text = "";
        txtNome.Text = "";
        txtPartitaIva.Text = "";
        txtCodiceFiscale.Text = "";
        txtIndirizzo.Text = "";
        txtCitta.Text = "";
        txtProvincia.Text = "";
        txtCap.Text = "";
        txtDataNascita.Text = "";
        txtCostoMensile.Text = "";
        txtDataInizioCollaborazione.Text = "";
        txtDataFineCollaborazione.Text = "";

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "SUCCESSO", "alert('Personale inserito')", true);

    }
}
