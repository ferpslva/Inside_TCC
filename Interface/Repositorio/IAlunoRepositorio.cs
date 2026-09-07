using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidade;

namespace Interface.Repositorio
{
    public interface IAlunoRepositorio
    {
        Task<Alunos> addAsync(Alunos aluno);

        Task updateAsync(Alunos aluno);

        Task removeAsync(Alunos aluno);

        Task<Alunos?> getAsync(int id);

        Task<IEnumerable<Alunos>> getAllAsync(
            Expression<Func<Alunos, bool>> expression);
    }
}