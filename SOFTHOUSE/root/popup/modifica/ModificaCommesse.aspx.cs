using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ModificaCommesse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["CodiceCommessa"] == null)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Seleziona una riga per poterla modificare')", true);
                return;
            }

            COMMESSE co = new COMMESSE();
            DataTable dt = co.SELECT(int.Parse(Session["CodiceCommessa"].ToString()));

            CaricaAziende();
            CaricaClienti();
            CaricaTipoCommessa();

            txtDataFine.Text = dt.Rows[0].Field<DateTime>(5).ToString("yyyy-MM-dd");
            txtDataInizio.Text = dt.Rows[0].Field<DateTime>(6).ToString("yyyy-MM-dd");
            txtImportoKm.Text = dt.Rows[0]["ImportoKm"].ToString();
            txtImportoMensile.Text = dt.Rows[0]["ImportoMensile"].ToString();
            txtImportoOrario.Text = dt.Rows[0]["ImportoOrario"].ToString();
            txtImportoPasti.Text = dt.Rows[0]["ImportoPasti"].ToString();
            txtImportoPernottamenti.Text = dt.Rows[0]["ImportoPernottamenti"].ToString();
            txtImportoTotale.Text = dt.Rows[0]["ImportoTotale"].ToString();
            txtImportoTrasferta.Text = dt.Rows[0]["ImportoTrasferta"].ToString();
            txtDescrizioneCommessa.Text = dt.Rows[0]["DescrizioneCommessa"].ToString();
            
        }
    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {
        #region CONTROLLI FORMALI

        //controllo che il campo non sia vuoto
        if (string.IsNullOrEmpty(txtDataInizio.Text) || string.IsNullOrEmpty(txtDataFine.Text) || string.IsNullOrEmpty(txtImportoKm.Text) || string.IsNullOrEmpty(txtImportoMensile.Text)
            || string.IsNullOrEmpty(txtImportoOrario.Text) || string.IsNullOrEmpty(txtImportoPasti.Text) || string.IsNullOrEmpty(txtImportoPernottamenti.Text) || string.IsNullOrEmpty(txtImportoTotale.Text)
            || string.IsNullOrEmpty(txtImportoTrasferta.Text) || string.IsNullOrEmpty(txtDescrizioneCommessa.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione!", "alert('Dati non validi')", true);
            return;
        }

        #endregion

        int codiceCommessa = int.Parse(Session["CodiceCommessa"].ToString());
        int codiceClienti = int.Parse(ddlCliente.SelectedValue);
        int codiceAzienda = int.Parse(ddlAzienda.SelectedValue);
        int codiceTipoCommessa = int.Parse(ddlTipoCommessa.SelectedValue);
        string descrizioneCommessa = txtDescrizioneCommessa.Text.ToString();
        decimal importoKm = decimal.Parse(txtImportoKm.Text.Replace(",", "."));
        decimal importoTotale = decimal.Parse(txtImportoTotale.Text.Replace(",", "."));
        decimal importoOrario = decimal.Parse(txtImportoOrario.Text.Replace(",", "."));
        decimal importoMensile = decimal.Parse(txtImportoMensile.Text.Replace(",", "."));
        decimal importoPasti = decimal.Parse(txtImportoPasti.Text.Replace(",", "."));
        decimal importoPernottamenti = decimal.Parse(txtImportoPernottamenti.Text.Replace(",", "."));
        decimal importoTrasferta = decimal.Parse(txtImportoTrasferta.Text.Replace(",", "."));
        string dataInizio = txtDataInizio.Text;
        string dataFine = txtDataFine.Text;

        // modifica
        COMMESSE.AGGIORNADB c = new COMMESSE.AGGIORNADB();
        c.CodiceCommessa = codiceCommessa;
        c.CodiceAzienda = codiceAzienda;
        c.CodiceCliente = codiceClienti;
        c.CodiceTipoCommessa = codiceTipoCommessa;
        c.DescrizioneCommessa = descrizioneCommessa;
        c.ImportoKm = importoKm;
        c.ImportoPasti = importoPasti;
        c.ImportoOrario = importoOrario;
        c.ImportoTotale = importoTotale;
        c.ImportoTrasferta = importoTrasferta;
        c.ImportoMensile = importoMensile;
        c.ImportoPernottamenti = importoPernottamenti;
        c.DataFineCommessa = dataFine;
        c.DataInizioCommessa = dataInizio;
        c.CommessaChiusa = 0;

        if (rdb2.Checked == true)
        {
            c.CommessaChiusa = 1;
        }

        c.UPDATE();

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione!", "alert('Dati inseriti correttamente')", true);

        txtDataFine.Text = "";
        txtDataInizio.Text = "";
        txtImportoKm.Text = "";
        txtImportoMensile.Text= "";
        txtImportoOrario.Text = "";
        txtImportoPasti.Text = "";
        txtImportoPernottamenti.Text = "";
        txtImportoTotale.Text = "";
        txtImportoTrasferta.Text = "";

        Session["CodiceCommessa"] = null;

    }

    protected void CaricaAziende()
    {
        AZIENDE a = new AZIENDE();
        ddlAzienda.DataSource = a.SELECT();
        ddlAzienda.DataTextField = "RagioneSociale";
        ddlAzienda.DataValueField = "CodiceAzienda";
        ddlAzienda.DataBind();
    }

    protected void CaricaClienti()
    {
        CLIENTI c = new CLIENTI();
        ddlCliente.DataSource = c.SELECT();
        ddlCliente.DataTextField = "RagioneSociale";
        ddlCliente.DataValueField = "CodiceCliente";
        ddlCliente.DataBind();
    }

    protected void CaricaTipoCommessa()
    {
        TIPOLOGIECOMMESSE t = new TIPOLOGIECOMMESSE();
        ddlTipoCommessa.DataSource = t.SELECT();
        ddlTipoCommessa.DataTextField = "DescrizioneTipoCommessa";
        ddlTipoCommessa.DataValueField = "CodiceTipoCommessa";
        ddlTipoCommessa.DataBind();
    }

}