using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio.Entidade;
using Infraestrutura.Data;
using Interface.Repositorio;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infraestrutura.Repositorio
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private EmpresaContexto contexto;

        public ProdutoRepositorio(EmpresaContexto contexto)
        {
            this.contexto = contexto;
        }

        public async Task<Produto> addAsync(Produto produto)
        {
            await contexto.Produtos.AddAsync(produto);

            await contexto.SaveChangesAsync();

            return produto;
        }

        public async Task<IEnumerable<Produto>> getAllAsync(
            Expression<Func<Produto, bool>> expression)
        {
            return await contexto.Produtos
                .Where(expression)
                .OrderBy(p => p.Nome)
                .ToListAsync();
        }

        public async Task<Produto?> getAsync(int id)
        {
            return await contexto.Produtos.FindAsync(id);
        }

        public async Task removeAsync(Produto produto)
        {
            contexto.Produtos.Remove(produto);

            await contexto.SaveChangesAsync();
        }

        public async Task updateAsync(Produto produto)
        {
            contexto.Entry(produto).State = EntityState.Modified;

            await contexto.SaveChangesAsync();
        }
    }
}