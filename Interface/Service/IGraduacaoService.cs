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
    public interface IGraduacaoService
    {
        Task<GraduacaoDTO> addAsync(GraduacaoDTO graduacao);

        Task updateAsync(GraduacaoDTO graduacao);

        Task removeAsync(int id);

        Task<GraduacaoDTO?> getAsync(int id);

        Task<IEnumerable<GraduacaoDTO>> getAllAsync(
            Expression<Func<Graduacao, bool>> expression);
    }
}