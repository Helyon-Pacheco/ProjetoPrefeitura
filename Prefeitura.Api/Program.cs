using Microsoft.EntityFrameworkCore;
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

builder.Host.UseSerilog(); // Use Serilog como o provedor de logging

var app = builder.Build();

builder.Services.AddDbContext<PrefeituraContext>(options =>
    options.UseSqlServer("YourConnectionStringHere"));

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


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();
app.MapRazorPages();

app.Run();
