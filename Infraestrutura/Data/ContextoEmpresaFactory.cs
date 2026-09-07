using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infraestrutura.Data
{
    public class ContextoEmpresaFactory : IDesignTimeDbContextFactory<EmpresaContexto>
    {
        public EmpresaContexto CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EmpresaContexto>();


            // Defina a string de conexão de forma que o EF possa usar durante o processo de migração.
            string conexao = "server=localhost;database=AcademiaDB;user=root;";
            optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));

            return new EmpresaContexto(optionsBuilder.Options);
        }
    }
}



            