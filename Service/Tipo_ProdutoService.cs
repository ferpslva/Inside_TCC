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
    public class Tipo_ProdutoService : ITipo_ProdutoService
    {
        private ITipo_ProdutoRepositorio repositorio;

        private IMapper mapper;

        public Tipo_ProdutoService(
            ITipo_ProdutoRepositorio repositorio,
            IMapper mapper)
        {
            this.repositorio = repositorio;
            this.mapper = mapper;
        }

        public async Task<Tipo_ProdutoDTO> addAsync(Tipo_ProdutoDTO tipo_Produto)
        {
            var entidade = mapper.Map<Tipo_Produto>(tipo_Produto);

            entidade = await repositorio.addAsync(entidade);

            return mapper.Map<Tipo_ProdutoDTO>(entidade);
        }

        public async Task<IEnumerable<Tipo_ProdutoDTO>> getAllAsync(
            Expression<Func<Tipo_Produto, bool>> expression)
        {
            var lista = await repositorio.getAllAsync(expression);

            return mapper.Map<IEnumerable<Tipo_ProdutoDTO>>(lista);
        }

        public async Task<Tipo_ProdutoDTO?> getAsync(int id)
        {
            var tipo_Produto = await repositorio.getAsync(id);

            return mapper.Map<Tipo_ProdutoDTO>(tipo_Produto);
        }

        public async Task removeAsync(int id)
        {
            var tipo_Produto = await repositorio.getAsync(id);

            if (tipo_Produto != null)
            {
                await repositorio.removeAsync(tipo_Produto);
            }
        }

        public async Task updateAsync(Tipo_ProdutoDTO tipo_Produto)
        {
            var entidade = mapper.Map<Tipo_Produto>(tipo_Produto);

            await repositorio.updateAsync(entidade);
        }
    }
}
