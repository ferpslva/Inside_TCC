using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidade
{
    public class Pagamento_Produto
    {
        public int Id { get; set; }

        public int IdSaidaProduto { get; set; }
        public virtual Saida_Produto Saida_Produto { get; set; }

        public decimal Valor { get; set; }

        public DateTime DataPagamento { get; set; }

        public bool Status { get; set; }

    }
}
