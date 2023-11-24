using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prefeitura.Core.Entities;

namespace Prefeitura.Infra.Data.Mappings;

public class PropriedadeMapping : IEntityTypeConfiguration<Propriedade>
{
    public void Configure(EntityTypeBuilder<Propriedade> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Nome).IsRequired().HasMaxLength(100);
        builder.Property(c => c.Descricao).IsRequired().HasMaxLength(100);
        builder.Property(c => c.ValorAvaliado).IsRequired().HasColumnType("decimal(18,2)");
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
