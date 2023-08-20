using Prefeitura.Core.Entities;
using Prefeitura.Core.ValueObjects;

namespace Prefeitura.Api.Interfaces;

public interface IPropriedadeService
{
    Task<Propriedade> ObterPorIdAsync(Guid id);
    Task<IEnumerable<Propriedade>> ObterTodosAsync();
    Task<IEnumerable<Propriedade>> ObterPorNomeAsync(string nome);
    Task<IEnumerable<Propriedade>> ObterPorDescricaoAsync(string descricao);
    Task<IEnumerable<Propriedade>> ObterPorEnderecoAsync(Endereco endereco);
    Task<IEnumerable<Propriedade>> ObterPorCepAsync(string cep);
    Task<IEnumerable<Propriedade>> ObterPorValorAvaliadoAsync(decimal valorAvaliado);
    Task<Propriedade> AdicionarPropriedadeAsync(Propriedade propriedade);
    Task<Propriedade> AtualizarPropriedadeAsync(Propriedade propriedade);
    Task<Propriedade> RemoverPropriedadeAsync(Propriedade propriedade);
}
