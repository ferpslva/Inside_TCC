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
    public class GraduacaoService : IGraduacaoService
    {
        private IGraduacaoRepositorio repositorio;

        private IMapper mapper;

        public GraduacaoService(
            IGraduacaoRepositorio repositorio,
            IMapper mapper)
        {
            this.repositorio = repositorio;
            this.mapper = mapper;
        }

        public async Task<GraduacaoDTO> addAsync(GraduacaoDTO graduacao)
        {
            var entidade = mapper.Map<Graduacao>(graduacao);

            entidade = await repositorio.addAsync(entidade);

            return mapper.Map<GraduacaoDTO>(entidade);
        }

        public async Task<IEnumerable<GraduacaoDTO>> getAllAsync(
            Expression<Func<Graduacao, bool>> expression)
        {
            var lista = await repositorio.getAllAsync(expression);

            return mapper.Map<IEnumerable<GraduacaoDTO>>(lista);
        }

        public async Task<GraduacaoDTO?> getAsync(int id)
        {
            var graduacao = await repositorio.getAsync(id);

            return mapper.Map<GraduacaoDTO>(graduacao);
        }

        public async Task removeAsync(int id)
        {
            var graduacao = await repositorio.getAsync(id);

            if (graduacao != null)
            {
                await repositorio.removeAsync(graduacao);
            }
        }

        public async Task updateAsync(GraduacaoDTO graduacao)
        {
            var entidade = mapper.Map<Graduacao>(graduacao);

            await repositorio.updateAsync(entidade);
        }
    }
}