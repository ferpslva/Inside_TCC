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
    public class PlanoService : IPlanoService
    {
        private IPlanoRepositorio repositorio;

        private IMapper mapper;

        public PlanoService(
            IPlanoRepositorio repositorio,
            IMapper mapper)
        {
            this.repositorio = repositorio;
            this.mapper = mapper;
        }

        public async Task<PlanoDTO> addAsync(PlanoDTO plano)
        {
            var entidade = mapper.Map<Plano>(plano);

            entidade = await repositorio.addAsync(entidade);

            return mapper.Map<PlanoDTO>(entidade);
        }

        public async Task<IEnumerable<PlanoDTO>> getAllAsync(
            Expression<Func<Plano, bool>> expression)
        {
            var lista = await repositorio.getAllAsync(expression);

            return mapper.Map<IEnumerable<PlanoDTO>>(lista);
        }

        public async Task<PlanoDTO?> getAsync(int id)
        {
            var plano = await repositorio.getAsync(id);

            return mapper.Map<PlanoDTO>(plano);
        }

        public async Task removeAsync(int id)
        {
            var plano = await repositorio.getAsync(id);

            if (plano != null)
            {
                await repositorio.removeAsync(plano);
            }
        }

        public async Task updateAsync(PlanoDTO plano)
        {
            var entidade = mapper.Map<Plano>(plano);

            await repositorio.updateAsync(entidade);
        }
    }
}