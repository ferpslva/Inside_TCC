using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dominio.Entidade;

namespace Infraestrutura.Data
{
    public class EmpresaContexto : DbContext
    {
        public EmpresaContexto(
            DbContextOptions<EmpresaContexto> options)
            : base(options)
        {
        }

        public DbSet<Alunos> Alunos { get; set; }
        public DbSet<Professores> Professores { get; set; }
        public DbSet<Modalidade> Modalidades { get; set; }
        public DbSet<Graduacao> Graduacoes { get; set; }
        public DbSet<Plano> Planos { get; set; }
        public DbSet<Vinculo> Vinculos { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Mensalidade> Mensalidades { get; set; }
        public DbSet<Pagamento_Mensalidade> PagamentosMensalidade { get; set; }
        public DbSet<Eventos> Eventos { get; set; }
        public DbSet<Inscricao> Inscricoes { get; set; }
        public DbSet<Pagamento_Evento> PagamentosEvento { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Tamanho> Tamanhos { get; set; }
        public DbSet<Tipo_Produto> TiposProduto { get; set; }
        public DbSet<Entrada_Produto> EntradasProduto { get; set; }
        public DbSet<Saida_Produto> SaidasProduto { get; set; }
        public DbSet<Pagamento_Produto> PagamentosProduto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ===== PESSOA =====
            modelBuilder.Entity<Pessoa>(builder =>
            {
                builder.HasKey(p => p.Id);

                builder.Property(p => p.Nome)
                    .IsRequired()
                    .HasMaxLength(150);

                builder.Property(p => p.CPF)
                    .IsRequired()
                    .HasMaxLength(11);

                builder.Property(p => p.Email)
                    .HasMaxLength(150);

                builder.Property(p => p.Telefone)
                    .HasMaxLength(20);
            });

            // ===== ALUNO =====
            modelBuilder.Entity<Alunos>(builder =>
            {
                builder.ToTable("Alunos");

                builder.Property(a => a.Nome)
                    .IsRequired()
                    .HasMaxLength(150);

                builder.Property(a => a.CPF)
                    .IsRequired()
                    .HasMaxLength(11);
            });

            // ===== PROFESSOR =====
            modelBuilder.Entity<Professores>(builder =>
            {
                builder.ToTable("Professores");

                builder.Property(p => p.Nome)
                    .IsRequired()
                    .HasMaxLength(150);

                builder.Property(p => p.Senha)
                    .IsRequired();
            });

            // ===== MODALIDADE =====
            modelBuilder.Entity<Modalidade>(builder =>
            {
                builder.ToTable("Modalidades");

                builder.HasKey(m => m.Id);

                builder.Property(m => m.Nome)
                    .IsRequired()
                    .HasMaxLength(100);

                builder.HasOne(m => m.Professor)
                    .WithMany(p => p.Modalidades)
                    .HasForeignKey(m => m.IdProfessor)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // ===== GRADUAÇÃO =====
            modelBuilder.Entity<Graduacao>(builder =>
            {
                builder.ToTable("Graduacoes");

                builder.HasKey(g => g.Id);

                builder.Property(g => g.Nome)
                    .IsRequired()
                    .HasMaxLength(100);

                builder.Property(g => g.Valor)
                    .HasPrecision(10, 2);

                builder.HasOne(g => g.Modalidade)
                    .WithMany(m => m.Graduacoes)
                    .HasForeignKey(g => g.IdModalidade)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // ===== PLANO =====
            modelBuilder.Entity<Plano>(builder =>
            {
                builder.ToTable("Planos");

                builder.HasKey(p => p.Id);

                builder.Property(p => p.Nome)
                    .IsRequired()
                    .HasMaxLength(100);

                builder.Property(p => p.Valor)
                    .HasPrecision(10, 2);
            });

            // ===== VINCULO =====
            modelBuilder.Entity<Vinculo>(builder =>
            {
                builder.ToTable("Vinculos");

                builder.HasKey(v => v.Id);

                builder.Property(v => v.Descricao)
                    .IsRequired()
                    .HasMaxLength(100);

                builder.Property(v => v.ValorDesconto)
                    .HasPrecision(10, 2);
            });

            // ===== MATRICULA =====
            modelBuilder.Entity<Matricula>(builder =>
            {
                builder.ToTable("Matriculas");

                builder.HasKey(m => m.Id);

                builder.Property(m => m.ValorAula)
                    .HasPrecision(10, 2);

                builder.HasOne(m => m.Aluno)
                    .WithMany(a => a.Matriculas)
                    .HasForeignKey(m => m.IdAluno)
                    .OnDelete(DeleteBehavior.Restrict);

                builder.HasOne(m => m.Plano)
                    .WithMany(p => p.Matriculas)
                    .HasForeignKey(m => m.IdPlano)
                    .OnDelete(DeleteBehavior.Restrict);

                builder.HasOne(m => m.Modalidade)
                    .WithMany(mo => mo.Matriculas)
                    .HasForeignKey(m => m.IdModalidade)
                    .OnDelete(DeleteBehavior.Restrict);

                builder.HasOne(m => m.Graduacao)
                    .WithMany(g => g.Matriculas)
                    .HasForeignKey(m => m.IdGraduacao)
                    .OnDelete(DeleteBehavior.Restrict);

                builder.HasOne(m => m.Vinculo)
                    .WithMany(v => v.Matriculas)
                    .HasForeignKey(m => m.IdVinculo)
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}