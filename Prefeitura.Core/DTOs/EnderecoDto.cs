using System.ComponentModel.DataAnnotations;

namespace Prefeitura.Core.DTOs;

public class EnderecoDto
{
    [Required(ErrorMessage = "O campo Logradouro é obrigatório.")]
    [StringLength(100, ErrorMessage = "O campo Logradouro deve ter no máximo 100 caracteres.")]
    public string Logradouro { get; set; }

    [Required(ErrorMessage = "O campo Número é obrigatório.")]
    [StringLength(10, ErrorMessage = "O campo Número deve ter no máximo 10 caracteres.")]
    public string Numero { get; set; }

    [StringLength(100, ErrorMessage = "O campo Complemento deve ter no máximo 100 caracteres.")]
    public string Complemento { get; set; }

    [Required(ErrorMessage = "O campo Bairro é obrigatório.")]
    [StringLength(100, ErrorMessage = "O campo Bairro deve ter no máximo 100 caracteres.")]
    public string Bairro { get; set; }

    [Required(ErrorMessage = "O campo Cidade é obrigatório.")]
    [StringLength(100, ErrorMessage = "O campo Cidade deve ter no máximo 100 caracteres.")]
    public string Cidade { get; set; }

    [Required(ErrorMessage = "O campo Estado é obrigatório.")]
    [StringLength(2, ErrorMessage = "O campo Estado deve ter no máximo 2 caracteres.")]
    public string Estado { get; set; }

    [StringLength(8, ErrorMessage = "O campo CEP deve ter no máximo 8 caracteres.")]
    public string Cep { get; set; }
}
