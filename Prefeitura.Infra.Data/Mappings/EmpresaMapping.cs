using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prefeitura.Core.Entities;

namespace Prefeitura.Infra.Data.Mappings;

public class EmpresaMapping : IEntityTypeConfiguration<Empresa>
{
    public void Configure(EntityTypeBuilder<Empresa> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Nome).IsRequired().HasMaxLength(100);
        builder.Property(e => e.CNPJ).IsRequired().HasMaxLength(14);
        builder.Property(e => e.InscricaoEstadual).IsRequired().HasMaxLength(20);
        builder.Property(e => e.InscricaoMunicipal).IsRequired().HasMaxLength(20);
        builder.Property(e => e.Telefone).IsRequired().HasMaxLength(11);
        builder.Property(e => e.Email).IsRequired().HasMaxLength(100);
        builder.Property(e => e.Responsavel).IsRequired().HasMaxLength(100);
        builder.Property(e => e.TelefoneResponsavel).IsRequired().HasMaxLength(11);
        builder.Property(e => e.EmailResponsavel).IsRequired().HasMaxLength(100);
        builder.OwnsOne(e => e.Endereco, cm =>
        {
            cm.Property(e => e.Logradouro).IsRequired().HasMaxLength(100);
            cm.Property(e => e.Numero).IsRequired().HasMaxLength(10);
            cm.Property(e => e.Complemento).HasMaxLength(100);
            cm.Property(e => e.Bairro).IsRequired().HasMaxLength(100);
            cm.Property(e => e.Cidade).IsRequired().HasMaxLength(100);
            cm.Property(e => e.Estado).IsRequired().HasMaxLength(2);
        });
    }
}
