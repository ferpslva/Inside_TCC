using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Entidade;
using System.Linq.Expressions;

namespace Interface.Repositorio
{
    public interface IProdutoRepositorio
    {
        Task<Produto> addAsync(Produto produto);

        Task updateAsync(Produto produto);

        Task removeAsync(Produto produto);

        Task<Produto?> getAsync(int id);

        Task<IEnumerable<Produto>> getAllAsync(
            Expression<Func<Produto, bool>> expression);
    }
}