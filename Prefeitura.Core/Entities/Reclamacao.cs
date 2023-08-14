using Prefeitura.Core.ValueObjects;

namespace Prefeitura.Core.Entities;

public class Reclamacao
{
    public Guid Id { get; private set; }
    public string Descricao { get; private set; }
    public DateTime Data { get; private set; }
    public string Status { get; private set; }
    public string Observacao { get; private set; }
    public string Tipo { get; private set; }
    public string TipoReclamacao { get; private set; }
    public string TipoSolicitacao { get; private set; }
    public string TipoServico { get; private set; }
    public string TipoOcorrencia { get; private set; }
    public string TipoSolicitante { get; private set; }
    public Endereco TipoEndereco { get; private set; }
    public Guid CidadaoId { get; private set; }
    public DateTime DataAtualizacao { get; private set; }
    public DateTime DataCriacao { get; private set; }
    public bool Ativo { get; private set; }

    // Construtor privado para o Entity Framework
    private Reclamacao() { }
}
