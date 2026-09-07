using AutoMapper;
using Dominio.DTOs;
using Dominio.Entidade;
using Interface.Repositorio;
using Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class VinculoService : IVinculoService
    {
        private IVinculoRepositorio repositorio;

        private IMapper mapper;

        public VinculoService(
            IVinculoRepositorio repositorio,
            IMapper mapper)
        {
            this.repositorio = repositorio;
            this.mapper = mapper;
        }

        public async Task<VinculoDTO> addAsync(VinculoDTO vinculo)
        {
            var entidade = mapper.Map<Vinculo>(vinculo);

            entidade = await repositorio.addAsync(entidade);

            return mapper.Map<VinculoDTO>(entidade);
        }

        public async Task<IEnumerable<VinculoDTO>> getAllAsync(
            Expression<Func<Vinculo, bool>> expression)
        {
            var lista = await repositorio.getAllAsync(expression);

            return mapper.Map<IEnumerable<VinculoDTO>>(lista);
        }

        public async Task<VinculoDTO?> getAsync(int id)
        {
            var vinculo = await repositorio.getAsync(id);

            return mapper.Map<VinculoDTO>(vinculo);
        }

        public async Task removeAsync(int id)
        {
            var vinculo = await repositorio.getAsync(id);

            if (vinculo != null)
            {
                await repositorio.removeAsync(vinculo);
            }
        }

        public async Task updateAsync(VinculoDTO vinculo)
        {
            var entidade = mapper.Map<Vinculo>(vinculo);

            await repositorio.updateAsync(entidade);
        }
    }
}
