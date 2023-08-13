using Prefeitura.Core.Entities;
using Prefeitura.Core.ValueObjects;

namespace Prefeitura.Core.Repositories;

public interface IPropriedadeRepository
{
    Task<Propriedade> ObterPorIdAsync (Guid id);
    Task<IEnumerable<Propriedade>> ObterTodosAsync ();
    Task<IEnumerable<Propriedade>> ObterPorNomeAsync (string nome);
    Task<IEnumerable<Propriedade>> ObterPorDescricaoAsync (string descricao);
    Task<IEnumerable<Propriedade>> ObterPorEnderecoAsync (Endereco endereco);
    Task<IEnumerable<Propriedade>> ObterPorCepAsync (string cep);
    Task<IEnumerable<Propriedade>> ObterPorValorAvaliadoAsync (decimal valorAvaliado);
}
