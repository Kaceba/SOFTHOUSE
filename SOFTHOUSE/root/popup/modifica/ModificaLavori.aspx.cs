using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ModificaLavori : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Se non vi è nessun elemento selezionato impedisco il proseguimento
            if (Session["CodiceLavoro"] == null)
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "ATTENZIONE", "alert('Seleziona una riga per poterla modificare')", true);
                return;
            }

            LAVORI L = new LAVORI();
            DataTable dt = L.SELECT(int.Parse(Session["CodiceLavorocd "].ToString()));

            CaricaCommessa();
            CaricaPersonale();

            txtDataLavoro.Text = dt.Rows[0].Field<DateTime>(3).ToString("yyyy-MM-dd");
            txtTrasferta.Text = dt.Rows[0]["Trasferta"].ToString(); ;
            txtKm.Text = dt.Rows[0]["Km"].ToString();
            txtOreLavoro.Text = dt.Rows[0]["OreLavoro"].ToString();
            txtPasti.Text = dt.Rows[0]["Pasti"].ToString();
            txtPernottamenti.Text = dt.Rows[0]["Pernottamenti"].ToString();

        }
    }

    protected void btnModifica_Click(object sender, EventArgs e)
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

        //modifico e assegno variabili
        LAVORI.AGGIORNADB LA = new LAVORI.AGGIORNADB();
        LA.CodiceLavoro = int.Parse(Session["CodiceLavoro"].ToString());
        LA.CodicePersonale = int.Parse(ddlPersonale.SelectedValue.ToString());
        LA.CodiceCommessa = int.Parse(ddlCommessa.SelectedValue.ToString());
        LA.DataLavoro = txtDataLavoro.Text.Replace(",", ".");
        LA.OreLavoro = oreLavoro1;
        LA.Trasferta = trasferta1;
        LA.Km = km1;
        LA.Pasti = pasti1;
        LA.Pernottamenti = pernottamenti1;


        LA.UPDATE();

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione", "alert('Dati modificati correttamente.')", true);

        //pulisco i campi
        txtDataLavoro.Text = "";
        txtOreLavoro.Text = "";
        txtTrasferta.Text = "";
        txtKm.Text = "";
        txtPasti.Text = "";
        txtPernottamenti.Text = "";

        Session["CodiceLavoro"] = null;
    }

    protected void CaricaPersonale()
    {
        PERSONALE P = new PERSONALE();
        ddlPersonale.DataSource = P.SELECTFORDDL();
        ddlPersonale.DataTextField = "Personale";
        ddlPersonale.DataValueField = "CodicePersonale";
        ddlPersonale.DataBind();
    }


    protected void CaricaCommessa()
    {
        COMMESSE C = new COMMESSE();
        ddlCommessa.DataSource = C.SELECTFORDDL();
        ddlCommessa.DataTextField = "Commessa";
        ddlCommessa.DataValueField = "CodiceCommessa";
        ddlCommessa.DataBind();
    }
}