using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class root_popup_inserisci_InserisciTipoContratto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInvia_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtTipoContratto.Text.Trim()))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ERRORE", "alert('Campo vuoto')", true);
            return;
        }

        TIPOLOGIECONTRATTI.AGGIORNADB TConA = new TIPOLOGIECONTRATTI.AGGIORNADB();
        TIPOLOGIECONTRATTI TCon = new TIPOLOGIECONTRATTI();

        TConA.DescrizioneTipoContratto = txtTipoContratto.Text.ToString();

        if (TCon.CHECKONE(TConA.DescrizioneTipoContratto) == true)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ERRORE", "alert('Questo tipo di contratto esiste già')", true);
            return;
        }

        // se non esiste faccio insert
        TConA.INSERT();

        // Svuoto i campi  e aggiorno la griglia
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "SUCCESSO", "alert('Tipo contratto inserito')", true);

        txtTipoContratto.Text = "";
    }
}