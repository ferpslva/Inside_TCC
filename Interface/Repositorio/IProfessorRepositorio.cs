using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidade;

namespace Interface.Repositorio
{
    public interface IProfessorRepositorio
    {
        Task<Professores> addAsync(Professores professores);

        Task updateAsync(Professores professores);

        Task removeAsync(Professores professores);

        Task<Professores?> getAsync(int id);

        Task<IEnumerable<Professores>> getAllAsync(
            Expression<Func<Professores, bool>> expression);
    }
}
