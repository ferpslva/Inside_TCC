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
    public class VinculoRepositorio : IVinculoRepositorio
    {
        private EmpresaContexto contexto;

        public VinculoRepositorio(EmpresaContexto contexto)
        {
            this.contexto = contexto;
        }

        public async Task<Vinculo> addAsync(Vinculo vinculo)
        {
            await contexto.Vinculos.AddAsync(vinculo);

            await contexto.SaveChangesAsync();

            return vinculo;
        }

        public async Task<IEnumerable<Vinculo>> getAllAsync(
            Expression<Func<Vinculo, bool>> expression)
        {
            return await contexto.Vinculos
                .Where(expression)
                .OrderBy(p => p.Descricao)
                .ToListAsync();
        }

        public async Task<Vinculo?> getAsync(int id)
        {
            return await contexto.Vinculos.FindAsync(id);
        }

        public async Task removeAsync(Vinculo vinculo)
        {
            contexto.Vinculos.Remove(vinculo);

            await contexto.SaveChangesAsync();
        }

        public async Task updateAsync(Vinculo vinculo)
        {
            contexto.Entry(vinculo).State = EntityState.Modified;

            await contexto.SaveChangesAsync();
        }
    }
}