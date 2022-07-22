using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class InserisciSpesePopUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CaricaAziende();
            CaricaTipiSpese();
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

    protected void CaricaTipiSpese()
    {
        TIPOLOGIESPESE T = new TIPOLOGIESPESE();
        ddlTipoSpesa.DataSource = T.SELECT();
        ddlTipoSpesa.DataValueField = "CodiceTipoSpesa";
        ddlTipoSpesa.DataTextField = "DescrizioneTipoSpesa";

        ddlTipoSpesa.DataBind();
    }

    protected void btnInserisci_Click(object sender, EventArgs e)
    {
        //controlli formali
        if (string.IsNullOrEmpty(txtImporto.Text) || string.IsNullOrEmpty(txtDataSpesa.Text))
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione!", "alert('Dati non validi')", true);
            return;
        }

        //serve solo a vedere se l'importo è un decimal
        if (decimal.TryParse(txtImporto.Text, out decimal result) == false)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione!", "alert('Dati non validi')", true);
            return;
        }

        //configuro le variabili da inserire nel database
        int codiceTipoSpesa = int.Parse(ddlTipoSpesa.SelectedValue);
        int codiceAzienda = int.Parse(ddlAzienda.SelectedValue);
        string dataSpesa = txtDataSpesa.Text;

        //controllo prima che il record esista
        SPESE.AGGIORNADB S = new SPESE.AGGIORNADB();
        S.CodiceTipoSpesa = codiceTipoSpesa;
        S.CodiceAzienda = codiceAzienda;
        S.Importo = result;
        S.DataSpesa = dataSpesa;

        S.INSERT();

        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Attenzione!", "alert('Spesa inserita correttamente')", true);

        //ripulisco i campi
        txtImporto.Text = "";
        ddlTipoSpesa.SelectedIndex = 0;
        ddlAzienda.SelectedIndex = 0;
        txtDataSpesa.Text = "";
    }
}