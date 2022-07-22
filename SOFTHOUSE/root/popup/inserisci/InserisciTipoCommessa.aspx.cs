using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InserisciTipiCommesse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInvia_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtTipoCommessa.Text.Trim()))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ERRORE", "alert('Campo vuoto')", true);
            return;
        }

        TIPOLOGIECOMMESSE.AGGIORNADB TComA = new TIPOLOGIECOMMESSE.AGGIORNADB();
        TIPOLOGIECOMMESSE TCom = new TIPOLOGIECOMMESSE();

        TComA.DescrizioneTipoCommessa = txtTipoCommessa.Text.ToString();

        if (TCom.CHECKONE(TComA.DescrizioneTipoCommessa) == true)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ERRORE", "alert('Qusto tipo commessa esiste già')", true);
            return;
        }

        // se non esiste faccio insert
        TComA.INSERT();

        // Svuoto i campi  e aggiorno la griglia
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "SUCCESSO", "alert('Tipo commessa inserito')", true);

        txtTipoCommessa.Text = "";
    }
}
