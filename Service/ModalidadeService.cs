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
    public class ModalidadeService : IModalidadeService
    {
        private IModalidadeRepositorio repositorio;

        private IMapper mapper;

        public ModalidadeService(
            IModalidadeRepositorio repositorio,
            IMapper mapper)
        {
            this.repositorio = repositorio;
            this.mapper = mapper;
        }

        public async Task<ModalidadeDTO> addAsync(ModalidadeDTO modalidade)
        {
            var entidade = mapper.Map<Modalidade>(modalidade);

            entidade = await repositorio.addAsync(entidade);

            return mapper.Map<ModalidadeDTO>(entidade);
        }

        public async Task<IEnumerable<ModalidadeDTO>> getAllAsync(
            Expression<Func<Modalidade, bool>> expression)
        {
            var lista = await repositorio.getAllAsync(expression);

            return mapper.Map<IEnumerable<ModalidadeDTO>>(lista);
        }

        public async Task<ModalidadeDTO?> getAsync(int id)
        {
            var modalidade = await repositorio.getAsync(id);

            return mapper.Map<ModalidadeDTO>(modalidade);
        }

        public async Task removeAsync(int id)
        {
            var modalidade = await repositorio.getAsync(id);

            if (modalidade != null)
            {
                await repositorio.removeAsync(modalidade);
            }
        }

        public async Task updateAsync(ModalidadeDTO modalidade)
        {
            var entidade = mapper.Map<Modalidade>(modalidade);

            await repositorio.updateAsync(entidade);
        }
    }
}