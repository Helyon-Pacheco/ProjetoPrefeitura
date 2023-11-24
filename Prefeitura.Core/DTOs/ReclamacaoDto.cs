using Prefeitura.Core.ValueObjects;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Prefeitura.Core.DTOs;

public class ReclamacaoDto
{
    [ReadOnly(true)]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "A descrição é obrigatória.")]
    [StringLength(1000, ErrorMessage = "A descrição deve ter no máximo 1000 caracteres.")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "A data é obrigatória.")]
    public DateTime Data { get; set; }

    [Required(ErrorMessage = "O status é obrigatório.")]
    [StringLength(100, ErrorMessage = "O status deve ter no máximo 100 caracteres.")]
    public string Status { get; set; }

    [StringLength(1000, ErrorMessage = "A observação deve ter no máximo 1000 caracteres.")]
    public string Observacao { get; set; }

    [Required(ErrorMessage = "O tipo é obrigatório.")]
    [StringLength(100, ErrorMessage = "O tipo deve ter no máximo 100 caracteres.")]
    public string Tipo { get; set; }

    [Required(ErrorMessage = "O tipo de reclamação é obrigatório.")]
    [StringLength(100, ErrorMessage = "O tipo de reclamação deve ter no máximo 100 caracteres.")]
    public string TipoReclamacao { get; set; }

    [Required(ErrorMessage = "O tipo de solicitação é obrigatório.")]
    [StringLength(100, ErrorMessage = "O tipo de solicitação deve ter no máximo 100 caracteres.")]
    public string TipoSolicitacao { get; set; }

    [Required(ErrorMessage = "O tipo de serviço é obrigatório.")]
    [StringLength(100, ErrorMessage = "O tipo de serviço deve ter no máximo 100 caracteres.")]
    public string TipoServico { get; set; }

    [Required(ErrorMessage = "O tipo de ocorrência é obrigatório.")]
    [StringLength(100, ErrorMessage = "O tipo de ocorrência deve ter no máximo 100 caracteres.")]
    public string TipoOcorrencia { get; set; }

    [Required(ErrorMessage = "O tipo de solicitante é obrigatório.")]
    [StringLength(100, ErrorMessage = "O tipo de solicitante deve ter no máximo 100 caracteres.")]
    public string TipoSolicitante { get; set; }

    public EnderecoDto TipoEndereco { get; set; }

    public Guid CidadaoId { get; set; }

    public ReclamacaoDto() { }
}
