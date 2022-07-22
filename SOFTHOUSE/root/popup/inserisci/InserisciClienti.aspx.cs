using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InserisciClienti : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void btnInvia_Click(object sender, EventArgs e)
    {
        #region "CONTROLLI FORMALI"

        if (string.IsNullOrEmpty(txtRagioneSociale.Text.Trim()))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ERRORE", "alert('Ragione sociale vuota')", true);
            return;
        }
        if (string.IsNullOrEmpty(txtPartitaIva.Text.Trim()))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ERROE", "alert('P.IVA Mancante')", true);
            return;
        }
        if (string.IsNullOrEmpty(txtCodiceFiscale.Text.Trim()))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ERRORE", "alert('Codice Fiscale mancante')", true);
            return;
        }
        if (string.IsNullOrEmpty(txtIndirizzo.Text.Trim()))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ERRORE", "alert('Indirizzo mancante')", true);
            return;
        }
        if (string.IsNullOrEmpty(txtCap.Text.Trim()))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ERRORE", "alert('CAP mancante')", true);
            return;
        }
        if (string.IsNullOrEmpty(txtCitta.Text.Trim()))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ERRORE", "alert('Città mancante')", true);
            return;
        }
        if (string.IsNullOrEmpty(txtProvincia.Text.Trim()))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ERRORE", "alert('Provincia mancante')", true);
            return;
        }

        #endregion

        #region "CONTROLLI LUNGHEZZE CAMPI"

        if (txtPartitaIva.Text.Length > 11)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ERRORE", "alert('Partita IVA troppo lunga')", true);
            return;
        }

        if (txtCodiceFiscale.Text.Length > 16)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ERRORE", "alert('Codice Fiscale troppo lungo')", true);
            return;
        }

        if (txtCap.Text.Length > 5)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ERRORE", "alert('Cap troppo lungo')", true);
            return;
        }

        if (txtProvincia.Text.Length > 2)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ERRORE", "alert('Provincia')", true);
            return;
        }

        #endregion

        CLIENTI.AGGIORNADB CA = new CLIENTI.AGGIORNADB();
        CLIENTI C = new CLIENTI();

        CA.RagioneSociale = txtRagioneSociale.Text.Trim();
        CA.PartitaIva = txtPartitaIva.Text.Trim();
        CA.CodiceFiscale = txtCodiceFiscale.Text.Trim();
        CA.Indirizzo = txtIndirizzo.Text.Trim();
        CA.Cap = txtCap.Text.Trim();
        CA.Citta = txtCitta.Text.Trim();
        CA.Provincia = txtProvincia.Text.Trim();

        if (CA.CHECKONE() == true)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ERRORE", "alert('Questo cliente esiste già')", true);
            return;
        }

        // se non esiste faccio insert
        CA.INSERT();

        // Svuoto i campi  e aggiorno la griglia
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "SUCCESSO", "alert('Cliente Inserito')", true);

        txtRagioneSociale.Text = "";
        txtPartitaIva.Text = "";
        txtCodiceFiscale.Text = "";
        txtIndirizzo.Text = "";
        txtCap.Text = "";
        txtCitta.Text = "";
        txtProvincia.Text = "";
    }
}