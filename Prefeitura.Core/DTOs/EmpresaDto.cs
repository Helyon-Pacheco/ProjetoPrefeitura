using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Prefeitura.Core.DTOs;

public class EmpresaDto
{
    [ReadOnly(true)]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "O campo Nome é obrigatório.")]
    [StringLength(100, ErrorMessage = "O campo Nome deve ter no máximo 100 caracteres.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O campo CNPJ é obrigatório.")]
    [StringLength(14, ErrorMessage = "O campo CNPJ deve ter no máximo 14 caracteres.")]
    public string CNPJ { get; set; }

    [Required(ErrorMessage = "O campo InscricaoEstadual é obrigatório.")]
    [StringLength(20, ErrorMessage = "O campo InscricaoEstadual deve ter no máximo 20 caracteres.")]
    public string InscricaoEstadual { get; set; }

    [Required(ErrorMessage = "O campo InscricaoMunicipal é obrigatório.")]
    [StringLength(20, ErrorMessage = "O campo InscricaoMunicipal deve ter no máximo 20 caracteres.")]
    public string InscricaoMunicipal { get; set; }

    [Required(ErrorMessage = "O campo Telefone é obrigatório.")]
    [StringLength(11, ErrorMessage = "O campo Telefone deve ter no máximo 11 caracteres.")]
    public string Telefone { get; set; }

    [Required(ErrorMessage = "O campo Email é obrigatório.")]
    [StringLength(100, ErrorMessage = "O campo Email deve ter no máximo 100 caracteres.")]
    [EmailAddress(ErrorMessage = "O campo Email não possui um formato válido.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "O campo Responsavel é obrigatório.")]
    [StringLength(100, ErrorMessage = "O campo Responsavel deve ter no máximo 100 caracteres.")]
    public string Responsavel { get; set; }

    [Required(ErrorMessage = "O campo TelefoneResponsavel é obrigatório.")]
    [StringLength(11, ErrorMessage = "O campo TelefoneResponsavel deve ter no máximo 11 caracteres.")]
    public string TelefoneResponsavel { get; set; }

    [Required(ErrorMessage = "O campo EmailResponsavel é obrigatório.")]
    [StringLength(100, ErrorMessage = "O campo EmailResponsavel deve ter no máximo 100 caracteres.")]
    [EmailAddress(ErrorMessage = "O campo EmailResponsavel não possui um formato válido.")]
    public string EmailResponsavel { get; set; }

    public EnderecoDto Endereco { get; set; }
}
