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
    public class TamanhoRepositorio : ITamanhoRepositorio
    {
        private EmpresaContexto contexto;

        public TamanhoRepositorio(EmpresaContexto contexto)
        {
            this.contexto = contexto;
        }

        public async Task<Tamanho> addAsync(Tamanho tamanho)
        {
            await contexto.Tamanhos.AddAsync(tamanho);

            await contexto.SaveChangesAsync();

            return tamanho;
        }

        public async Task<IEnumerable<Tamanho>> getAllAsync(
            Expression<Func<Tamanho, bool>> expression)
        {
            return await contexto.Tamanhos
                .Where(expression)
                .OrderBy(p => p.Descricao)
                .ToListAsync();
        }

        public async Task<Tamanho?> getAsync(int id)
        {
            return await contexto.Tamanhos.FindAsync(id);
        }

        public async Task removeAsync(Tamanho tamanho)
        {
            contexto.Tamanhos.Remove(tamanho);

            await contexto.SaveChangesAsync();
        }

        public async Task updateAsync(Tamanho tamanho)
        {
            contexto.Entry(tamanho).State = EntityState.Modified;

            await contexto.SaveChangesAsync();
        }
    }
}