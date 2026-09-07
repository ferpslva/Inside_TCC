using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidade
{
    public class Aula
    {
        public int Id { get; set; }

        public string Descricao { get; set; } = string.Empty;

        public int IdModalidade { get; set; }
        public virtual Modalidade? Modalidade { get; set; }

        public DateTime Data { get; set; }

        public DateTime Competencia { get; set; }

        public int IdProfessor { get; set; }
        public virtual Professores? Professor { get; set; }

        public bool Personal { get; set; }

        public virtual List<Aula_Aluno> AulaAlunos { get; set; }
            = new List<Aula_Aluno>();
    }
}
