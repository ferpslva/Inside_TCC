using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.DTOs;
using Dominio.Entidade;
using System.Linq.Expressions;

namespace Interface.Service
{
    public interface IPlanoService
    {
        Task<PlanoDTO> addAsync(PlanoDTO plano);

        Task updateAsync(PlanoDTO plano);

        Task removeAsync(int id);

        Task<PlanoDTO?> getAsync(int id);

        Task<IEnumerable<PlanoDTO>> getAllAsync(
            Expression<Func<Plano, bool>> expression);
    }
}