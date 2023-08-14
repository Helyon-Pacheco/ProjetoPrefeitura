using Prefeitura.Core.ValueObjects;

namespace Prefeitura.Core.Entities;

public class Empresa
{
    public Guid Id { get; private set; }
    public string Nome { get; private set; }
    public string CNPJ { get; private set; }
    public string InscricaoEstadual { get; private set; }
    public string InscricaoMunicipal { get; private set; }
    public string Telefone { get; private set; }
    public string Email { get; private set; }
    public string Responsavel { get; private set; }
    public string TelefoneResponsavel { get; private set; }
    public string EmailResponsavel { get; private set; }
    public Endereco Endereco { get; private set; }

    // Construtor privado para o Entity Framework
    private Empresa() { }
}
