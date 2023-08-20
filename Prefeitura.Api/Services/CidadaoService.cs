using Prefeitura.Api.Interfaces;
using Prefeitura.Core.Entities;
using Prefeitura.Core.Repositories;

namespace Prefeitura.Api.Services;

public class CidadaoService : ICidadaoService
{
    private readonly ICidadaoRepository _cidadaoRepository;

    public CidadaoService(ICidadaoRepository cidadaoRepository)
    {
        _cidadaoRepository = cidadaoRepository;
    }

    public async Task<Cidadao> ObterCidadaoPorIdAsync(Guid id)
    {
        return await _cidadaoRepository.ObterPorIdAsync(id);
    }

    public async Task<IEnumerable<Cidadao>> ObterCidadaosAsync()
    {
        return await _cidadaoRepository.ObterTodosAsync();
    }

    public async Task<Cidadao> ObterCidadaoPorCpfAsync(string cpf)
    {
        return await _cidadaoRepository.ObterPorCpfAsync(cpf);
    }

    public async Task<Cidadao> ObterCidadaoPorEmailAsync(string email)
    {
        return await _cidadaoRepository.ObterPorEmailAsync(email);
    }

    public async Task<IEnumerable<Cidadao>> ObterCidadaosPorFamilia(Guid familiaId)
    {
        return await _cidadaoRepository.ObterTodosPorFamiliaAsync(familiaId);
    }

    public async Task<IEnumerable<Cidadao>> ObterCidadaosAtivosAsync()
    {
        return await _cidadaoRepository.ObterTodosAtivosAsync();
    }

    public async Task<IEnumerable<Cidadao>> ObterCidadaosInativosAsync()
    {
        return await _cidadaoRepository.ObterTodosInativosAsync();
    }

    public async Task<Cidadao> AdicionarCidadaoAsync(Cidadao cidadao)
    {
        return await _cidadaoRepository.Adicionar(cidadao);
    }

    public async Task<Cidadao> AtualizarCidadaoAsync(Cidadao cidadao)
    {
        return await _cidadaoRepository.Atualizar(cidadao);
    }

    public async Task<Cidadao> RemoverCidadaoAsync(Cidadao cidadao)
    {
        return await _cidadaoRepository.Remover(cidadao);
    }
}
