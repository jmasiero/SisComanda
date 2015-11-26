using Dados;
using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    public class ProdutoControle
    {
        

        public void inserir(Produto p)
        {
            ProdutoDAO.inserir(p);
        }

    }
}
