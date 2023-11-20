using AutoMapper;
using Prefeitura.Api.Interfaces;
using Prefeitura.Core.DTOs;
using Prefeitura.Core.Entities;
using Prefeitura.Core.Repositories;
using Prefeitura.Core.ValueObjects;

namespace Prefeitura.Api.Services;

public class PropriedadeService : IPropriedadeService
{
    private readonly IPropriedadeRepository _propriedadeRepository;
    private readonly IMapper _mapper;

    public PropriedadeService(IPropriedadeRepository propriedadeRepository, IMapper mapper)
    {
        _propriedadeRepository = propriedadeRepository;
        _mapper = mapper;
    }

    public async Task<PropriedadeDto> AdicionarPropriedadeAsync(PropriedadeDto propriedadeDto)
    {
        var propriedade = _mapper.Map<Propriedade>(propriedadeDto);
        var resultado = await _propriedadeRepository.Adicionar(propriedade);
        return _mapper.Map<PropriedadeDto>(resultado);
    }

    public async Task<PropriedadeDto> AtualizarPropriedadeAsync(PropriedadeDto propriedadeDto)
    {
        var propriedade = _mapper.Map<Propriedade>(propriedadeDto);
        var resultado = await _propriedadeRepository.Atualizar(propriedade);
        return _mapper.Map<PropriedadeDto>(resultado);
    }

    public async Task<PropriedadeDto> RemoverPropriedadeAsync(PropriedadeDto propriedadeDto)
    {
        var propriedade = _mapper.Map<Propriedade>(propriedadeDto);
        var resultado = await _propriedadeRepository.Remover(propriedade);
        return _mapper.Map<PropriedadeDto>(resultado);
    }

    public async Task<PropriedadeDto> ObterPorIdAsync(Guid id)
    {
        var propriedade = await _propriedadeRepository.ObterPorIdAsync(id);
        return _mapper.Map<PropriedadeDto>(propriedade);
    }

    public async Task<IEnumerable<PropriedadeDto>> ObterPorCepAsync(string cep)
    {
        var propriedade = await _propriedadeRepository.ObterPorCepAsync(cep);
        return _mapper.Map<IEnumerable<PropriedadeDto>>(propriedade);
    }

    public async Task<IEnumerable<PropriedadeDto>> ObterPorDescricaoAsync(string descricao)
    {
        var propriedade = await _propriedadeRepository.ObterPorDescricaoAsync(descricao);
        return _mapper.Map<IEnumerable<PropriedadeDto>>(propriedade);
    }

    public async Task<IEnumerable<PropriedadeDto>> ObterPorEnderecoAsync(EnderecoDto enderecoDto)
    {
        var endereco = _mapper.Map<Endereco>(enderecoDto);
        var propriedade = await _propriedadeRepository.ObterPorEnderecoAsync(endereco);
        return _mapper.Map<IEnumerable<PropriedadeDto>>(propriedade);
    }

    public async Task<IEnumerable<PropriedadeDto>> ObterPorNomeAsync(string nome)
    {
        var propriedade = await _propriedadeRepository.ObterPorNomeAsync(nome);
        return _mapper.Map<IEnumerable<PropriedadeDto>>(propriedade);
    }

    public async Task<IEnumerable<PropriedadeDto>> ObterPorValorAvaliadoAsync(decimal valorAvaliado)
    {
        var propriedade = await _propriedadeRepository.ObterPorValorAvaliadoAsync(valorAvaliado);
        return _mapper.Map<IEnumerable<PropriedadeDto>>(propriedade);
    }

    public async Task<IEnumerable<PropriedadeDto>> ObterTodosAsync()
    {
        var propriedades = await _propriedadeRepository.ObterTodosAsync();
        return _mapper.Map<IEnumerable<PropriedadeDto>>(propriedades);
    }
}
