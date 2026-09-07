using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidade
{
    public class Matricula
    {
        public int Id { get; set; }

        public int IdAluno { get; set; }
        public virtual Alunos Aluno { get; set; }

        public DateTime Data { get; set; }

        public bool AulaExperimental { get; set; }

        public decimal ValorAula { get; set; }

        public int IdPlano { get; set; }
        public virtual Plano Plano { get; set; }

        public int IdModalidade { get; set; }
        public virtual Modalidade Modalidade { get; set; }

        public int IdGraduacao { get; set; }
        public virtual Graduacao Graduacao { get; set; }

        public int IdVinculo { get; set; }
        public virtual Vinculo Vinculo { get; set; }

        public bool Status { get; set; }
    }
}
