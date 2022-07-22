using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EliminaSpesePopUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["CodiceSpesa"] == null)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ERRORE!", "alert('Seleziona una riga, pirla')", true);
                return;
            }
        }
    }

    protected void btnElimina_Click(object sender, EventArgs e)
    {
        SPESE.AGGIORNADB SA = new SPESE.AGGIORNADB();

        SA.CodiceSpesa = int.Parse(Session["CodiceSpesa"].ToString());

        SA.DELETE();

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "SUCCESSO", "alert('Spesa eliminata con successo')", true);

    }
}