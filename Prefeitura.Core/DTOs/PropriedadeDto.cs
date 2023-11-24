using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Prefeitura.Core.DTOs;

public class PropriedadeDto
{
    [ReadOnly(true)]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "O campo Nome é obrigatório.")]
    [StringLength(100, ErrorMessage = "O campo Nome deve ter no máximo 100 caracteres.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
    [StringLength(100, ErrorMessage = "O campo Descrição deve ter no máximo 100 caracteres.")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "O campo Endereço é obrigatório.")]
    public EnderecoDto Endereco { get; set; }

    [Required(ErrorMessage = "O campo Valor Avaliado é obrigatório.")]
    public decimal ValorAvaliado { get; set; }

    public PropriedadeDto() { }
}