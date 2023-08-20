using Prefeitura.Api.Interfaces;
using Prefeitura.Core.Entities;
using Prefeitura.Core.Repositories;
using Prefeitura.Core.ValueObjects;

namespace Prefeitura.Api.Services;

public class PropriedadeService : IPropriedadeService
{
    private readonly IPropriedadeRepository _propriedadeRepository;

    public PropriedadeService(IPropriedadeRepository propriedadeRepository)
    {
        _propriedadeRepository = propriedadeRepository;
    }

    public async Task<Propriedade> AdicionarPropriedadeAsync(Propriedade propriedade)
    {
        return await _propriedadeRepository.Adicionar(propriedade);
    }

    public async Task<Propriedade> AtualizarPropriedadeAsync(Propriedade propriedade)
    {
        return await _propriedadeRepository.Atualizar(propriedade);
    }

    public async Task<Propriedade> RemoverPropriedadeAsync(Propriedade propriedade)
    {
        return await _propriedadeRepository.Remover(propriedade);
    }

    public async Task<Propriedade> ObterPorIdAsync(Guid id)
    {
        return await _propriedadeRepository.ObterPorIdAsync(id);
    }

    public async Task<IEnumerable<Propriedade>> ObterPorCepAsync(string cep)
    {
        return await _propriedadeRepository.ObterPorCepAsync(cep);
    }

    public async Task<IEnumerable<Propriedade>> ObterPorDescricaoAsync(string descricao)
    {
        return await _propriedadeRepository.ObterPorDescricaoAsync(descricao);
    }

    public async Task<IEnumerable<Propriedade>> ObterPorEnderecoAsync(Endereco endereco)
    {
        return await _propriedadeRepository.ObterPorEnderecoAsync(endereco);
    }

    public async Task<IEnumerable<Propriedade>> ObterPorNomeAsync(string nome)
    {
        return await _propriedadeRepository.ObterPorNomeAsync(nome);
    }

    public async Task<IEnumerable<Propriedade>> ObterPorValorAvaliadoAsync(decimal valorAvaliado)
    {
        return await _propriedadeRepository.ObterPorValorAvaliadoAsync(valorAvaliado);
    }

    public async Task<IEnumerable<Propriedade>> ObterTodosAsync()
    {
        return await _propriedadeRepository.ObterTodosAsync();
    }
}
