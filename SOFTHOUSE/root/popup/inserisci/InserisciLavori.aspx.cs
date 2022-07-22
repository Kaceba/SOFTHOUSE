using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InserisciLavoriPopUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CaricaCommessa();
            CaricaPersonale();
        }
    }

    protected void btnInserisci_Click(object sender, EventArgs e)
    {

        #region "CONTROLLI FORMALI" 

        //controlli formali
        if (string.IsNullOrEmpty(txtDataLavoro.Text) || string.IsNullOrEmpty(txtOreLavoro.Text) || string.IsNullOrEmpty(txtTrasferta.Text)
            || string.IsNullOrEmpty(txtKm.Text) || string.IsNullOrEmpty(txtPasti.Text) || string.IsNullOrEmpty(txtPernottamenti.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione!", "alert('Dati non validi')", true);
            return;
        }
        if (decimal.TryParse(txtOreLavoro.Text, out decimal oreLavoro1) == false)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione!", "alert('Dati non validi')", true);
            return;
        }
        if (decimal.TryParse(txtTrasferta.Text, out decimal trasferta1) == false)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione!", "alert('Dati non validi')", true);
            return;
        }
        if (int.TryParse(txtKm.Text, out int km1) == false)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione!", "alert('Dati non validi')", true);
            return;
        }
        if (decimal.TryParse(txtPasti.Text, out decimal pasti1) == false)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione!", "alert('Dati non validi')", true);
            return;
        }
        if (decimal.TryParse(txtPernottamenti.Text, out decimal pernottamenti1) == false)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione!", "alert('Dati non validi')", true);
            return;
        }

        #endregion

        //dichiaro variabili
        LAVORI.AGGIORNADB LA = new LAVORI.AGGIORNADB();
        LA.CodicePersonale = int.Parse(ddlPersonale.SelectedValue.ToString());
        LA.CodiceCommessa = int.Parse(ddlCommessa.SelectedValue.ToString());
        LA.DataLavoro = txtDataLavoro.Text.Replace(",", "."); ;
        LA.OreLavoro = oreLavoro1;
        LA.Trasferta = trasferta1;
        LA.Km = km1;
        LA.Pasti = pasti1;
        LA.Pernottamenti = pernottamenti1;

        LA.INSERT();

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati inseriti correttamente.')", true);

        txtDataLavoro.Text = "";
        txtOreLavoro.Text = "";
        txtTrasferta.Text = "";
        txtKm.Text = "";
        txtPasti.Text = "";
        txtPernottamenti.Text = "";
    }

    protected void CaricaCommessa()
    {
        COMMESSE C = new COMMESSE();
        ddlCommessa.DataSource = C.SELECTFORDDL();
        ddlCommessa.DataTextField = "Commessa";
        ddlCommessa.DataValueField = "CodiceCommessa";
        ddlCommessa.DataBind();
    }

    protected void CaricaPersonale()
    {
        PERSONALE P = new PERSONALE();
        ddlPersonale.DataSource = P.SELECTFORDDL();
        ddlPersonale.DataTextField = "Personale";
        ddlPersonale.DataValueField = "CodicePersonale";
        ddlPersonale.DataBind();
    }

}
