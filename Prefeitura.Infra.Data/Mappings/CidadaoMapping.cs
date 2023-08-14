using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Prefeitura.Core.Entities;

namespace Prefeitura.Infra.Data.Mappings;

public class CidadaoMapping : IEntityTypeConfiguration<Cidadao>
{
    public void Configure(EntityTypeBuilder<Cidadao> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Nome).IsRequired().HasMaxLength(100);
        builder.Property(c => c.Cpf).IsRequired().HasMaxLength(11);
        builder.Property(c => c.DataNascimento).IsRequired();
        builder.Property(c => c.Email).IsRequired().HasMaxLength(100);
        builder.Property(c => c.Telefone).IsRequired().HasMaxLength(11);
        builder.Property(c => c.DataAtualizacao).IsRequired();
        builder.Property(c => c.DataCriacao).IsRequired();
        builder.Property(c => c.Ativo).IsRequired();
        builder.OwnsOne(c => c.Endereco, cm =>
        {
            cm.Property(c => c.Logradouro).IsRequired().HasMaxLength(100);
            cm.Property(c => c.Numero).IsRequired().HasMaxLength(10);
            cm.Property(c => c.Complemento).HasMaxLength(100);
            cm.Property(c => c.Bairro).IsRequired().HasMaxLength(100);
            cm.Property(c => c.Cidade).IsRequired().HasMaxLength(100);
            cm.Property(c => c.Estado).IsRequired().HasMaxLength(2);
        });
    }
}
