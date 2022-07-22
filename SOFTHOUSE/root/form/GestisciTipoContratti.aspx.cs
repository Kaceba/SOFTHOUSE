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
        CaricaGriglia();
    }

    protected void CaricaGriglia()
    {
        TIPOLOGIECONTRATTI TCon = new TIPOLOGIECONTRATTI();

        griglia.DataSource = TCon.SELECT();
        griglia.DataBind();
    }

    protected void griglia_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["CodiceTipoContratto"] = griglia.SelectedDataKey[0];
    }

    protected void aggiornaGriglia_Click(object sender, EventArgs e)
    {
        CaricaGriglia();
    }
}