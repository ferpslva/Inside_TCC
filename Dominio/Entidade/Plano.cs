using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidade
{
    public class Plano
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public decimal Valor { get; set; }

        public bool Status { get; set; }

        public virtual List<Matricula> Matriculas { get; set; }
            = new List<Matricula>();
    }
}
