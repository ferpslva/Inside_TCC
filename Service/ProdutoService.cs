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
    public class ProdutoService : IProdutoService
    {
        private IProdutoRepositorio repositorio;

        private IMapper mapper;

        public ProdutoService(
            IProdutoRepositorio repositorio,
            IMapper mapper)
        {
            this.repositorio = repositorio;
            this.mapper = mapper;
        }

        public async Task<ProdutoDTO> addAsync(ProdutoDTO produto)
        {
            var entidade = mapper.Map<Produto>(produto);

            entidade = await repositorio.addAsync(entidade);

            return mapper.Map<ProdutoDTO>(entidade);
        }

        public async Task<IEnumerable<ProdutoDTO>> getAllAsync(
            Expression<Func<Produto, bool>> expression)
        {
            var lista = await repositorio.getAllAsync(expression);

            return mapper.Map<IEnumerable<ProdutoDTO>>(lista);
        }

        public async Task<ProdutoDTO?> getAsync(int id)
        {
            var produto = await repositorio.getAsync(id);

            return mapper.Map<ProdutoDTO>(produto);
        }

        public async Task removeAsync(int id)
        {
            var produto = await repositorio.getAsync(id);

            if (produto != null)
            {
                await repositorio.removeAsync(produto);
            }
        }

        public async Task updateAsync(ProdutoDTO produto)
        {
            var entidade = mapper.Map<Produto>(produto);

            await repositorio.updateAsync(entidade);
        }
    }
}