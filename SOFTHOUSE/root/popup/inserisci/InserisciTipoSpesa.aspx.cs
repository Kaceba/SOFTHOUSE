using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class root_popup_inserisci_InserisciTipoSpesa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnInvia_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtTipoSpesa.Text.Trim()))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ERRORE", "alert('Campo vuoto')", true);
            return;
        }

        TIPOLOGIESPESE.AGGIORNADB TSpeA= new TIPOLOGIESPESE.AGGIORNADB();
        TIPOLOGIECOMMESSE TSpe = new TIPOLOGIECOMMESSE();

        TSpeA.DescrizioneTipoSpese = txtTipoSpesa.Text.ToString();

        if (TSpe.CHECKONE(TSpeA.DescrizioneTipoSpese) == true)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ERRORE", "alert('Qusto tipo spesa esiste già')", true);
            return;
        }

        // se non esiste faccio insert
        TSpeA.INSERT();

        // Svuoto i campi  e aggiorno la griglia
        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "SUCCESSO", "alert('Tipo spesa inserito')", true);

        txtTipoSpesa.Text = "";
    }
}