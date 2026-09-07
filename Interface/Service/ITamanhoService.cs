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
    public interface ITamanhoService
    {
        Task<TamanhoDTO> addAsync(TamanhoDTO tamanho);

        Task updateAsync(TamanhoDTO tamanho);

        Task removeAsync(int id);

        Task<TamanhoDTO?> getAsync(int id);

        Task<IEnumerable<TamanhoDTO>> getAllAsync(
            Expression<Func<Tamanho, bool>> expression);
    }
}
