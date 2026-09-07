using Dominio.Entidade;
using Infraestrutura.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Interface.Repositorio;

namespace Infraestrutura.Repositorio
{
    public class ProfessorRepositorio : IProfessorRepositorio
    {
        private EmpresaContexto contexto;

        public ProfessorRepositorio(EmpresaContexto contexto)
        {
            this.contexto = contexto;
        }

        public async Task<Professores> addAsync(Professores professor)
        {
            await contexto.Professores.AddAsync(professor);

            await contexto.SaveChangesAsync();

            return professor;
        }

        public async Task<IEnumerable<Professores>> getAllAsync(
            Expression<Func<Professores, bool>> expression)
        {
            return await contexto.Professores
                .Where(expression)
                .OrderBy(a => a.Nome)
                .ToListAsync();
        }

        public async Task<Professores?> getAsync(int id)
        {
            return await contexto.Professores.FindAsync(id);
        }

        public async Task removeAsync(Professores professores)
        {
            contexto.Professores.Remove(professores);

            await contexto.SaveChangesAsync();
        }

        public async Task updateAsync(Professores professores)
        {
            contexto.Entry(professores).State = EntityState.Modified;

            await contexto.SaveChangesAsync();
        }
    }
}