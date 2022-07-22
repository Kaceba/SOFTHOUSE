using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ABILITAUTENTE_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnModifica_Click(object sender, EventArgs e)
    {
       //CONTROLLI FORMALI
        UTENTI u = new UTENTI();
        u.email = txtEmail.Text;
        //u.abilitato = int.Parse(ddlStato.SelectedValue);
        //u.ABILITA();

    }
}