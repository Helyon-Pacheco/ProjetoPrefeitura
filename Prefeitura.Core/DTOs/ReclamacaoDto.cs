using Prefeitura.Core.ValueObjects;

namespace Prefeitura.Core.DTOs;

public class ReclamacaoDto
{
    public Guid Id { get; set; }
    public string Descricao { get; set; }
    public DateTime Data { get; set; }
    public string Status { get; set; }
    public string Observacao { get; set; }
    public string Tipo { get; set; }
    public string TipoReclamacao { get; set; }
    public string TipoSolicitacao { get; set; }
    public string TipoServico { get; set; }
    public string TipoOcorrencia { get; set; }
    public string TipoSolicitante { get; set; }
    public EnderecoDto TipoEndereco { get; set; }
    public Guid CidadaoId { get; set; }
    public DateTime DataAtualizacao { get; set; }
    public DateTime DataCriacao { get; set; }

    public ReclamacaoDto() { }
}
