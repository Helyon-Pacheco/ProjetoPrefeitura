using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prefeitura.Core.Entities;

namespace Prefeitura.Infra.Data.Mappings;

public class ServicoMunicipalMapping : IEntityTypeConfiguration<ServicoMunicipal>
{
    public void Configure(EntityTypeBuilder<ServicoMunicipal> builder)
    {
        builder.HasKey(s => s.Id);
        builder.Property(s => s.Nome).IsRequired().HasMaxLength(100);
        builder.Property(s => s.Descricao).IsRequired().HasMaxLength(100);
        builder.Property(s => s.Valor).IsRequired();
        builder.Property(s => s.ValorMulta).IsRequired();
        builder.Property(s => s.ValorJuros).IsRequired();
        builder.Property(s => s.ValorTotal).IsRequired();
        builder.Property(s => s.DataVencimento).IsRequired();
        builder.Property(s => s.DataPagamento).IsRequired();
        builder.Property(s => s.Pago).IsRequired();
        builder.Property(s => s.DataAtualizacao).IsRequired();
        builder.Property(s => s.DataCriacao).IsRequired();
    }
}
