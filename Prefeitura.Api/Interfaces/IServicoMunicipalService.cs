using Prefeitura.Core.Aggregates;
using Prefeitura.Core.Entities;
using Prefeitura.Core.ValueObjects;

namespace Prefeitura.Api.Interfaces;

public interface IServicoMunicipalService
{
    Task<ServicoMunicipal> ObterServicoMunicipalPorIdAsync(Guid id);
    Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisAsync();
    Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorNomeAsync(string nome);
    Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorDescricaoAsync(string descricao);
    Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorValorAsync(decimal valor);
    Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorValorMultasAsync(decimal valorMultas);
    Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorValorJurosAsync(decimal valorJuros);
    Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorValorTotalAsync(decimal valorTotal);
    Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorDataVencimentoAsync(DateTime dataVencimento);
    Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorDataPagamentoAsync(DateTime dataPagamento);
    Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorPagoAsync(bool pago);
    Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorEmpresaAsync(Empresa empresa);
    Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorPropriedadeAsync(Propriedade propriedade);
    Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorCidadaoAsync(Cidadao cidadao);
    Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorFamiliaAsync(Familia familia);
    Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorReclamacaoAsync(Reclamacao reclamacao);
    Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorStatusAsync(string status);
    Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorObservacaoAsync(string observacao);
    Task<IEnumerable<ServicoMunicipal>> ObterServicosMunicipaisPorTipoAsync(string tipo);
    Task<ServicoMunicipal> AdicionarServicoMunicipalAsync(ServicoMunicipal servicoMunicipal);
    Task<ServicoMunicipal> AtualizarServicoMunicipalAsync(ServicoMunicipal servicoMunicipal);
    Task<ServicoMunicipal> RemoverServicoMunicipalAsync(ServicoMunicipal servicoMunicipal);
}
