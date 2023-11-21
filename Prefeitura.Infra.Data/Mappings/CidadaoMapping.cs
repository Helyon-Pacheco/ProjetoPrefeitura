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
        builder.Property(c => c.DataAtualizacao).IsRequired(false); // Se for opcional
        builder.Property(c => c.DataCriacao).IsRequired();
        builder.Property(c => c.Ativo).IsRequired();

        builder.OwnsOne(c => c.Endereco, endereco =>
        {
            endereco.Property(e => e.Logradouro).IsRequired().HasMaxLength(100);
            endereco.Property(e => e.Numero).IsRequired().HasMaxLength(10);
            endereco.Property(e => e.Complemento).HasMaxLength(100);
            endereco.Property(e => e.Bairro).IsRequired().HasMaxLength(100);
            endereco.Property(e => e.Cidade).IsRequired().HasMaxLength(100);
            endereco.Property(e => e.Estado).IsRequired().HasMaxLength(2);
        });

        builder.HasOne(c => c.Familia)
               .WithMany(f => f.Membros)
               .HasForeignKey(c => c.FamiliaId)
               .OnDelete(DeleteBehavior.Restrict); // Evita exclusão em cascata
    }
}
