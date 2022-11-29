using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto_Diogenes
{
    public partial class PageMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuarioId"] != null)
            {
                Entrar.Visible = false;
                Sair.Visible = true;
                MinhaConta.Visible = true;
            }
            else
            {
                Entrar.Visible = true;
                Sair.Visible = false;
                MinhaConta.Visible = false;
            }
        }
    }
}