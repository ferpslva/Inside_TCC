using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Entidade;
using System.Linq.Expressions;

namespace Interface.Repositorio
{
    public interface IGraduacaoRepositorio
    {
        Task<Graduacao> addAsync(Graduacao graduacao);

        Task updateAsync(Graduacao graduacao);

        Task removeAsync(Graduacao graduacao);

        Task<Graduacao?> getAsync(int id);

        Task<IEnumerable<Graduacao>> getAllAsync(
            Expression<Func<Graduacao, bool>> expression);
    }
}