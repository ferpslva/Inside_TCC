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
    public interface IProfessorService
    {
        Task<ProfessorDTO> addAsync(ProfessorDTO professor);

        Task updateAsync(ProfessorDTO professor);

        Task removeAsync(int id);

        Task<ProfessorDTO?> getAsync(int id);

        Task<IEnumerable<ProfessorDTO>> getAllAsync(
            Expression<Func<Professores, bool>> expression);
    }
}