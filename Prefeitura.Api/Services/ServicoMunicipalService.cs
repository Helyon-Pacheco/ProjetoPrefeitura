using Prefeitura.Api.Interfaces;
using Prefeitura.Core.Aggregates;
using Prefeitura.Core.Entities;
using Prefeitura.Core.Repositories;

namespace Prefeitura.Api.Services;

public class ServicoMunicipalService : IServicoMunicipalService
{
    private readonly IServicoMunicipalRepository _servicoMunicipalRepository;

    public ServicoMunicipalService(IServicoMunicipalRepository servicoMunicipalRepository)
    {
        _servicoMunicipalRepository = servicoMunicipalRepository;
    }

    public async Task<ServicoMunicipal> ObterServicoMunicipalPorIdAsync(Guid id)
    {
        return await _servicoMunicipalRepository.ObterPorIdAsync(id);
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisAsync()
    {
        return await _servicoMunicipalRepository.ObterTodosAsync();
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorNomeAsync(string nome)
    {
        return await _servicoMunicipalRepository.ObterPorNomeAsync(nome);
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorDescricaoAsync(string descricao)
    {
        return await _servicoMunicipalRepository.ObterPorDescricaoAsync(descricao);
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorValorAsync(decimal valor)
    {
        return await _servicoMunicipalRepository.ObterPorValorAsync(valor);
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorValorMultasAsync(decimal valorMultas)
    {
        return await _servicoMunicipalRepository.ObterPorValorMultasAsync(valorMultas);
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorValorJurosAsync(decimal valorJuros)
    {
        return await _servicoMunicipalRepository.ObterPorValorJurosAsync(valorJuros);
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorValorTotalAsync(decimal valorTotal)
    {
        return await _servicoMunicipalRepository.ObterPorValorTotalAsync(valorTotal);
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorDataVencimentoAsync(DateTime dataVencimento)
    {
        return await _servicoMunicipalRepository.ObterPorDataVencimentoAsync(dataVencimento);
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorDataPagamentoAsync(DateTime dataPagamento)
    {
        return await _servicoMunicipalRepository.ObterPorDataPagamentoAsync(dataPagamento);
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorPagoAsync(bool pago)
    {
        return await _servicoMunicipalRepository.ObterPorPagoAsync(pago);
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorEmpresaAsync(Empresa empresa)
    {
        return await _servicoMunicipalRepository.ObterPorEmpresaAsync(empresa);
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorPropriedadeAsync(Propriedade propriedade)
    {
        return await _servicoMunicipalRepository.ObterPorPropriedadeAsync(propriedade);
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorCidadaoAsync(Cidadao cidadao)
    {
        return await _servicoMunicipalRepository.ObterPorCidadaoAsync(cidadao);
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorFamiliaAsync(Familia familia)
    {
        return await _servicoMunicipalRepository.ObterPorFamiliaAsync(familia);
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorReclamacaoAsync(Reclamacao reclamacao)
    {
        return await _servicoMunicipalRepository.ObterPorReclamacaoAsync(reclamacao);
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorStatusAsync(string status)
    {
        return await _servicoMunicipalRepository.ObterPorStatusAsync(status);
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorObservacaoAsync(string observacao)
    {
        return await _servicoMunicipalRepository.ObterPorObservacaoAsync(observacao);
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorTipoAsync(string tipo)
    {
        return await _servicoMunicipalRepository.ObterPorTipoAsync(tipo);
    }

    public async Task<ServicoMunicipal> AdicionarServicoMunicipalAsync(ServicoMunicipal servicoMunicipal)
    {
        return await _servicoMunicipalRepository.Adicionar(servicoMunicipal);
    }

    public async Task<ServicoMunicipal> AtualizarServicoMunicipalAsync(ServicoMunicipal servicoMunicipal)
    {
        return await _servicoMunicipalRepository.Atualizar(servicoMunicipal);
    }

    public async Task<ServicoMunicipal> RemoverServicoMunicipalAsync(ServicoMunicipal servicoMunicipal)
    {
        return await _servicoMunicipalRepository.Remover(servicoMunicipal);
    }
}
