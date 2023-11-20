using Prefeitura.Core.DTOs;

namespace Prefeitura.Api.Interfaces;

public interface IReclamacaoService
{
    Task<ReclamacaoDto> AdicionarReclamacaoAsync(ReclamacaoDto reclamacaoDto);
    Task<ReclamacaoDto> AtualizarReclamacaoAsync(ReclamacaoDto reclamacaoDto);
    Task<ReclamacaoDto> RemoverReclamacaoAsync(ReclamacaoDto reclamacaoDto);
    Task<ReclamacaoDto> ObterPorIdAsync(Guid id);
    Task<IEnumerable<ReclamacaoDto>> ObterTodosAsync();
    Task<IEnumerable<ReclamacaoDto>> ObterPorDescricaoAsync(string descricao);
    Task<IEnumerable<ReclamacaoDto>> ObterPorDataAsync(DateTime data);
    Task<IEnumerable<ReclamacaoDto>> ObterPorStatusAsync(string status);
    Task<IEnumerable<ReclamacaoDto>> ObterPorObservacaoAsync(string observacao);
    Task<IEnumerable<ReclamacaoDto>> ObterPorTipoAsync(string tipo);
    Task<IEnumerable<ReclamacaoDto>> ObterPorTipoReclamacaoAsync(string tipoReclamacao);
    Task<IEnumerable<ReclamacaoDto>> ObterPorTipoSolicitacaoAsync(string tipoSolicitacao);
    Task<IEnumerable<ReclamacaoDto>> ObterPorTipoServicoAsync(string tipoServico);
    Task<IEnumerable<ReclamacaoDto>> ObterPorTipoOcorrenciaAsync(string tipoOcorrencia);
    Task<IEnumerable<ReclamacaoDto>> ObterPorTipoSolicitanteAsync(string tipoSolicitante);
    Task<IEnumerable<ReclamacaoDto>> ObterPorTipoEnderecoAsync(EnderecoDto tipoEnderecoDto);
}
