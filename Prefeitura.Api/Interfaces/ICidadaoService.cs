using Prefeitura.Core.Entities;

namespace Prefeitura.Api.Interfaces;

public interface ICidadaoService
{
    Task<Cidadao> ObterCidadaoPorIdAsync(Guid id);
    Task<IEnumerable<Cidadao>> ObterCidadaosAsync();
    Task<Cidadao> ObterCidadaoPorCpfAsync(string cpf);
    Task<Cidadao> ObterCidadaoPorEmailAsync(string email);
    Task<IEnumerable<Cidadao>> ObterCidadaosPorFamilia(Guid familiaId);
    Task<IEnumerable<Cidadao>> ObterCidadaosAtivosAsync();
    Task<IEnumerable<Cidadao>> ObterCidadaosInativosAsync();
    Task<Cidadao> AdicionarCidadaoAsync(Cidadao cidadao);
    Task<Cidadao> AtualizarCidadaoAsync(Cidadao cidadao);
    Task<Cidadao> RemoverCidadaoAsync(Cidadao cidadao);
}
