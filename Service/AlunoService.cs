using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Dominio.DTOs;
using Dominio.Entidade;
using Interface.Repositorio;
using Interface.Service;

namespace Service
{
    public class AlunoService : IAlunoService
    {
        private IAlunoRepositorio repositorio;

        private IMapper mapper;

        public AlunoService(
            IAlunoRepositorio repositorio,
            IMapper mapper)
        {
            this.repositorio = repositorio;
            this.mapper = mapper;
        }

        public async Task<AlunoDTO> addAsync(AlunoDTO aluno)
        {
            var entidade = mapper.Map<Alunos>(aluno);

            entidade = await repositorio.addAsync(entidade);

            return mapper.Map<AlunoDTO>(entidade);
        }

        public async Task<IEnumerable<AlunoDTO>> getAllAsync(
            Expression<Func<Alunos, bool>> expression)
        {
            var lista = await repositorio.getAllAsync(expression);

            return mapper.Map<IEnumerable<AlunoDTO>>(lista);
        }

        public async Task<AlunoDTO?> getAsync(int id)
        {
            var aluno = await repositorio.getAsync(id);

            return mapper.Map<AlunoDTO>(aluno);
        }

        public async Task removeAsync(int id)
        {
            var aluno = await repositorio.getAsync(id);

            if (aluno != null)
            {
                await repositorio.removeAsync(aluno);
            }
        }

        public async Task updateAsync(AlunoDTO aluno)
        {
            var entidade = mapper.Map<Alunos>(aluno);

            await repositorio.updateAsync(entidade);
        }
    }
}