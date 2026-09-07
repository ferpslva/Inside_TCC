using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidade
{
    public class Professores:Pessoa
    {
        public bool Status { get; set; }

        public string Senha { get; set; } = string.Empty;

        public virtual List<Modalidade> Modalidades { get; set; }
            = new List<Modalidade>();
    }
}
