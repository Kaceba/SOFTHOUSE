using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ModificaSpesePopUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Se non vi è nessun elemento selezionato impedisco il proseguimento
            if (Session["CodiceSpesa"] == null)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Seleziona una riga per poterla modificare')", true);
                return;
            }

            SPESE S = new SPESE();
            DataTable dt = S.SELECT(int.Parse(Session["CodiceSpesa"].ToString()));

            CaricaAziende();
            ddlAzienda.SelectedValue = dt.Rows[0]["CodiceAzienda"].ToString();

            CaricaTipoSpese();
            ddlTipoSpesa.SelectedValue = dt.Rows[0]["CodiceTipoSpesa"].ToString();

            txtImporto.Text = dt.Rows[0]["Importo"].ToString();
            txtDataSpesa.Text = dt.Rows[0].Field<DateTime>(4).ToString("yyyy-MM-dd");
        }
    }

    protected void CaricaAziende()
    {
        AZIENDE a = new AZIENDE();
        ddlAzienda.DataSource = a.SELECTFORDDL();
        ddlAzienda.DataValueField = "CodiceAzienda";
        ddlAzienda.DataTextField = "RagioneSociale";
        ddlAzienda.DataBind();
    }

    protected void CaricaTipoSpese()
    {
        TIPOLOGIESPESE t = new TIPOLOGIESPESE();
        ddlTipoSpesa.DataSource = t.SELECT();
        ddlTipoSpesa.DataTextField = "DescrizioneTipoSpesa";
        ddlTipoSpesa.DataValueField = "CodiceTipoSpesa";
        ddlTipoSpesa.DataBind();
    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {

        #region "CONTROLLI FORMALI"

        //controllo che la riga sia stata selezionata
        if (string.IsNullOrEmpty(Session["CodiceSpesa"].ToString()))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione!", "alert('Nessun campo selezionato')", true);
            return;
        }

        //controllo che il campo non sia vuoto
        if (string.IsNullOrEmpty(txtImporto.Text) || string.IsNullOrEmpty(txtDataSpesa.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione!", "alert('Dati non validi')", true);
            return;
        }

        //controllo che tutti i dati siano validi
        if (!decimal.TryParse(txtImporto.Text, out decimal importo2))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione!", "alert('Dati non validi')", true);
            return;
        }

        #endregion

        //dichiarazioni variabili e instaziamento classe

        SPESE.AGGIORNADB SA = new SPESE.AGGIORNADB();
        SA.CodiceSpesa = int.Parse(Session["CodiceSpesa"].ToString());
        SA.CodiceTipoSpesa = int.Parse(ddlTipoSpesa.SelectedValue);
        SA.CodiceAzienda = int.Parse(ddlAzienda.SelectedValue);
        SA.DataSpesa = txtDataSpesa.Text;
        SA.Importo = decimal.Parse(txtImporto.Text.Trim().Replace(",", "."));

        //operazioni di aggiornamento
        SA.UPDATE();

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione!", "alert('Dati modifica correttamente')", true);

        txtImporto.Text = "";
        txtDataSpesa.Text = "";

        Session["CodiceSpesa"] = null;

    }
}
