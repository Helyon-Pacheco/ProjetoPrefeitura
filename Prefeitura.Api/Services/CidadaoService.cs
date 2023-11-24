using AutoMapper;
using Prefeitura.Api.Interfaces;
using Prefeitura.Core.DTOs;
using Prefeitura.Core.Entities;
using Prefeitura.Core.Repositories;

namespace Prefeitura.Api.Services;

public class CidadaoService : ICidadaoService
{
    private readonly ICidadaoRepository _cidadaoRepository;
    private readonly IMapper _mapper;

    public CidadaoService(ICidadaoRepository cidadaoRepository, IMapper mapper)
    {
        _cidadaoRepository = cidadaoRepository;
        _mapper = mapper;
    }

    public async Task<CidadaoDto> AdicionarCidadaoAsync(CidadaoDto cidadaoDto)
    {
        var cidadao = _mapper.Map<Cidadao>(cidadaoDto);
        var resultado = await _cidadaoRepository.Adicionar(cidadao);
        return _mapper.Map<CidadaoDto>(resultado);
    }

    public async Task<CidadaoDto> AtualizarCidadaoAsync(CidadaoDto cidadaoDto)
    {
        var cidadao = _mapper.Map<Cidadao>(cidadaoDto);
        var resultado = await _cidadaoRepository.Atualizar(cidadao);
        return _mapper.Map<CidadaoDto>(resultado);
    }

    public async Task<CidadaoDto> RemoverCidadaoAsync(CidadaoDto cidadaoDto)
    {
        var cidadao = _mapper.Map<Cidadao>(cidadaoDto);
        var resultado = await _cidadaoRepository.Remover(cidadao);
        return _mapper.Map<CidadaoDto>(resultado);
    }

    public async Task<CidadaoDto> ObterCidadaoPorIdAsync(Guid id)
    {
        var cidadao = await _cidadaoRepository.ObterPorIdAsync(id);
        return _mapper.Map<CidadaoDto>(cidadao);
    }

    public async Task<IEnumerable<CidadaoDto>> ObterCidadaosAsync()
    {
        var cidadaos = await _cidadaoRepository.ObterTodosAsync();
        return _mapper.Map<IEnumerable<CidadaoDto>>(cidadaos);
    }

    public async Task<CidadaoDto> ObterCidadaoPorCpfAsync(string cpf)
    {
        var cidadao = await _cidadaoRepository.ObterPorCpfAsync(cpf);
        return _mapper.Map<CidadaoDto>(cidadao);
    }

    public async Task<CidadaoDto> ObterCidadaoPorEmailAsync(string email)
    {
        var cidadao = await _cidadaoRepository.ObterPorEmailAsync(email);
        return _mapper.Map<CidadaoDto>(cidadao);
    }

    public async Task<IEnumerable<CidadaoDto>> ObterCidadaosAtivosAsync()
    {
        var cidadao = await _cidadaoRepository.ObterTodosAtivosAsync();
        return _mapper.Map<IEnumerable<CidadaoDto>>(cidadao);
    }

    public async Task<IEnumerable<CidadaoDto>> ObterCidadaosInativosAsync()
    {
        var cidadao = await _cidadaoRepository.ObterTodosInativosAsync();
        return _mapper.Map<IEnumerable<CidadaoDto>>(cidadao);
    }
}
