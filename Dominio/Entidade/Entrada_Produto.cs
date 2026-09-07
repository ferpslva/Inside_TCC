using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidade
{
    public class Entrada_Produto
    {
        public int Id { get; set; }

        public int Quantidade { get; set; }

        public int IdProduto { get; set; }
        public virtual Produto? Produto { get; set; }

        public DateTime Data { get; set; } = DateTime.Now;

    }
}
