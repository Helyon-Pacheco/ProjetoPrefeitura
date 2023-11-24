using AutoMapper;
using Prefeitura.Api.Interfaces;
using Prefeitura.Core.DTOs;
using Prefeitura.Core.Entities;
using Prefeitura.Core.Repositories;

namespace Prefeitura.Api.Services;

public class ServicoMunicipalService : IServicoMunicipalService
{
    private readonly IServicoMunicipalRepository _servicoMunicipalRepository;
    private readonly IMapper _mapper;

    public ServicoMunicipalService(IServicoMunicipalRepository servicoMunicipalRepository, IMapper mapper)
    {
        _servicoMunicipalRepository = servicoMunicipalRepository;
        _mapper = mapper;
    }

    public async Task<ServicoMunicipalDto> AdicionarServicoMunicipalAsync(ServicoMunicipalDto servicoMunicipalDto)
    {
        var servicoMunicipal = _mapper.Map<ServicoMunicipal>(servicoMunicipalDto);
        var resultado = await _servicoMunicipalRepository.Adicionar(servicoMunicipal);
        return _mapper.Map<ServicoMunicipalDto>(resultado);
    }

    public async Task<ServicoMunicipalDto> AtualizarServicoMunicipalAsync(ServicoMunicipalDto servicoMunicipalDto)
    {
        var servicoMunicipal = _mapper.Map<ServicoMunicipal>(servicoMunicipalDto);
        var resultado = await _servicoMunicipalRepository.Atualizar(servicoMunicipal);
        return _mapper.Map<ServicoMunicipalDto>(resultado);
    }

    public async Task<ServicoMunicipalDto> RemoverServicoMunicipalAsync(ServicoMunicipalDto servicoMunicipalDto)
    {
        var servicoMunicipal = _mapper.Map<ServicoMunicipal>(servicoMunicipalDto);
        var resultado = await _servicoMunicipalRepository.Remover(servicoMunicipal);
        return _mapper.Map<ServicoMunicipalDto>(resultado);
    }

    public async Task<ServicoMunicipalDto> ObterServicoMunicipalPorIdAsync(Guid id)
    {
        var servicoMunicipal = await _servicoMunicipalRepository.ObterPorIdAsync(id);
        return _mapper.Map<ServicoMunicipalDto>(servicoMunicipal);
    }

    public async Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisAsync()
    {
        var servicosMunicipais = await _servicoMunicipalRepository.ObterTodosAsync();
        return _mapper.Map<IEnumerable<ServicoMunicipalDto>>(servicosMunicipais);
    }

    public async Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorNomeAsync(string nome)
    {
        var servicosMunicipais = await _servicoMunicipalRepository.ObterPorNomeAsync(nome);
        return _mapper.Map<IEnumerable<ServicoMunicipalDto>>(servicosMunicipais);
    }

    public async Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorDescricaoAsync(string descricao)
    {
        var servicosMunicipais = await _servicoMunicipalRepository.ObterPorDescricaoAsync(descricao);
        return _mapper.Map<IEnumerable<ServicoMunicipalDto>>(servicosMunicipais);
    }

    public async Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorValorAsync(decimal valor)
    {
        var servicosMunicipais = await _servicoMunicipalRepository.ObterPorValorAsync(valor);
        return _mapper.Map<IEnumerable<ServicoMunicipalDto>>(servicosMunicipais);
    }

    public async Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorValorMultasAsync(decimal valorMultas)
    {
        var servicosMunicipais = await _servicoMunicipalRepository.ObterPorValorMultasAsync(valorMultas);
        return _mapper.Map<IEnumerable<ServicoMunicipalDto>>(servicosMunicipais);
    }

    public async Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorValorJurosAsync(decimal valorJuros)
    {
        var servicosMunicipais = await _servicoMunicipalRepository.ObterPorValorJurosAsync(valorJuros);
        return _mapper.Map<IEnumerable<ServicoMunicipalDto>>(servicosMunicipais);
    }

    public async Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorValorTotalAsync(decimal valorTotal)
    {
        var servicosMunicipais = await _servicoMunicipalRepository.ObterPorValorTotalAsync(valorTotal);
        return _mapper.Map<IEnumerable<ServicoMunicipalDto>>(servicosMunicipais);
    }

    public async Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorDataVencimentoAsync(DateTime dataVencimento)
    {
        var servicosMunicipais = await _servicoMunicipalRepository.ObterPorDataVencimentoAsync(dataVencimento);
        return _mapper.Map<IEnumerable<ServicoMunicipalDto>>(servicosMunicipais);
    }

    public async Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorDataPagamentoAsync(DateTime dataPagamento)
    {
        var servicosMunicipais = await _servicoMunicipalRepository.ObterPorDataPagamentoAsync(dataPagamento);
        return _mapper.Map<IEnumerable<ServicoMunicipalDto>>(servicosMunicipais);
    }

    public async Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorPagoAsync(bool pago)
    {
        var servicosMunicipais = await _servicoMunicipalRepository.ObterPorPagoAsync(pago);
        return _mapper.Map<IEnumerable<ServicoMunicipalDto>>(servicosMunicipais);
    }

    public async Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorEmpresaAsync(EmpresaDto empresaDto)
    {
        var empresa = _mapper.Map<Empresa>(empresaDto);
        var servicosMunicipais = await _servicoMunicipalRepository.ObterPorEmpresaAsync(empresa);
        return _mapper.Map<IEnumerable<ServicoMunicipalDto>>(servicosMunicipais);
    }

    public async Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorPropriedadeAsync(PropriedadeDto propriedadeDto)
    {
        var propriedade = _mapper.Map<Propriedade>(propriedadeDto);
        var servicosMunicipais = await _servicoMunicipalRepository.ObterPorPropriedadeAsync(propriedade);
        return _mapper.Map<IEnumerable<ServicoMunicipalDto>>(servicosMunicipais);
    }

    public async Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorCidadaoAsync(CidadaoDto cidadaoDto)
    {
        var cidadao = _mapper.Map<Cidadao>(cidadaoDto);
        var servicosMunicipais = await _servicoMunicipalRepository.ObterPorCidadaoAsync(cidadao);
        return _mapper.Map<IEnumerable<ServicoMunicipalDto>>(servicosMunicipais);
    }

    public async Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorReclamacaoAsync(ReclamacaoDto reclamacaoDto)
    {
        var reclamacao = _mapper.Map<Reclamacao>(reclamacaoDto);
        var servicosMunicipais = await _servicoMunicipalRepository.ObterPorReclamacaoAsync(reclamacao);
        return _mapper.Map<IEnumerable<ServicoMunicipalDto>>(servicosMunicipais);
    }

    public async Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorStatusAsync(string status)
    {
        var servicosMunicipais = await _servicoMunicipalRepository.ObterPorStatusAsync(status);
        return _mapper.Map<IEnumerable<ServicoMunicipalDto>>(servicosMunicipais);
    }

    public async Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorObservacaoAsync(string observacao)
    {
        var servicosMunicipais = await _servicoMunicipalRepository.ObterPorObservacaoAsync(observacao);
        return _mapper.Map<IEnumerable<ServicoMunicipalDto>>(servicosMunicipais);
    }

    public async Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorTipoAsync(string tipo)
    {
        var servicosMunicipais = await _servicoMunicipalRepository.ObterPorTipoAsync(tipo);
        return _mapper.Map<IEnumerable<ServicoMunicipalDto>>(servicosMunicipais);
    }
}
