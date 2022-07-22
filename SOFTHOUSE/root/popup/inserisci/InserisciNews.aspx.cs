using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class root_popup_inserisci_inseriscinews : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CaricaAziende();
        }
    }

    protected void CaricaAziende()
    {
        AZIENDE A = new AZIENDE();
        ddlAzienda.DataSource = A.SELECTFORDDL();
        ddlAzienda.DataValueField = "CodiceAzienda";
        ddlAzienda.DataTextField = "RagioneSociale";
        ddlAzienda.DataBind();
    }

    protected void btnInserisci_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtData.Text) || string.IsNullOrEmpty(txtNews.Text) || string.IsNullOrEmpty(txtTitolo.Text) || ddlAzienda.SelectedValue == null)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati non inseriti correttamente o assenti.')", true);
            return;
        }

        NEWS.AGGIORNADB NA = new NEWS.AGGIORNADB();

        NA.Titolo = txtTitolo.Text;
        NA.DataNews = Convert.ToDateTime(txtData.Text);
        NA.CodiceAzienda = Convert.ToInt32(ddlAzienda.SelectedValue);
        NA.News = txtNews.Text;

        NA.INSERT();

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati inseriti correttamente')", true);
        return;
    }

}
