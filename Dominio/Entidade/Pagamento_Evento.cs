using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidade
{
    public class Pagamento_Evento
    {
        public int Id { get; set; }

        public int IdInscricao { get; set; }
        public virtual Inscricao Inscricao { get; set; }

        public decimal Valor { get; set; }

        public DateTime DataPagamento { get; set; }

        public bool Status { get; set; }
    }
}
