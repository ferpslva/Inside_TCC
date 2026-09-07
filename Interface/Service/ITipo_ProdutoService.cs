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
    public interface ITipo_ProdutoService
    {
        Task<Tipo_ProdutoDTO> addAsync(Tipo_ProdutoDTO tipo_Produto);

        Task updateAsync(Tipo_ProdutoDTO tipo_Produto);

        Task removeAsync(int id);

        Task<Tipo_ProdutoDTO?> getAsync(int id);

        Task<IEnumerable<Tipo_ProdutoDTO>> getAllAsync(
            Expression<Func<Tipo_Produto, bool>> expression);
    }
}
