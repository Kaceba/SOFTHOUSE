using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class root_popup_inserisci_inserisciazienda : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnInserisci_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtCap.Text) || string.IsNullOrEmpty(txtCitta.Text) || string.IsNullOrEmpty(txtIndirizzo.Text) || string.IsNullOrEmpty(txtPartitaIva.Text) || string.IsNullOrEmpty(txtProvincia.Text) || string.IsNullOrEmpty(txtRagioneSociale.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati non inseriti correttamente o assenti.')", true);
            return;
        }

        AZIENDE.AGGIORNADB a = new AZIENDE.AGGIORNADB();
        a.RagioneSociale = txtRagioneSociale.Text;
        a.Cap = txtCap.Text;
        a.Citta = txtCitta.Text;
        a.PartitaIva = txtPartitaIva.Text;
        a.Indirizzo = txtIndirizzo.Text;
        a.Provincia = txtProvincia.Text;

        a.INSERT();

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati inseriti correttamente.')", true);

        txtRagioneSociale.Text = "";
        txtCap.Text = "";
        txtCitta.Text = "";
        txtPartitaIva.Text = "";
        txtIndirizzo.Text = "";
        txtProvincia.Text = "";

    }
}
