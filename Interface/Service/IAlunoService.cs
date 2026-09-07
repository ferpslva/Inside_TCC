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
    public interface IAlunoService
    {
        Task<AlunoDTO> addAsync(AlunoDTO aluno);

        Task updateAsync(AlunoDTO aluno);

        Task removeAsync(int id);

        Task<AlunoDTO?> getAsync(int id);

        Task<IEnumerable<AlunoDTO>> getAllAsync(
            Expression<Func<Alunos, bool>> expression);
    }
}