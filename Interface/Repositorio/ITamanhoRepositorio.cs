using Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Repositorio
{
    public interface ITamanhoRepositorio
    {
        Task<Tamanho> addAsync(Tamanho tamanho);

        Task updateAsync(Tamanho tamanho);

        Task removeAsync(Tamanho tamanho);

        Task<Tamanho?> getAsync(int id);

        Task<IEnumerable<Tamanho>> getAllAsync(
            Expression<Func<Tamanho, bool>> expression);
    }
}

