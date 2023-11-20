using Prefeitura.Core.ValueObjects;

namespace Prefeitura.Core.DTOs;

public class EmpresaDto
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string CNPJ { get; set; }
    public string InscricaoEstadual { get; set; }
    public string InscricaoMunicipal { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public string Responsavel { get; set; }
    public string TelefoneResponsavel { get; set; }
    public string EmailResponsavel { get; set; }
    public EnderecoDto Endereco { get; set; }

    public EmpresaDto() { }
}
