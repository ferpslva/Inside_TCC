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
    public class PlanoRepositorio : IPlanoRepositorio
    {
        private EmpresaContexto contexto;

        public PlanoRepositorio(EmpresaContexto contexto)
        {
            this.contexto = contexto;
        }

        public async Task<Plano> addAsync(Plano plano)
        {
            await contexto.Planos.AddAsync(plano);

            await contexto.SaveChangesAsync();

            return plano;
        }

        public async Task<IEnumerable<Plano>> getAllAsync(
            Expression<Func<Plano, bool>> expression)
        {
            return await contexto.Planos
                .Where(expression)
                .OrderBy(p => p.Nome)
                .ToListAsync();
        }

        public async Task<Plano?> getAsync(int id)
        {
            return await contexto.Planos.FindAsync(id);
        }

        public async Task removeAsync(Plano plano)
        {
            contexto.Planos.Remove(plano);

            await contexto.SaveChangesAsync();
        }

        public async Task updateAsync(Plano plano)
        {
            contexto.Entry(plano).State = EntityState.Modified;

            await contexto.SaveChangesAsync();
        }
    }
}