using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class root_popup_modifica_modificanews : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Se non vi è nessun elemento selezionato impedisco il proseguimento
            if (Session["CodiceNews"] == null)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Seleziona una riga per poterla modificare')", true);
                return;
            }

            NEWS N = new NEWS();
            DataTable dt = N.SELECT(int.Parse(Session["CodiceNews"].ToString()));

            CaricaAzienda();

            ddlAzienda.SelectedValue = dt.Rows[0]["CodiceAzienda"].ToString();
            txtDataNews.Text = dt.Rows[0].Field<DateTime>(2).ToString("yyyy-MM-dd");
            txtTitolo.Text = dt.Rows[0]["Titolo"].ToString();
            txtNews.Text = dt.Rows[0]["News"].ToString();
        }
    }

    protected void CaricaAzienda()
    {
        AZIENDE A = new AZIENDE();
        ddlAzienda.DataSource = A.SELECT();
        ddlAzienda.DataTextField = "RagioneSociale";
        ddlAzienda.DataValueField = "CodiceAzienda";
        ddlAzienda.DataBind();
    }

    protected void btnInserisci_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtDataNews.Text) || string.IsNullOrEmpty(txtTitolo.Text) || string.IsNullOrEmpty(txtNews.Text) || ddlAzienda.SelectedValue == null)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati non inseriti correttamente o assenti.')", true);
            return;
        }

        NEWS.AGGIORNADB NA = new NEWS.AGGIORNADB();

        NA.CodiceNews = Convert.ToInt32(Session["CodiceNews"]);
        NA.CodiceAzienda = Convert.ToInt32(ddlAzienda.SelectedValue);
        NA.DataNews = Convert.ToDateTime(txtDataNews.Text);
        NA.Titolo = txtTitolo.Text;
        NA.News = txtNews.Text;

        NA.UPDATE();

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati modificati correttamente')", true);
        return;
    }
}