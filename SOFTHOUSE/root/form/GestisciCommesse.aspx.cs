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
        COMMESSE c = new COMMESSE();
        griglia.DataSource = c.SELECT();
        griglia.DataBind();
    }


    protected void griglia_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["CodiceCommessa"] = griglia.SelectedDataKey[0];
    }

    protected void griglia_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        e.Row.Cells[1].Visible = false;
        e.Row.Cells[2].Visible = false;
        e.Row.Cells[3].Visible = false;
        e.Row.Cells[4].Visible = false;
    }
}