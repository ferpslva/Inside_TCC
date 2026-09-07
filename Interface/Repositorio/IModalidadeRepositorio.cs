using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Entidade;
using System.Linq.Expressions;

namespace Interface.Repositorio
{
    public interface IModalidadeRepositorio
    {
        Task<Modalidade> addAsync(Modalidade modalidade);

        Task updateAsync(Modalidade modalidade);

        Task removeAsync(Modalidade modalidade);

        Task<Modalidade?> getAsync(int id);

        Task<IEnumerable<Modalidade>> getAllAsync(
            Expression<Func<Modalidade, bool>> expression);
    }
}