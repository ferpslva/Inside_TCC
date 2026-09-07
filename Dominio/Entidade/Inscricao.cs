using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidade
{
    public class Inscricao
    {
        public int Id { get; set; }

        public int IdEvento { get; set; }
        public virtual Eventos? Evento { get; set; }

        public int IdPessoa { get; set; }
        public virtual Pessoa? Pessoa { get; set; }

        public bool Pagamento { get; set; }
    }
}
