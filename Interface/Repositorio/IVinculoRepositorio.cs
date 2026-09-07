using Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Repositorio
{
    public interface IVinculoRepositorio
    {
        Task<Vinculo> addAsync(Vinculo vinculo);

        Task updateAsync(Vinculo vinculo);

        Task removeAsync(Vinculo vinculo);

        Task<Vinculo?> getAsync(int id);

        Task<IEnumerable<Vinculo>> getAllAsync(
            Expression<Func<Vinculo, bool>> expression);
    }
}
