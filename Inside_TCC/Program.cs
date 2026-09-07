using Infraestrutura.Data;
using Infraestrutura.Repositorio;
using Interface.Repositorio;
using Interface.Service;
using Microsoft.EntityFrameworkCore;
using Service;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);


// ======================================
// CONNECTION STRING
// ======================================

var connectionString =
    builder.Configuration.GetConnectionString("DefaultConnection");


// ======================================
// DATABASE
// ======================================

builder.Services.AddDbContext<EmpresaContexto>(options =>
    options.UseMySql(
        connectionString,
        ServerVersion.AutoDetect(connectionString)
    ));


// ======================================
// CONTROLLERS + JSON
// ======================================

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler =
            ReferenceHandler.IgnoreCycles;
    });


// ======================================
// SWAGGER
// ======================================

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();


// ======================================
// AUTOMAPPER
// ======================================

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


// ======================================
// DEPENDENCY INJECTION
// ======================================

// REPOSITORIES
builder.Services.AddScoped<IAlunoRepositorio, AlunoRepositorio>();
builder.Services.AddScoped<IPlanoRepositorio, PlanoRepositorio>();
builder.Services.AddScoped<ITamanhoRepositorio, TamanhoRepositorio>();
builder.Services.AddScoped<ITipo_ProdutoRepositorio, Tipo_ProdutoRepositorio>();
builder.Services.AddScoped<IVinculoRepositorio, VinculoRepositorio>();
builder.Services.AddScoped<IModalidadeRepositorio, ModalidadeRepositorio>();
builder.Services.AddScoped<IProfessorRepositorio, ProfessorRepositorio>();
builder.Services.AddScoped<IGraduacaoRepositorio, GraduacaoRepositorio>();
builder.Services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
builder.Services.AddScoped<IMatriculaRepositorio, MatriculaRepositorio>();

// SERVICES
builder.Services.AddScoped<IAlunoService, AlunoService>();
builder.Services.AddScoped<IPlanoService, PlanoService>();
builder.Services.AddScoped<ITamanhoService, TamanhoService>();
builder.Services.AddScoped<ITipo_ProdutoService, Tipo_ProdutoService>();
builder.Services.AddScoped<IVinculoService, VinculoService>();
builder.Services.AddScoped<IModalidadeService, ModalidadeService>();
builder.Services.AddScoped<IProfessorService, ProfessorService>();
builder.Services.AddScoped<IGraduacaoService, GraduacaoService>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();
builder.Services.AddScoped<IMatriculaService, MatriculaService>();

// ======================================
// BUILD APP
// ======================================

var app = builder.Build();


// ======================================
// MIDDLEWARES
// ======================================

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();