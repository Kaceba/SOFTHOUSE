using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ModificaTipiSpesePopUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Se non vi è nessun elemento selezionato impedisco il proseguimento
            if (Session["CodiceTipoSpesa"] == null)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Seleziona una riga per poterla modificare')", true);
                return;
            }

            TIPOLOGIESPESE TSpe = new TIPOLOGIESPESE();
            DataTable dt = TSpe.SELECT(int.Parse(Session["CodiceTipoSpesa"].ToString()));

            txtTipoSpesa.Text = dt.Rows[0]["DescrizioneTipoSpesa"].ToString();
        }
    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtTipoSpesa.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ERRORE", "alert('Campo inserito vuoto')", true);
            return;
        }

        TIPOLOGIESPESE.AGGIORNADB TSpeA = new TIPOLOGIESPESE.AGGIORNADB();
        TIPOLOGIECOMMESSE TSpe = new TIPOLOGIECOMMESSE();

        TSpeA.CodiceTipoSpese = int.Parse(Session["CodiceTipoSpesa"].ToString());
        TSpeA.DescrizioneTipoSpese = txtTipoSpesa.Text.Trim().ToString();

        if (TSpe.CHECKONE(TSpeA.DescrizioneTipoSpese.ToString()) == true)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "ERRORE", "alert('Nessuna modifica effettuata')", true);
            return;
        }

        TSpeA.UPDATE();

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "SUCCESSO", "alert('Tipo Spesa cambiata')", true);

        txtTipoSpesa.Text = "";

        Session["CodiceTipoSpesa"] = null;
    }
}