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
        Session["CodiceNews"] = griglia.SelectedDataKey[0];
    }

    protected void AggiornaGriglia()
    {
        NEWS N = new NEWS();

        //definisco query
        griglia.DataSource = N.SELECT();
        griglia.DataBind();
    }

}
