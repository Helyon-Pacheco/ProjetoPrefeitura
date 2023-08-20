using Prefeitura.Api.Interfaces;
using Prefeitura.Core.Entities;
using Prefeitura.Core.Repositories;
using Prefeitura.Core.ValueObjects;

namespace Prefeitura.Api.Services;

public class ReclamacaoService : IReclamacaoService
{
    private readonly IReclamacaoRepository _reclamacaoRepository;

    public ReclamacaoService(IReclamacaoRepository reclamacaoRepository)
    {
        _reclamacaoRepository = reclamacaoRepository;
    }

    public async Task<Reclamacao> ObterPorIdAsync(Guid id)
    {
        return await _reclamacaoRepository.ObterPorIdAsync(id);
    }

    public async Task<IEnumerable<Reclamacao>> ObterTodosAsync()
    {
        return await _reclamacaoRepository.ObterTodosAsync();
    }

    public async Task<IEnumerable<Reclamacao>> ObterPorDescricaoAsync(string descricao)
    {
        return await _reclamacaoRepository.ObterPorDescricaoAsync(descricao);
    }

    public async Task<IEnumerable<Reclamacao>> ObterPorDataAsync(DateTime data)
    {
        return await _reclamacaoRepository.ObterPorDataAsync(data);
    }

    public async Task<IEnumerable<Reclamacao>> ObterPorStatusAsync(string status)
    {
        return await _reclamacaoRepository.ObterPorStatusAsync(status);
    }

    public async Task<IEnumerable<Reclamacao>> ObterPorObservacaoAsync(string observacao)
    {
        return await _reclamacaoRepository.ObterPorObservacaoAsync(observacao);
    }

    public async Task<IEnumerable<Reclamacao>> ObterPorTipoAsync(string tipo)
    {
        return await _reclamacaoRepository.ObterPorTipoAsync(tipo);
    }

    public async Task<IEnumerable<Reclamacao>> ObterPorTipoReclamacaoAsync(string tipoReclamacao)
    {
        return await _reclamacaoRepository.ObterPorTipoReclamacaoAsync(tipoReclamacao);
    }

    public async Task<IEnumerable<Reclamacao>> ObterPorTipoSolicitacaoAsync(string tipoSolicitacao)
    {
        return await _reclamacaoRepository.ObterPorTipoSolicitacaoAsync(tipoSolicitacao);
    }

    public async Task<IEnumerable<Reclamacao>> ObterPorTipoServicoAsync(string tipoServico)
    {
        return await _reclamacaoRepository.ObterPorTipoServicoAsync(tipoServico);
    }

    public async Task<IEnumerable<Reclamacao>> ObterPorTipoOcorrenciaAsync(string tipoOcorrencia)
    {
        return await _reclamacaoRepository.ObterPorTipoOcorrenciaAsync(tipoOcorrencia);
    }

    public async Task<IEnumerable<Reclamacao>> ObterPorTipoSolicitanteAsync(string tipoSolicitante)
    {
        return await _reclamacaoRepository.ObterPorTipoSolicitanteAsync(tipoSolicitante);
    }

    public async Task<IEnumerable<Reclamacao>> ObterPorTipoEnderecoAsync(Endereco tipoEndereco)
    {
        return await _reclamacaoRepository.ObterPorTipoEnderecoAsync(tipoEndereco);
    }

    public async Task<Reclamacao> AdicionarReclamacaoAsync(Reclamacao reclamacao)
    {
        return await _reclamacaoRepository.Adicionar(reclamacao);
    }

    public async Task<Reclamacao> AtualizarReclamacaoAsync(Reclamacao reclamacao)
    {
        return await _reclamacaoRepository.Atualizar(reclamacao);
    }

    public async Task<Reclamacao> RemoverReclamacaoAsync(Reclamacao reclamacao)
    {
        return await _reclamacaoRepository.Remover(reclamacao);
    }
}
