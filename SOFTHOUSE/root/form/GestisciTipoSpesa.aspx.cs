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

    protected void btnRicarica_Click(object sender, EventArgs e)
    {
        CaricaGriglia();
    }

    protected void CaricaGriglia()
    {
        TIPOLOGIESPESE T = new TIPOLOGIESPESE();

        griglia.DataSource = T.SELECT();
        griglia.DataBind();
    }

    protected void griglia_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["CodiceTipoSpesa"] = griglia.SelectedDataKey[0];
    }
}