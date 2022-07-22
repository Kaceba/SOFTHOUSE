using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ModificaClienti : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Se non vi è nessun elemento selezionato impedisco il proseguimento
            if (Session["CodiceCliente"] == null)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Seleziona una riga per poterla modificare')", true);
                return;
            }

            CLIENTI C = new CLIENTI();
            DataTable dt = C.SELECT(int.Parse(Session["CodiceCliente"].ToString()));

            txtRagioneSociale.Text = dt.Rows[0]["RagioneSociale"].ToString();
            txtPartitaIva.Text = dt.Rows[0]["PartitaIva"].ToString();
            txtCodiceFiscale.Text = dt.Rows[0]["CodiceFiscale"].ToString();
            txtIndirizzo.Text = dt.Rows[0]["Indirizzo"].ToString();
            txtCap.Text = dt.Rows[0]["Cap"].ToString();
            txtCitta.Text = dt.Rows[0]["Citta"].ToString();
            txtProvincia.Text = dt.Rows[0]["Provincia"].ToString();
        }
    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtRagioneSociale.Text) ||
            string.IsNullOrEmpty(txtPartitaIva.Text) ||
            string.IsNullOrEmpty(txtCodiceFiscale.Text) ||
            string.IsNullOrEmpty(txtIndirizzo.Text) ||
            string.IsNullOrEmpty(txtCap.Text) ||
            string.IsNullOrEmpty(txtCitta.Text) ||
            string.IsNullOrEmpty(txtProvincia.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ERRORE", "alert('Almeno un campo vuoto')", true);
            return;
        }

        CLIENTI.AGGIORNADB CA = new CLIENTI.AGGIORNADB();

        CA.CodiceCliente = int.Parse(Session["CodiceCliente"].ToString());
        CA.RagioneSociale = txtRagioneSociale.Text;
        CA.PartitaIva = txtPartitaIva.Text;
        CA.CodiceFiscale = txtCodiceFiscale.Text;
        CA.Indirizzo = txtIndirizzo.Text;
        CA.Cap = txtCap.Text;
        CA.Citta = txtCitta.Text;
        CA.Provincia = txtProvincia.Text;

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

        if(txtCap.Text.Length > 5)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ERRORE", "alert('Cap troppo lungo')", true);
            return;
        }

        if(txtProvincia.Text.Length > 2)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ERRORE", "alert('Provincia')", true);
            return;
        }

        #endregion

        if (CA.CHECKONE() == true)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ERRORE", "alert('Nessuna modifica effettuata')", true);
            return;
        }

        CA.UPDATE();

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "SUCCESSO", "alert('Informazioni cliente cambiate')", true);

        txtRagioneSociale.Text = "";
        txtPartitaIva.Text = "";
        txtCodiceFiscale.Text = "";
        txtIndirizzo.Text = "";
        txtCap.Text = "";
        txtCitta.Text = "";
        txtProvincia.Text = "";

        Session["CodiceCliente"] = null;
    }
}
