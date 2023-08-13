using Prefeitura.Core.ValueObjects;

namespace Prefeitura.Core.Entities;

public class Propriedade
{
    public Guid Id { get; private set; }
    public string Nome { get; private set; }
    public string Descricao { get; private set; }
    public Endereco Endereco { get; private set; }
    public string Cep { get; private set; }
    public decimal ValorAvaliado { get; private set; }

    // Constutro privado para o Entity Framework
    private Propriedade() { }
}
