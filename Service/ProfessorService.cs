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
    public class ProfessorService : IProfessorService
    {
        private IProfessorRepositorio repositorio;

        private IMapper mapper;

        public ProfessorService(
            IProfessorRepositorio repositorio,
            IMapper mapper)
        {
            this.repositorio = repositorio;
            this.mapper = mapper;
        }

        public async Task<ProfessorDTO> addAsync(ProfessorDTO professor)
        {
            var entidade = mapper.Map<Professores>(professor);

            entidade = await repositorio.addAsync(entidade);

            return mapper.Map<ProfessorDTO>(entidade);
        }

        public async Task<IEnumerable<ProfessorDTO>> getAllAsync(
            Expression<Func<Professores, bool>> expression)
        {
            var lista = await repositorio.getAllAsync(expression);

            return mapper.Map<IEnumerable<ProfessorDTO>>(lista);
        }

        public async Task<ProfessorDTO?> getAsync(int id)
        {
            var professor = await repositorio.getAsync(id);

            return mapper.Map<ProfessorDTO>(professor);
        }

        public async Task removeAsync(int id)
        {
            var professor = await repositorio.getAsync(id);

            if (professor != null)
            {
                await repositorio.removeAsync(professor);
            }
        }

        public async Task updateAsync(ProfessorDTO professor)
        {
            var entidade = mapper.Map<Professores>(professor);

            await repositorio.updateAsync(entidade);
        }
    }
}