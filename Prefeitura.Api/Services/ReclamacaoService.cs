using AutoMapper;
using Prefeitura.Api.Interfaces;
using Prefeitura.Core.DTOs;
using Prefeitura.Core.Entities;
using Prefeitura.Core.Repositories;
using Prefeitura.Core.ValueObjects;

namespace Prefeitura.Api.Services;

public class ReclamacaoService : IReclamacaoService
{
    private readonly IReclamacaoRepository _reclamacaoRepository;
    private readonly IMapper _mapper;

    public ReclamacaoService(IReclamacaoRepository reclamacaoRepository, IMapper mapper)
    {
        _reclamacaoRepository = reclamacaoRepository;
        _mapper = mapper;
    }

    public async Task<ReclamacaoDto> AdicionarReclamacaoAsync(ReclamacaoDto reclamacaoDto)
    {
        var reclamacao = _mapper.Map<Reclamacao>(reclamacaoDto);
        var resultado = await _reclamacaoRepository.Adicionar(reclamacao);
        return _mapper.Map<ReclamacaoDto>(resultado);
    }

    public async Task<ReclamacaoDto> AtualizarReclamacaoAsync(ReclamacaoDto reclamacaoDto)
    {
        var reclamacaoExistente = await _reclamacaoRepository.ObterPorIdAsync(reclamacaoDto.Id);
        if (reclamacaoExistente == null)
        {
            return null;
        }
        var reclamacao = _mapper.Map<Reclamacao>(reclamacaoDto);
        var resultado = await _reclamacaoRepository.Atualizar(reclamacao);
        return _mapper.Map<ReclamacaoDto>(resultado);
    }

    public async Task<ReclamacaoDto> RemoverReclamacaoAsync(ReclamacaoDto reclamacaoDto)
    {
        var reclamacao = _mapper.Map<Reclamacao>(reclamacaoDto);
        var resultado = await _reclamacaoRepository.Remover(reclamacao);
        return _mapper.Map<ReclamacaoDto>(resultado);
    }

    public async Task<ReclamacaoDto> ObterPorIdAsync(Guid id)
    {
        var reclamacao = await _reclamacaoRepository.ObterPorIdAsync(id);
        return _mapper.Map<ReclamacaoDto>(reclamacao);
    }

    public async Task<IEnumerable<ReclamacaoDto>> ObterTodosAsync()
    {
        var reclamacoes = await _reclamacaoRepository.ObterTodosAsync();
        return _mapper.Map<IEnumerable<ReclamacaoDto>>(reclamacoes);
    }

    public async Task<IEnumerable<ReclamacaoDto>> ObterPorDescricaoAsync(string descricao)
    {
        var reclamacao = await _reclamacaoRepository.ObterPorDescricaoAsync(descricao);
        return _mapper.Map<IEnumerable<ReclamacaoDto>>(reclamacao);
    }

    public async Task<IEnumerable<ReclamacaoDto>> ObterPorDataAsync(DateTime data)
    {
        var reclamacao = await _reclamacaoRepository.ObterPorDataAsync(data);
        return _mapper.Map<IEnumerable<ReclamacaoDto>>(reclamacao);
    }

    public async Task<IEnumerable<ReclamacaoDto>> ObterPorStatusAsync(string status)
    {
        var reclamacao = await _reclamacaoRepository.ObterPorStatusAsync(status);
        return _mapper.Map<IEnumerable<ReclamacaoDto>>(reclamacao);
    }

    public async Task<IEnumerable<ReclamacaoDto>> ObterPorObservacaoAsync(string observacao)
    {
        var reclamacao = await _reclamacaoRepository.ObterPorObservacaoAsync(observacao);
        return _mapper.Map<IEnumerable<ReclamacaoDto>>(reclamacao);
    }

    public async Task<IEnumerable<ReclamacaoDto>> ObterPorTipoAsync(string tipo)
    {
        var reclamacao = await _reclamacaoRepository.ObterPorTipoAsync(tipo);
        return _mapper.Map<IEnumerable<ReclamacaoDto>>(reclamacao);
    }

    public async Task<IEnumerable<ReclamacaoDto>> ObterPorTipoReclamacaoAsync(string tipoReclamacao)
    {
        var reclamacao = await _reclamacaoRepository.ObterPorTipoReclamacaoAsync(tipoReclamacao);
        return _mapper.Map<IEnumerable<ReclamacaoDto>>(reclamacao);
    }

    public async Task<IEnumerable<ReclamacaoDto>> ObterPorTipoSolicitacaoAsync(string tipoSolicitacao)
    {
        var reclamacao = await _reclamacaoRepository.ObterPorTipoSolicitacaoAsync(tipoSolicitacao);
        return _mapper.Map<IEnumerable<ReclamacaoDto>>(reclamacao);
    }

    public async Task<IEnumerable<ReclamacaoDto>> ObterPorTipoServicoAsync(string tipoServico)
    {
        var reclamacao = await _reclamacaoRepository.ObterPorTipoServicoAsync(tipoServico);
        return _mapper.Map<IEnumerable<ReclamacaoDto>>(reclamacao);
    }

    public async Task<IEnumerable<ReclamacaoDto>> ObterPorTipoOcorrenciaAsync(string tipoOcorrencia)
    {
        var reclamacao = await _reclamacaoRepository.ObterPorTipoOcorrenciaAsync(tipoOcorrencia);
        return _mapper.Map<IEnumerable<ReclamacaoDto>>(reclamacao);
    }

    public async Task<IEnumerable<ReclamacaoDto>> ObterPorTipoSolicitanteAsync(string tipoSolicitante)
    {
        var reclamacao = await _reclamacaoRepository.ObterPorTipoSolicitanteAsync(tipoSolicitante);
        return _mapper.Map<IEnumerable<ReclamacaoDto>>(reclamacao);
    }

    public async Task<IEnumerable<ReclamacaoDto>> ObterPorTipoEnderecoAsync(EnderecoDto tipoEnderecoDto)
    {
        var tipoEndereco = _mapper.Map<Endereco>(tipoEnderecoDto);
        var reclamacao = await _reclamacaoRepository.ObterPorTipoEnderecoAsync(tipoEndereco);
        return _mapper.Map<IEnumerable<ReclamacaoDto>>(reclamacao);
    }
}
