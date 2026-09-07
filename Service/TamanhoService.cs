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
    public class TamanhoService:ITamanhoService
    {
        private ITamanhoRepositorio repositorio;

        private IMapper mapper;

        public TamanhoService(
            ITamanhoRepositorio repositorio,
            IMapper mapper)
        {
            this.repositorio = repositorio;
            this.mapper = mapper;
        }

        public async Task<TamanhoDTO> addAsync(TamanhoDTO tamanho)
        {
            var entidade = mapper.Map<Tamanho>(tamanho);

            entidade = await repositorio.addAsync(entidade);

            return mapper.Map<TamanhoDTO>(entidade);
        }

        public async Task<IEnumerable<TamanhoDTO>> getAllAsync(
            Expression<Func<Tamanho, bool>> expression)
        {
            var lista = await repositorio.getAllAsync(expression);

            return mapper.Map<IEnumerable<TamanhoDTO>>(lista);
        }

        public async Task<TamanhoDTO?> getAsync(int id)
        {
            var tamanho = await repositorio.getAsync(id);

            return mapper.Map<TamanhoDTO>(tamanho);
        }

        public async Task removeAsync(int id)
        {
            var tamanho = await repositorio.getAsync(id);

            if (tamanho != null)
            {
                await repositorio.removeAsync(tamanho);
            }
        }

        public async Task updateAsync(TamanhoDTO tamanho)
        {
            var entidade = mapper.Map<Tamanho>(tamanho);

            await repositorio.updateAsync(entidade);
        }
    }
}
