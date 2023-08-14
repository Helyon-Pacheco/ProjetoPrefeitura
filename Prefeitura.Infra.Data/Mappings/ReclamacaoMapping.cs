using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prefeitura.Core.Entities;

namespace Prefeitura.Infra.Data.Mappings;

public class ReclamacaoMapping : IEntityTypeConfiguration<Reclamacao>
{
    public void Configure(EntityTypeBuilder<Reclamacao> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Descricao).IsRequired().HasMaxLength(1000);
        builder.Property(c => c.Data).IsRequired();
        builder.Property(c => c.Status).IsRequired().HasMaxLength(100);
        builder.Property(c => c.Observacao).HasMaxLength(1000);
        builder.Property(c => c.Tipo).IsRequired().HasMaxLength(100);
        builder.Property(c => c.TipoReclamacao).IsRequired().HasMaxLength(100);
        builder.Property(c => c.TipoSolicitacao).IsRequired().HasMaxLength(100);
        builder.Property(c => c.TipoServico).IsRequired().HasMaxLength(100);
        builder.Property(c => c.TipoOcorrencia).IsRequired().HasMaxLength(100);
        builder.Property(c => c.TipoSolicitante).IsRequired().HasMaxLength(100);
        builder.Property(c => c.DataAtualizacao).IsRequired();
        builder.Property(c => c.DataCriacao).IsRequired();
        builder.Property(c => c.Ativo).IsRequired();
        builder.Property(c => c.CidadaoId).IsRequired();
        builder.OwnsOne(c => c.TipoEndereco, cm =>
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
