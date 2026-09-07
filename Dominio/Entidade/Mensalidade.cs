using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidade
{
    public class Mensalidade
    {
        public int Id { get; set; }

        public int IdMatricula { get; set; }
        public virtual Matricula Matricula { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public DateTime Vencimento { get; set; }

        public decimal Valor { get; set; }

        public decimal ValorTotal { get; set; }

        public virtual List<Pagamento_Mensalidade> Pagamentos { get; set; }
            = new List<Pagamento_Mensalidade>();
    }
}
