using Prefeitura.Core.Entities;

namespace Prefeitura.Core.Aggregates;

public class Familia
{
    public Guid Id { get; private set; }
    public ICollection<Cidadao> Membros { get; private set; }

    public Familia()
    {
        Membros = new List<Cidadao>();
    }

    public void AdicionarMembro(Cidadao cidadao)
    {
        Membros.Add(cidadao);
    }
}
