using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Prefeitura.Api.Interfaces;
using Prefeitura.Api.Services;
using Prefeitura.Core.Repositories;
using Prefeitura.Infra.Data.Context;
using Prefeitura.Infra.Data.Repositories;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Inicializa o Serilog
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Host.UseSerilog(); // Use Serilog como o provedor de logging
builder.Services.AddDbContext<PrefeituraContext>(options =>
    options.UseSqlServer(connectionString));

// Adicionando o Swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Prefeitura API", Version = "v1" });
});

// Adiciona o AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<ICidadaoRepository, CidadaoRepository>();
builder.Services.AddScoped<ICidadaoService, CidadaoService>();
builder.Services.AddScoped<IEmpresaRepository, EmpresaRepository>();
builder.Services.AddScoped<IEmpresaService, EmpresaService>();
builder.Services.AddScoped<IPropriedadeRepository, PropriedadeRepository>();
builder.Services.AddScoped<IPropriedadeService, PropriedadeService>();
builder.Services.AddScoped<IReclamacaoRepository, ReclamacaoRepository>();
builder.Services.AddScoped<IReclamacaoService, ReclamacaoService>();
builder.Services.AddScoped<IServicoMunicipalRepository, ServicoMunicipalRepository>();
builder.Services.AddScoped<IServicoMunicipalService, ServicoMunicipalService>();

builder.Services.AddControllers();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Prefeitura API v1"));
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Prefeitura API v1"));

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();
app.MapRazorPages();

app.Run();