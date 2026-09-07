using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidade
{
    public class Saida_Produto
    {
        public int Id { get; set; }

        public int Quantidade { get; set; }

        public int IdProduto { get; set; }
        public virtual Produto? Produto { get; set; }

        public int IdPessoa { get; set; }
        public virtual Pessoa? Pessoa { get; set; }

        public DateTime Data { get; set; }

        public decimal Desconto { get; set; }

        public decimal ValorTotal { get; set; }
    }
}
