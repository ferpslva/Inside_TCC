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
    public class MatriculaRepositorio : IMatriculaRepositorio
    {
        private EmpresaContexto contexto;

        public MatriculaRepositorio(EmpresaContexto contexto)
        {
            this.contexto = contexto;
        }

        public async Task<Matricula> addAsync(Matricula matricula)
        {
            await contexto.Matriculas.AddAsync(matricula);

            await contexto.SaveChangesAsync();

            return matricula;
        }

        public async Task<IEnumerable<Matricula>> getAllAsync(
            Expression<Func<Matricula, bool>> expression)
        {
            return await contexto.Matriculas
                .Where(expression)
                .OrderByDescending(p => p.Data)
                .ToListAsync();
        }

        public async Task<Matricula?> getAsync(int id)
        {
            return await contexto.Matriculas.FindAsync(id);
        }

        public async Task removeAsync(Matricula matricula)
        {
            contexto.Matriculas.Remove(matricula);

            await contexto.SaveChangesAsync();
        }

        public async Task updateAsync(Matricula matricula)
        {
            contexto.Entry(matricula).State = EntityState.Modified;

            await contexto.SaveChangesAsync();
        }
    }
}