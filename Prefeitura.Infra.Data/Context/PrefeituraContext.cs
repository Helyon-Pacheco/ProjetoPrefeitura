using Microsoft.EntityFrameworkCore;
using Prefeitura.Core.Aggregates;
using Prefeitura.Core.Entities;
using Prefeitura.Core.ValueObjects;
using Prefeitura.Infra.Data.Mappings;

namespace Prefeitura.Infra.Data.Context;

public class PrefeituraContext : DbContext
{
    public DbSet<Cidadao> Cidadaos { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Propriedade> Propriedades { get; set;}
    public DbSet<Empresa> Empresas { get; set; }
    public DbSet<Familia> Familias { get; set; }
    public DbSet<ServicoMunicipal> Servicos { get; set; }
    public DbSet<Reclamacao> Reclamacoes { get; set;}

    public PrefeituraContext(DbContextOptions<PrefeituraContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CidadaoMapping());
        modelBuilder.ApplyConfiguration(new PropriedadeMapping());
        modelBuilder.ApplyConfiguration(new EmpresaMapping());
        modelBuilder.ApplyConfiguration(new ServicoMunicipalMapping());
        modelBuilder.ApplyConfiguration(new ReclamacaoMapping());
    }
}
