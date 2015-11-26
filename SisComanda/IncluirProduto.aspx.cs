using Controle;
using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SisComanda
{
    public partial class IncluirProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnIncluir_Click(object sender, EventArgs e)
        {
            ProdutoControle ctl = new ProdutoControle();

            Produto p = new Produto();
            p.Nome = ;
            p.Preco =;
            p.Tipo =;
            ctl.inserir(p);
        }
    }
}