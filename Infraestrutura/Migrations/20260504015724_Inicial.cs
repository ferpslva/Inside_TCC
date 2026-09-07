using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestrutura.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Data = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    LimiteAlunos = table.Column<int>(type: "int", nullable: false),
                    Poster = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CPF = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CEP = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rua = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Bairro = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cidade = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Planos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Valor = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tamanhos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tamanhos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TiposProduto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposProduto", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Vinculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ValorDesconto = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vinculos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alunos_Pessoa_Id",
                        column: x => x.Id,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Inscricoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdEvento = table.Column<int>(type: "int", nullable: false),
                    EventoId = table.Column<int>(type: "int", nullable: true),
                    IdPessoa = table.Column<int>(type: "int", nullable: false),
                    PessoaId = table.Column<int>(type: "int", nullable: true),
                    Pagamento = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscricoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inscricoes_Eventos_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Eventos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Inscricoes_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Senha = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Professores_Pessoa_Id",
                        column: x => x.Id,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QtdeFinal = table.Column<int>(type: "int", nullable: false),
                    ValorCredito = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ValorPix = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IdTamanho = table.Column<int>(type: "int", nullable: false),
                    TamanhoId = table.Column<int>(type: "int", nullable: true),
                    IdTipoProduto = table.Column<int>(type: "int", nullable: false),
                    TipoProdutoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_Tamanhos_TamanhoId",
                        column: x => x.TamanhoId,
                        principalTable: "Tamanhos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Produtos_TiposProduto_TipoProdutoId",
                        column: x => x.TipoProdutoId,
                        principalTable: "TiposProduto",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PagamentosEvento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdInscricao = table.Column<int>(type: "int", nullable: false),
                    InscricaoId = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    DataPagamento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagamentosEvento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PagamentosEvento_Inscricoes_InscricaoId",
                        column: x => x.InscricaoId,
                        principalTable: "Inscricoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Modalidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IdProfessor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modalidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modalidades_Professores_IdProfessor",
                        column: x => x.IdProfessor,
                        principalTable: "Professores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EntradasProduto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    IdProduto = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: true),
                    Data = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntradasProduto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntradasProduto_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SaidasProduto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    IdProduto = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: true),
                    IdPessoa = table.Column<int>(type: "int", nullable: false),
                    PessoaId = table.Column<int>(type: "int", nullable: true),
                    Data = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Desconto = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaidasProduto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaidasProduto_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SaidasProduto_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Aula",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdModalidade = table.Column<int>(type: "int", nullable: false),
                    ModalidadeId = table.Column<int>(type: "int", nullable: true),
                    Data = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Competencia = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdProfessor = table.Column<int>(type: "int", nullable: false),
                    ProfessorId = table.Column<int>(type: "int", nullable: true),
                    Personal = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aula", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aula_Modalidades_ModalidadeId",
                        column: x => x.ModalidadeId,
                        principalTable: "Modalidades",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Aula_Professores_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professores",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Graduacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Valor = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IdModalidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Graduacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Graduacoes_Modalidades_IdModalidade",
                        column: x => x.IdModalidade,
                        principalTable: "Modalidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PagamentosProduto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdSaidaProduto = table.Column<int>(type: "int", nullable: false),
                    Saida_ProdutoId = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    DataPagamento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagamentosProduto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PagamentosProduto_SaidasProduto_Saida_ProdutoId",
                        column: x => x.Saida_ProdutoId,
                        principalTable: "SaidasProduto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Aula_Aluno",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdAluno = table.Column<int>(type: "int", nullable: false),
                    AlunoId = table.Column<int>(type: "int", nullable: true),
                    IdAula = table.Column<int>(type: "int", nullable: false),
                    AulaId = table.Column<int>(type: "int", nullable: true),
                    Acesso = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aula_Aluno", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aula_Aluno_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Aula_Aluno_Aula_AulaId",
                        column: x => x.AulaId,
                        principalTable: "Aula",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Matriculas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdAluno = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    AulaExperimental = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ValorAula = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    IdPlano = table.Column<int>(type: "int", nullable: false),
                    IdModalidade = table.Column<int>(type: "int", nullable: false),
                    IdGraduacao = table.Column<int>(type: "int", nullable: false),
                    IdVinculo = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matriculas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matriculas_Alunos_IdAluno",
                        column: x => x.IdAluno,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matriculas_Graduacoes_IdGraduacao",
                        column: x => x.IdGraduacao,
                        principalTable: "Graduacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matriculas_Modalidades_IdModalidade",
                        column: x => x.IdModalidade,
                        principalTable: "Modalidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matriculas_Planos_IdPlano",
                        column: x => x.IdPlano,
                        principalTable: "Planos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matriculas_Vinculos_IdVinculo",
                        column: x => x.IdVinculo,
                        principalTable: "Vinculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Mensalidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdMatricula = table.Column<int>(type: "int", nullable: false),
                    MatriculaId = table.Column<int>(type: "int", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Vencimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensalidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mensalidades_Matriculas_MatriculaId",
                        column: x => x.MatriculaId,
                        principalTable: "Matriculas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PagamentosMensalidade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdMensalidade = table.Column<int>(type: "int", nullable: false),
                    MensalidadeId = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    DataPagamento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagamentosMensalidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PagamentosMensalidade_Mensalidades_MensalidadeId",
                        column: x => x.MensalidadeId,
                        principalTable: "Mensalidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Aula_ModalidadeId",
                table: "Aula",
                column: "ModalidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Aula_ProfessorId",
                table: "Aula",
                column: "ProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_Aula_Aluno_AlunoId",
                table: "Aula_Aluno",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Aula_Aluno_AulaId",
                table: "Aula_Aluno",
                column: "AulaId");

            migrationBuilder.CreateIndex(
                name: "IX_EntradasProduto_ProdutoId",
                table: "EntradasProduto",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Graduacoes_IdModalidade",
                table: "Graduacoes",
                column: "IdModalidade");

            migrationBuilder.CreateIndex(
                name: "IX_Inscricoes_EventoId",
                table: "Inscricoes",
                column: "EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscricoes_PessoaId",
                table: "Inscricoes",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_IdAluno",
                table: "Matriculas",
                column: "IdAluno");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_IdGraduacao",
                table: "Matriculas",
                column: "IdGraduacao");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_IdModalidade",
                table: "Matriculas",
                column: "IdModalidade");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_IdPlano",
                table: "Matriculas",
                column: "IdPlano");

            migrationBuilder.CreateIndex(
                name: "IX_Matriculas_IdVinculo",
                table: "Matriculas",
                column: "IdVinculo");

            migrationBuilder.CreateIndex(
                name: "IX_Mensalidades_MatriculaId",
                table: "Mensalidades",
                column: "MatriculaId");

            migrationBuilder.CreateIndex(
                name: "IX_Modalidades_IdProfessor",
                table: "Modalidades",
                column: "IdProfessor");

            migrationBuilder.CreateIndex(
                name: "IX_PagamentosEvento_InscricaoId",
                table: "PagamentosEvento",
                column: "InscricaoId");

            migrationBuilder.CreateIndex(
                name: "IX_PagamentosMensalidade_MensalidadeId",
                table: "PagamentosMensalidade",
                column: "MensalidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_PagamentosProduto_Saida_ProdutoId",
                table: "PagamentosProduto",
                column: "Saida_ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_TamanhoId",
                table: "Produtos",
                column: "TamanhoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_TipoProdutoId",
                table: "Produtos",
                column: "TipoProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_SaidasProduto_PessoaId",
                table: "SaidasProduto",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_SaidasProduto_ProdutoId",
                table: "SaidasProduto",
                column: "ProdutoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aula_Aluno");

            migrationBuilder.DropTable(
                name: "EntradasProduto");

            migrationBuilder.DropTable(
                name: "PagamentosEvento");

            migrationBuilder.DropTable(
                name: "PagamentosMensalidade");

            migrationBuilder.DropTable(
                name: "PagamentosProduto");

            migrationBuilder.DropTable(
                name: "Aula");

            migrationBuilder.DropTable(
                name: "Inscricoes");

            migrationBuilder.DropTable(
                name: "Mensalidades");

            migrationBuilder.DropTable(
                name: "SaidasProduto");

            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.DropTable(
                name: "Matriculas");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Graduacoes");

            migrationBuilder.DropTable(
                name: "Planos");

            migrationBuilder.DropTable(
                name: "Vinculos");

            migrationBuilder.DropTable(
                name: "Tamanhos");

            migrationBuilder.DropTable(
                name: "TiposProduto");

            migrationBuilder.DropTable(
                name: "Modalidades");

            migrationBuilder.DropTable(
                name: "Professores");

            migrationBuilder.DropTable(
                name: "Pessoa");
        }
    }
}
