using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Prefeitura.Core.DTOs;

public class ServicoMunicipalDto
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório.")]
    [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "A descrição é obrigatória.")]
    [StringLength(100, ErrorMessage = "A descrição deve ter no máximo 100 caracteres.")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "O valor é obrigatório.")]
    public decimal Valor { get; set; }

    [Required(ErrorMessage = "O valor da multa é obrigatório.")]
    public decimal ValorMulta { get; set; }

    [Required(ErrorMessage = "O valor dos juros é obrigatório.")]
    public decimal ValorJuros { get; set; }

    [Required(ErrorMessage = "O valor total é obrigatório.")]
    public decimal ValorTotal { get; set; }

    [Required(ErrorMessage = "A data de vencimento é obrigatória.")]
    public DateTime DataVencimento { get; set; }

    [Required(ErrorMessage = "A data de pagamento é obrigatória.")]
    public DateTime DataPagamento { get; set; }

    [Required(ErrorMessage = "O campo pago é obrigatório.")]
    public bool Pago { get; set; }

    public Guid EmpresaId { get; set; }

    public Guid PropriedadeId { get; set; }

    public Guid CidadaoId { get; set; }

    public Guid ReclamacaoId { get; set; }

    public string Status { get; set; }
    public string Observacao { get; set; }
    public string Tipo { get; set; }

    public ServicoMunicipalDto() { }
}
