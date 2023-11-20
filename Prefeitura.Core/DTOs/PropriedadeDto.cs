using Prefeitura.Core.ValueObjects;

namespace Prefeitura.Core.DTOs;

public class PropriedadeDto
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public EnderecoDto Endereco { get; set; }
    public decimal ValorAvaliado { get; set; }

    public PropriedadeDto() { }
}

