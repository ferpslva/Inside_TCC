using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidade
{
    public class Modalidade
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public bool Status { get; set; }

        public int IdProfessor { get; set; }
        public virtual Professores? Professor { get; set; }

        public virtual List<Graduacao> Graduacoes { get; set; }
            = new List<Graduacao>();

        public virtual List<Aula> Aulas { get; set; }
            = new List<Aula>();

        public virtual List<Matricula> Matriculas { get; set; }
            = new List<Matricula>();
    }
}
