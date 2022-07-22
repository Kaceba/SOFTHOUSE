using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class root_popup_modifica_ModificaTipoContratto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Se non vi è nessun elemento selezionato impedisco il proseguimento
            if (Session["CodiceTipoContratto"] == null)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Seleziona una riga per poterla modificare')", true);
                return;
            }

            TIPOLOGIECONTRATTI TCon = new TIPOLOGIECONTRATTI();
            DataTable dt = TCon.SELECT(int.Parse(Session["CodiceTipoContratto"].ToString()));

            txtTipoContratto.Text = dt.Rows[0]["DescrizioneTipoContratto"].ToString();
        }
    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtTipoContratto.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ERRORE", "alert('Campo inserito vuoto')", true);
            return;
        }

        TIPOLOGIECONTRATTI.AGGIORNADB TConA = new TIPOLOGIECONTRATTI.AGGIORNADB();
        TIPOLOGIECONTRATTI TCon = new TIPOLOGIECONTRATTI();

        TConA.CodiceTipoContratto = int.Parse(Session["CodiceTipoContratto"].ToString());
        TConA.DescrizioneTipoContratto = txtTipoContratto.Text.Trim().ToString();

        if (TCon.CHECKONE(TConA.DescrizioneTipoContratto.ToString()) == true)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ERRORE", "alert('Nessuna modifica effettuata')", true);
            return;
        }

        TConA.UPDATE();

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "SUCCESSO", "alert('Tipo Commessa cambiata')", true);

        txtTipoContratto.Text = "";

        Session["CodiceTipoContratto"] = null;
    }
}