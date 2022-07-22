using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class root_popup_modifica_modificaazienda : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Se non vi è nessun elemento selezionato impedisco il proseguimento
            if (Session["CodiceAzienda"] == null)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Seleziona una riga per poterla modificare')", true);
                return;
            }

            AZIENDE A = new AZIENDE();
            DataTable dt = A.SELECT(int.Parse(Session["CodiceAzienda"].ToString()));

            txtRagioneSociale.Text = dt.Rows[0]["RagioneSociale"].ToString();
            txtPartitaIva.Text = dt.Rows[0]["PartitaIva"].ToString();
            txtIndirizzo.Text = dt.Rows[0]["Indirizzo"].ToString();
            txtCitta.Text = dt.Rows[0]["Citta"].ToString();
            txtCap.Text = dt.Rows[0]["Cap"].ToString();
            txtProvincia.Text = dt.Rows[0]["Provincia"].ToString();
        }
    }

    protected void BtnInserisci_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtCap.Text) || string.IsNullOrEmpty(txtCitta.Text) || string.IsNullOrEmpty(txtIndirizzo.Text) || string.IsNullOrEmpty(txtPartitaIva.Text) || string.IsNullOrEmpty(txtProvincia.Text) || string.IsNullOrEmpty(txtRagioneSociale.Text) || txtPartitaIva.Text.Length<11)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati non modificati correttamente o assenti.')", true);
            return;
        }

        AZIENDE.AGGIORNADB a = new AZIENDE.AGGIORNADB();
        a.CodiceAzienda = Convert.ToInt32(Session["CodiceAzienda"]);
        a.RagioneSociale = txtRagioneSociale.Text;
        a.Cap = txtCap.Text;
        a.Citta = txtCitta.Text;
        a.PartitaIva = txtPartitaIva.Text;
        a.Indirizzo = txtIndirizzo.Text;
        a.Provincia = txtProvincia.Text;

        a.UPDATE();

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati modificati correttamente.')", true);
    }
}
