using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidade
{
    public class Aula_Aluno
    {
        public int Id { get; set; }

        public int IdAluno { get; set; }
        public virtual Alunos? Aluno { get; set; }

        public int IdAula { get; set; }
        public virtual Aula? Aula { get; set; }

        public bool Acesso { get; set; }
    }
}
