using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InserisciCommesse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CaricaAziende();
            CaricaClienti();
            CaricaTipoCommessa();
        }
    }



    protected void btnInserisci_Click(object sender, EventArgs e)
    {
        //dichiaro variabili

        #region "CONTROLLI FORMALI"

        //CommessaChiusa();
        //controlli formali
        if (string.IsNullOrEmpty(txtDataInizio.Text) || string.IsNullOrEmpty(txtDataFine.Text) || string.IsNullOrEmpty(txtImportoKm.Text) || string.IsNullOrEmpty(txtImportoMensile.Text)
             || string.IsNullOrEmpty(txtImportoOrario.Text) || string.IsNullOrEmpty(txtImportoPasti.Text) || string.IsNullOrEmpty(txtImportoPernottamenti.Text) || string.IsNullOrEmpty(txtImportoTotale.Text)
             || string.IsNullOrEmpty(txtImportoTrasferta.Text) || string.IsNullOrEmpty(txtDescrizioneCommessa.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione!", "alert('Dati non validi')", true);
            return;
        }

        #endregion

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

        //inserisco
        COMMESSE.AGGIORNADB c = new COMMESSE.AGGIORNADB();
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

        c.INSERT();

        //pulisco i campi
        txtDataFine.Text = "";
        txtDataInizio.Text = "";
        txtImportoKm.Text = "";
        txtImportoMensile.Text = "";
        txtImportoOrario.Text = "";
        txtImportoPasti.Text = "";
        txtImportoPernottamenti.Text = "";
        txtImportoTotale.Text = "";
        txtImportoTrasferta.Text = "";

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "SUCCESSO", "alert('Tipo commessa inserito')", true);

    }

    protected void CaricaAziende()
    {
        AZIENDE a = new AZIENDE();
        ddlAzienda.DataSource = a.SELECTFORDDL();
        ddlAzienda.DataTextField = "RagioneSociale";
        ddlAzienda.DataValueField = "CodiceAzienda";
        ddlAzienda.DataBind();
    }

    protected void CaricaClienti()
    {
        CLIENTI c = new CLIENTI();
        ddlCliente.DataSource = c.SELECTFORDDL();
        ddlCliente.DataTextField = "RagioneSociale";
        ddlCliente.DataValueField = "CodiceCliente";
        ddlCliente.DataBind();
    }

    protected void CaricaTipoCommessa()
    {
        TIPOLOGIECOMMESSE t = new TIPOLOGIECOMMESSE();
        ddlTipoCommessa.DataSource = t.SELECTFORDDL();
        ddlTipoCommessa.DataTextField = "DescrizioneTipoCommessa";
        ddlTipoCommessa.DataValueField = "CodiceTipoCommessa";
        ddlTipoCommessa.DataBind();
    }

    //protected void CommessaChiusa()
    //{
    //    RadioButton rdb1 = new RadioButton();
    //    rdb1.Text = "chiusa";
    //    rdb1.Checked = true;

    //    this.Controls.Add(rdb1);

    //    RadioButton rdb2 = new RadioButton();
    //    rdb2.Text = "aperta";
    //    rdb2.Checked = false;

    //    this.Controls.Add(rdb2);
    //}

}
