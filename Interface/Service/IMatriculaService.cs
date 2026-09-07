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
    public interface IMatriculaService
    {
        Task<MatriculaDTO> addAsync(MatriculaDTO matricula);

        Task updateAsync(MatriculaDTO matricula);

        Task removeAsync(int id);

        Task<MatriculaDTO?> getAsync(int id);

        Task<IEnumerable<MatriculaDTO>> getAllAsync(
            Expression<Func<Matricula, bool>> expression);
    }
}