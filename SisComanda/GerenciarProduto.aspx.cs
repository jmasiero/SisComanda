using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SisComanda
{
    public partial class GerenciarProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnIncluir_Click(object sender, EventArgs e)
        {
            Response.Redirect("IncluirProduto.aspx");
        }
    }
}