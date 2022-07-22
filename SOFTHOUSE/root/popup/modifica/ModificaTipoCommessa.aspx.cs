using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ModificaTipiCommesse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Se non vi è nessun elemento selezionato impedisco il proseguimento
            if (Session["CodiceTipoCommessa"] == null)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Seleziona una riga per poterla modificare')", true);
                return;
            }

            TIPOLOGIECOMMESSE TCom = new TIPOLOGIECOMMESSE();
            DataTable dt = TCom.SELECT(int.Parse(Session["CodiceTipoCommessa"].ToString()));

            txtTipoCommessa.Text = dt.Rows[0]["DescrizioneTipoCommessa"].ToString();
        }
    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtTipoCommessa.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ERRORE", "alert('Campo inserito vuoto')", true);
            return;
        }

        TIPOLOGIECOMMESSE.AGGIORNADB TComA = new TIPOLOGIECOMMESSE.AGGIORNADB();
        TIPOLOGIECOMMESSE TCom = new TIPOLOGIECOMMESSE();

        TComA.CodiceTipoCommessa = int.Parse(Session["CodiceTipoCommessa"].ToString());
        TComA.DescrizioneTipoCommessa = txtTipoCommessa.Text.Trim().ToString();

        if (TCom.CHECKONE(TComA.DescrizioneTipoCommessa.ToString()) == true)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ERRORE", "alert('Nessuna modifica effettuata')", true);
            return;
        }

        TComA.UPDATE();

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "SUCCESSO", "alert('Tipo Commessa cambiata')", true);

        txtTipoCommessa.Text = "";

        Session["CodiceTipoCommessa"] = null;
    }
}
