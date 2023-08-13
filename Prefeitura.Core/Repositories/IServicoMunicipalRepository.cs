using Prefeitura.Core.Aggregates;
using Prefeitura.Core.Entities;

namespace Prefeitura.Core.Repositories;

public interface IServicoMunicipalRepository
{
    Task<ServicoMunicipal> ObterPorIdAsync (Guid id);
    Task<IEnumerable<ServicoMunicipal>> ObterTodosAsync ();
    Task<IEnumerable<ServicoMunicipal>> ObterPorNomeAsync (string nome);
    Task<IEnumerable<ServicoMunicipal>> ObterPorDescricaoAsync (string descricao);
    Task<IEnumerable<ServicoMunicipal>> ObterPorValorAsync (decimal valor);
    Task<IEnumerable<ServicoMunicipal>> ObterPorValorMultaAsync (decimal valorMulta);
    Task<IEnumerable<ServicoMunicipal>> ObterPorValorJurosAsync (decimal valorJuros);
    Task<IEnumerable<ServicoMunicipal>> ObterPorValorTotalAsync (decimal valorTotal);
    Task<IEnumerable<ServicoMunicipal>> ObterPorDataVencimentoAsync (DateTime dataVencimento);
    Task<IEnumerable<ServicoMunicipal>> ObterPorDataPagamentoAsync (DateTime dataPagamento);
    Task<IEnumerable<ServicoMunicipal>> ObterPorPagoAsync (bool pago);
    Task<IEnumerable<ServicoMunicipal>> ObterPorEmpresaAsync (Empresa empresa);
    Task<IEnumerable<ServicoMunicipal>> ObterPorPropriedadeAsync (Propriedade propriedade);
    Task<IEnumerable<ServicoMunicipal>> ObterPorCidadaoAsync (Cidadao cidadao);
    Task<IEnumerable<ServicoMunicipal>> ObterPorFamiliaAsync (Familia familia);
    Task<IEnumerable<ServicoMunicipal>> ObterPorReclamacaoAsync (Reclamacao reclamacao);
}
