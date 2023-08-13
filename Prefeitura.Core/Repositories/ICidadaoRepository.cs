using Prefeitura.Core.Entities;

namespace Prefeitura.Core.Repositories;

public interface ICidadaoRepository
{
    Task<Cidadao> ObterPorId(Guid id);
    Task<Cidadao> ObterPorCpf(string cpf);
    Task<IEnumerable<Cidadao>> ObterTodos();
    Task<IEnumerable<Cidadao>> ObterTodosAtivos();
    Task<IEnumerable<Cidadao>> ObterTodosInativos();
    Task<IEnumerable<Cidadao>> ObterTodosPorFamilia(Guid familiaId);
    Task<IEnumerable<Cidadao>> ObterTodosAtivosPorFamilia(Guid familiaId);
    Task<IEnumerable<Cidadao>> ObterTodosInativosPorFamilia(Guid familiaId);
    Task Adicionar(Cidadao cidadao);
    Task Atualizar(Cidadao cidadao);
    Task Remover(Cidadao cidadao);
}
