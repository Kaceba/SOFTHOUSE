using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class root_popup_elimina_EliminaNews : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["CodiceNews"] == null)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ERRORE!", "alert('Seleziona una riga, pirla')", true);
                return;
            }
        }
    }

    protected void btnElimina_Click(object sender, EventArgs e)
    {
        NEWS.AGGIORNADB NA = new NEWS.AGGIORNADB();

        NA.CodiceNews = Convert.ToInt32(Session["CODICENEWS"]);

        NA.ELIMINA();

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "SUCCESSO", "alert('News eliminata con successo')", true);
    }
}