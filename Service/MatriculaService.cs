using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using Dominio.DTOs;
using Dominio.Entidade;
using Interface.Repositorio;
using Interface.Service;
using System.Linq.Expressions;

namespace Service
{
    public class MatriculaService : IMatriculaService
    {
        private IMatriculaRepositorio repositorio;

        private IMapper mapper;

        public MatriculaService(
            IMatriculaRepositorio repositorio,
            IMapper mapper)
        {
            this.repositorio = repositorio;
            this.mapper = mapper;
        }

        public async Task<MatriculaDTO> addAsync(MatriculaDTO matricula)
        {
            var entidade = mapper.Map<Matricula>(matricula);

            entidade = await repositorio.addAsync(entidade);

            return mapper.Map<MatriculaDTO>(entidade);
        }

        public async Task<IEnumerable<MatriculaDTO>> getAllAsync(
            Expression<Func<Matricula, bool>> expression)
        {
            var lista = await repositorio.getAllAsync(expression);

            return mapper.Map<IEnumerable<MatriculaDTO>>(lista);
        }

        public async Task<MatriculaDTO?> getAsync(int id)
        {
            var matricula = await repositorio.getAsync(id);

            return mapper.Map<MatriculaDTO>(matricula);
        }

        public async Task removeAsync(int id)
        {
            var matricula = await repositorio.getAsync(id);

            if (matricula != null)
            {
                await repositorio.removeAsync(matricula);
            }
        }

        public async Task updateAsync(MatriculaDTO matricula)
        {
            var entidade = mapper.Map<Matricula>(matricula);

            await repositorio.updateAsync(entidade);
        }
    }
}