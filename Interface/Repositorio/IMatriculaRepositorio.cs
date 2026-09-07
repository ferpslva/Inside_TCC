using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Entidade;
using System.Linq.Expressions;

namespace Interface.Repositorio
{
    public interface IMatriculaRepositorio
    {
        Task<Matricula> addAsync(Matricula matricula);

        Task updateAsync(Matricula matricula);

        Task removeAsync(Matricula matricula);

        Task<Matricula?> getAsync(int id);

        Task<IEnumerable<Matricula>> getAllAsync(
            Expression<Func<Matricula, bool>> expression);
    }
}