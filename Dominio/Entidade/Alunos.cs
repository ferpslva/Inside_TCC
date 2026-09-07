using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidade
{
    public class Alunos : Pessoa
    {
        public bool Status { get; set; }

        public virtual List<Matricula> Matriculas { get; set; }
            = new List<Matricula>();

        public virtual List<Aula_Aluno> Aula_Alunos { get; set; }
            = new List<Aula_Aluno>();
    }
}
