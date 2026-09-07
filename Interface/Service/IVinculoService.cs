using Dominio.DTOs;
using Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Service
{
    public interface IVinculoService
    {
        Task<VinculoDTO> addAsync(VinculoDTO vinculo);

        Task updateAsync(VinculoDTO vinculo);

        Task removeAsync(int id);

        Task<VinculoDTO?> getAsync(int id);

        Task<IEnumerable<VinculoDTO>> getAllAsync(
            Expression<Func<Vinculo, bool>> expression);
    }
}
