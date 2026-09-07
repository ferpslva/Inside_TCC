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
    public interface IModalidadeService
    {
        Task<ModalidadeDTO> addAsync(ModalidadeDTO modalidade);

        Task updateAsync(ModalidadeDTO modalidade);

        Task removeAsync(int id);

        Task<ModalidadeDTO?> getAsync(int id);

        Task<IEnumerable<ModalidadeDTO>> getAllAsync(
            Expression<Func<Modalidade, bool>> expression);
    }
}