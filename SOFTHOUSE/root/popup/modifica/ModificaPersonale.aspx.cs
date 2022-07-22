using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class root_popup_modifica_modificapersonale : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["CodicePersonale"] == null)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Seleziona una riga per poterla modificare')", true);
                return;
            }

            int capocchia = int.Parse(Session["CodicePersonale"].ToString());

            PERSONALE P = new PERSONALE();
            DataTable dt = P.SELECT(int.Parse(Session["CodicePersonale"].ToString()));

            CaricaAziende();
            CaricaTipoContratto();

            txtRagioneSociale.Text = dt.Rows[0]["RagioneSociale"].ToString();
            txtCognome.Text = dt.Rows[0]["Cognome"].ToString();
            txtNome.Text = dt.Rows[0]["Nome"].ToString();
            txtPartitaIva.Text = dt.Rows[0]["PartitaIva"].ToString();
            txtCodiceFiscale.Text = dt.Rows[0]["CodiceFiscale"].ToString();
            txtIndirizzo.Text = dt.Rows[0]["Indirizzo"].ToString();
            txtCitta.Text = dt.Rows[0]["Citta"].ToString();
            txtProvincia.Text = dt.Rows[0]["Provincia"].ToString();
            txtCap.Text = dt.Rows[0]["Cap"].ToString();
            txtDataNascita.Text = dt.Rows[0].Field<DateTime>(12).ToString("yyyy-MM-dd");
            txtCostoMensile.Text = dt.Rows[0]["CostoMensile"].ToString();
            txtDataInizioCollaborazione.Text = dt.Rows[0].Field<DateTime>(14).ToString("yyyy-MM-dd");
            txtDataFineCollaborazione.Text = dt.Rows[0].Field<DateTime>(15).ToString("yyyy-MM-dd");

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

    protected void btnModifica_Click(object sender, EventArgs e)
    {
        #region "CONTROLLI FORMALI"

        //controllo che il campo non sia vuoto
        if (string.IsNullOrEmpty(txtRagioneSociale.Text) || string.IsNullOrEmpty(txtCognome.Text) || string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtPartitaIva.Text)
            || string.IsNullOrEmpty(txtCodiceFiscale.Text) || string.IsNullOrEmpty(txtIndirizzo.Text) || string.IsNullOrEmpty(txtCitta.Text) || string.IsNullOrEmpty(txtProvincia.Text)
            || string.IsNullOrEmpty(txtCap.Text) || string.IsNullOrEmpty(txtDataNascita.Text) || string.IsNullOrEmpty(txtCostoMensile.Text) || string.IsNullOrEmpty(txtDataInizioCollaborazione.Text)
            || string.IsNullOrEmpty(txtDataFineCollaborazione.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione!", "alert('Dati non validi, almeno un campo vuoto')", true);
            return;
        }

        #endregion

        int codicePersonale = int.Parse(Session["CodicePersonale"].ToString());
        int codiceAzienda = int.Parse(ddlAzienda.SelectedValue);
        int codiceTipoContratto = int.Parse(ddlTipoContratto.SelectedValue);
        string RagioneSociale = txtRagioneSociale.Text; 
        string Cognome = txtCognome.Text;
        string Nome = txtNome.Text;
        string PartitaIva = txtPartitaIva.Text;
        string CodiceFiscale = txtCodiceFiscale.Text;
        string Indirizzo = txtIndirizzo.Text;
        string Citta = txtCitta.Text;
        string Provincia = txtProvincia.Text;
        string Cap = txtCap.Text;
        string DataNascita = txtDataNascita.Text;
        string CostoMensile = txtCostoMensile.Text;
        string DataInizioCollab = txtDataInizioCollaborazione.Text;
        string DataFineCollab = txtDataFineCollaborazione.Text;

        PERSONALE.AGGIORNADB PA = new PERSONALE.AGGIORNADB();

        PA.CodicePersonale = codicePersonale;
        PA.CodiceAzienda = codiceAzienda;
        PA.CodiceTipoContratto = codiceTipoContratto;
        PA.RagioneSociale = RagioneSociale;
        PA.Cognome = Cognome;
        PA.Nome = Nome;
        PA.PartitaIva = PartitaIva;
        PA.CodiceFiscale = CodiceFiscale;
        PA.Indirizzo = Indirizzo;
        PA.Citta = Citta;
        PA.Provincia = Provincia;
        PA.Cap = Cap;
        PA.DataNascita = DataNascita;
        PA.CostoMensile = CostoMensile;
        PA.DataInizioCollaborazione = DataInizioCollab;
        PA.DataFineCollaborazione = DataFineCollab;

        PA.UPDATE();

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione!", "alert('Dati inseriti correttamente')", true);

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

        Session["CodicePersonale"] = null;

    }
}