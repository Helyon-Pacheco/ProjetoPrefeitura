using Prefeitura.Core.Entities;

namespace Prefeitura.Core.Repositories;

public interface ICidadaoRepository
{
    Task<Cidadao> ObterPorIdAsync(Guid id);
    Task<Cidadao> ObterPorCpfAsync(string cpf);
    Task<Cidadao> ObterPorEmailAsync(string email);
    Task<IEnumerable<Cidadao>> ObterTodosAsync();
    Task<IEnumerable<Cidadao>> ObterTodosAtivosAsync();
    Task<IEnumerable<Cidadao>> ObterTodosInativosAsync();
    Task<IEnumerable<Cidadao>> ObterTodosPorFamiliaAsync(Guid familiaId);
    Task<IEnumerable<Cidadao>> ObterTodosAtivosPorFamiliaAsync(Guid familiaId);
    Task<IEnumerable<Cidadao>> ObterTodosInativosPorFamiliaAsync(Guid familiaId);
    Task<Cidadao> Adicionar(Cidadao cidadao);
    Task<Cidadao> Atualizar(Cidadao cidadao);
    Task<Cidadao> Remover(Cidadao cidadao);
}
