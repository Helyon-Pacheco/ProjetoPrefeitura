using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Prefeitura.Core.DTOs;

public class CidadaoDto
{
    [ReadOnly(true)]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "O campo Nome é obrigatório.")]
    [StringLength(100, ErrorMessage = "O campo Nome deve ter no máximo 100 caracteres.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O campo CPF é obrigatório.")]
    [StringLength(11, ErrorMessage = "O campo CPF deve ter no máximo 11 caracteres.")]
    public string Cpf { get; set; }

    [Required(ErrorMessage = "O campo DataNascimento é obrigatório.")]
    public DateTime DataNascimento { get; set; }

    [Required(ErrorMessage = "O campo Email é obrigatório.")]
    [StringLength(100, ErrorMessage = "O campo Email deve ter no máximo 100 caracteres.")]
    [EmailAddress(ErrorMessage = "O campo Email não possui um formato válido.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "O campo Telefone é obrigatório.")]
    [StringLength(11, ErrorMessage = "O campo Telefone deve ter no máximo 11 caracteres.")]
    public string Telefone { get; set; }

    public EnderecoDto Endereco { get; set; }
}
