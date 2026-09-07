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
    public class GraduacaoRepositorio : IGraduacaoRepositorio
    {
        private EmpresaContexto contexto;

        public GraduacaoRepositorio(EmpresaContexto contexto)
        {
            this.contexto = contexto;
        }

        public async Task<Graduacao> addAsync(Graduacao graduacao)
        {
            await contexto.Graduacoes.AddAsync(graduacao);

            await contexto.SaveChangesAsync();

            return graduacao;
        }

        public async Task<IEnumerable<Graduacao>> getAllAsync(
            Expression<Func<Graduacao, bool>> expression)
        {
            return await contexto.Graduacoes
                .Where(expression)
                .OrderBy(p => p.Nome)
                .ToListAsync();
        }

        public async Task<Graduacao?> getAsync(int id)
        {
            return await contexto.Graduacoes.FindAsync(id);
        }

        public async Task removeAsync(Graduacao graduacao)
        {
            contexto.Graduacoes.Remove(graduacao);

            await contexto.SaveChangesAsync();
        }

        public async Task updateAsync(Graduacao graduacao)
        {
            contexto.Entry(graduacao).State = EntityState.Modified;

            await contexto.SaveChangesAsync();
        }
    }
}