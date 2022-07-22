using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AggiornaGriglia();
    }
    protected void btnAggiornaGriglia_Click(object sender, EventArgs e)
    {
        AggiornaGriglia();
    }
    protected void griglia_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["CodiceAzienda"] = griglia.SelectedDataKey[0];
    }
    protected void AggiornaGriglia()
    {
        AZIENDE t = new AZIENDE();

        //definisco query
        griglia.DataSource = t.SELECT();
        griglia.DataBind();
    }
}