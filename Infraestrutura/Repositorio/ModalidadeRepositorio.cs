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
    public class ModalidadeRepositorio : IModalidadeRepositorio
    {
        private EmpresaContexto contexto;

        public ModalidadeRepositorio(EmpresaContexto contexto)
        {
            this.contexto = contexto;
        }

        public async Task<Modalidade> addAsync(Modalidade modalidade)
        {
            await contexto.Modalidades.AddAsync(modalidade);

            await contexto.SaveChangesAsync();

            return modalidade;
        }

        public async Task<IEnumerable<Modalidade>> getAllAsync(
            Expression<Func<Modalidade, bool>> expression)
        {
            return await contexto.Modalidades
                .Where(expression)
                .OrderBy(p => p.Nome)
                .ToListAsync();
        }

        public async Task<Modalidade?> getAsync(int id)
        {
            return await contexto.Modalidades.FindAsync(id);
        }

        public async Task removeAsync(Modalidade modalidade)
        {
            contexto.Modalidades.Remove(modalidade);

            await contexto.SaveChangesAsync();
        }

        public async Task updateAsync(Modalidade modalidade)
        {
            contexto.Entry(modalidade).State = EntityState.Modified;

            await contexto.SaveChangesAsync();
        }
    }
}