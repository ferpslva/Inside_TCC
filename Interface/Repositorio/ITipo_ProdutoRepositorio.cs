using Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Repositorio
{
    public interface ITipo_ProdutoRepositorio
    {
        Task<Tipo_Produto> addAsync(Tipo_Produto tipo_Produto);

        Task updateAsync(Tipo_Produto tipo_Produto);

        Task removeAsync(Tipo_Produto tipo_Produto);

        Task<Tipo_Produto?> getAsync(int id);

        Task<IEnumerable<Tipo_Produto>> getAllAsync(
            Expression<Func<Tipo_Produto, bool>> expression);
    }
}
