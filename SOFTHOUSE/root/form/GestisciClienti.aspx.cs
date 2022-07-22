﻿using System;
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
        CLIENTI C = new CLIENTI();

        griglia.DataSource = C.SELECT();
        griglia.DataBind();
    }
    protected void aggiornaGriglia_Click(object sender, EventArgs e)
    {
        CaricaGriglia();
    }
    protected void griglia_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["CodiceCliente"] = griglia.SelectedDataKey[0];
    }
}