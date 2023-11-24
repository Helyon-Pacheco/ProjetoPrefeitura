using Prefeitura.Core.DTOs;

namespace Prefeitura.Api.Interfaces;

public interface IServicoMunicipalService
{
    Task<ServicoMunicipalDto> AdicionarServicoMunicipalAsync(ServicoMunicipalDto servicoMunicipalDto);
    Task<ServicoMunicipalDto> AtualizarServicoMunicipalAsync(ServicoMunicipalDto servicoMunicipalDto);
    Task<ServicoMunicipalDto> RemoverServicoMunicipalAsync(ServicoMunicipalDto servicoMunicipalDto);
    Task<ServicoMunicipalDto> ObterServicoMunicipalPorIdAsync(Guid id);
    Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisAsync();
    Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorNomeAsync(string nome);
    Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorDescricaoAsync(string descricao);
    Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorValorAsync(decimal valor);
    Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorValorMultasAsync(decimal valorMultas);
    Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorValorJurosAsync(decimal valorJuros);
    Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorValorTotalAsync(decimal valorTotal);
    Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorDataVencimentoAsync(DateTime dataVencimento);
    Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorDataPagamentoAsync(DateTime dataPagamento);
    Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorPagoAsync(bool pago);
    Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorEmpresaAsync(EmpresaDto empresaDto);
    Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorPropriedadeAsync(PropriedadeDto propriedadeDto);
    Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorCidadaoAsync(CidadaoDto cidadaoDto);
    Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorReclamacaoAsync(ReclamacaoDto reclamacaoDto);
    Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorStatusAsync(string status);
    Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorObservacaoAsync(string observacao);
    Task<IEnumerable<ServicoMunicipalDto>> ObterServicosMunicipaisPorTipoAsync(string tipo);
}
