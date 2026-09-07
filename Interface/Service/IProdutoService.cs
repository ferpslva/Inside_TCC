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
    public interface IProdutoService
    {
        Task<ProdutoDTO> addAsync(ProdutoDTO produto);

        Task updateAsync(ProdutoDTO produto);

        Task removeAsync(int id);

        Task<ProdutoDTO?> getAsync(int id);

        Task<IEnumerable<ProdutoDTO>> getAllAsync(
            Expression<Func<Produto, bool>> expression);
    }
}