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
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private EmpresaContexto contexto;

        public AlunoRepositorio(EmpresaContexto contexto)
        {
            this.contexto = contexto;
        }

        public async Task<Alunos> addAsync(Alunos aluno)
        {
            await contexto.Alunos.AddAsync(aluno);

            await contexto.SaveChangesAsync();

            return aluno;
        }

        public async Task<IEnumerable<Alunos>> getAllAsync(
            Expression<Func<Alunos, bool>> expression)
        {
            return await contexto.Alunos
                .Where(expression)
                .OrderBy(a => a.Nome)
                .ToListAsync();
        }

        public async Task<Alunos?> getAsync(int id)
        {
            return await contexto.Alunos.FindAsync(id);
        }

        public async Task removeAsync(Alunos aluno)
        {
            contexto.Alunos.Remove(aluno);

            await contexto.SaveChangesAsync();
        }

        public async Task updateAsync(Alunos aluno)
        {
            contexto.Entry(aluno).State = EntityState.Modified;

            await contexto.SaveChangesAsync();
        }
    }
}