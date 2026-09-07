using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Entidade;
using System.Linq.Expressions;

namespace Interface.Repositorio
{
    public interface IPlanoRepositorio
    {
        Task<Plano> addAsync(Plano plano);

        Task updateAsync(Plano plano);

        Task removeAsync(Plano plano);

        Task<Plano?> getAsync(int id);

        Task<IEnumerable<Plano>> getAllAsync(
            Expression<Func<Plano, bool>> expression);
    }
}