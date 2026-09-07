using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidade
{
    public class Tipo_Produto
    {
        public int Id { get; set; }

        public string Descricao { get; set; } = string.Empty;

        public bool Status { get; set; }

        public virtual List<Produto> Produtos { get; set; }
            = new List<Produto>();
    }
}
