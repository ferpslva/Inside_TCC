using Dominio.Entidade;
using Infraestrutura.Data;
using Interface.Repositorio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Repositorio
{
    public class Tipo_ProdutoRepositorio : ITipo_ProdutoRepositorio
    {
        private EmpresaContexto contexto;

        public Tipo_ProdutoRepositorio(EmpresaContexto contexto)
        {
            this.contexto = contexto;
        }

        public async Task<Tipo_Produto> addAsync(Tipo_Produto tipo_Produto)
        {
            await contexto.TiposProduto.AddAsync(tipo_Produto);

            await contexto.SaveChangesAsync();

            return tipo_Produto;
        }

        public async Task<IEnumerable<Tipo_Produto>> getAllAsync(
            Expression<Func<Tipo_Produto, bool>> expression)
        {
            return await contexto.TiposProduto
                .Where(expression)
                .OrderBy(p => p.Descricao)
                .ToListAsync();
        }

        public async Task<Tipo_Produto?> getAsync(int id)
        {
            return await contexto.TiposProduto.FindAsync(id);
        }

        public async Task removeAsync(Tipo_Produto tipo_Produto)
        {
            contexto.TiposProduto.Remove(tipo_Produto);

            await contexto.SaveChangesAsync();
        }

        public async Task updateAsync(Tipo_Produto tipo_Produto)
        {
            contexto.Entry(tipo_Produto).State = EntityState.Modified;

            await contexto.SaveChangesAsync();
        }
    }
}