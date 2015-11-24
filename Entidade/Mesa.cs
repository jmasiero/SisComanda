using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Mesa
    {
        public int Numero { get; set; }
        public Garcom Garcom { get; set;}
        public Boolean Ocupado { get; set; }
        public List<Produto> listaCompras;

    }
}
