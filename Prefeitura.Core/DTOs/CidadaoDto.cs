namespace Prefeitura.Core.DTOs;

public class CidadaoDto
{
    public Guid Id { get; private set; }
    public string Nome { get; private set; }
    public string Cpf { get; private set; }
    public DateTime DataNascimento { get; private set; }
    public string Email { get; private set; }
    public string Telefone { get; private set; }
    public EnderecoDto Endereco { get; private set; }
    public FamiliaDto Familia { get; private set; }
    public Guid FamiliaId { get; private set; }

    public CidadaoDto() { }
}