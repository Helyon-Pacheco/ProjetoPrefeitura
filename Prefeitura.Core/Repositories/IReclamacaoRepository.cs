using Prefeitura.Core.Entities;
using Prefeitura.Core.ValueObjects;

namespace Prefeitura.Core.Repositories;

public interface IReclamacaoRepository
{
    Task<Reclamacao> ObterPorIdAsync (Guid id);
    Task<IEnumerable<Reclamacao>> ObterTodosAsync ();
    Task<IEnumerable<Reclamacao>> ObterPorDescricaoAsync (string descricao);
    Task<IEnumerable<Reclamacao>> ObterPorDataAsync (DateTime data);
    Task<IEnumerable<Reclamacao>> ObterPorStatusAsync (string status);
    Task<IEnumerable<Reclamacao>> ObterPorObservacaoAsync (string observacao);
    Task<IEnumerable<Reclamacao>> ObterPorTipoAsync (string tipo);
    Task<IEnumerable<Reclamacao>> ObterPorTipoReclamacaoAsync (string tipoReclamacao);
    Task<IEnumerable<Reclamacao>> ObterPorTipoSolicitacaoAsync (string tipoSolicitacao);
    Task<IEnumerable<Reclamacao>> ObterPorTipoServicoAsync (string tipoServico);
    Task<IEnumerable<Reclamacao>> ObterPorTipoOcorrenciaAsync (string tipoOcorrencia);
    Task<IEnumerable<Reclamacao>> ObterPorTipoSolicitanteAsync (string tipoSolicitante);
    Task<IEnumerable<Reclamacao>> ObterPorTipoEnderecoAsync (Endereco tipoEndereco);
    Task<Reclamacao> Adicionar(Reclamacao reclamacao);
    Task<Reclamacao> Atualizar(Reclamacao reclamacao);
    Task<Reclamacao> Remover(Reclamacao reclamacao);
}
