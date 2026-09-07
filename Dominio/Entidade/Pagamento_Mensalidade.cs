using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidade
{
    public class Pagamento_Mensalidade
    {
        public int Id { get; set; }

        public int IdMensalidade { get; set; }
        public virtual Mensalidade Mensalidade { get; set; }

        public decimal Valor { get; set; }

        public DateTime DataPagamento { get; set; }

        public bool Status { get; set; }

    }
}
