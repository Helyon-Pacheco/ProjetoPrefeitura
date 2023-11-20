using Prefeitura.Core.DTOs;

namespace Prefeitura.Api.Interfaces;

public interface IPropriedadeService
{
    Task<PropriedadeDto> AdicionarPropriedadeAsync(PropriedadeDto propriedadeDto);
    Task<PropriedadeDto> AtualizarPropriedadeAsync(PropriedadeDto propriedadeDto);
    Task<PropriedadeDto> RemoverPropriedadeAsync(PropriedadeDto propriedadeDto);
    Task<PropriedadeDto> ObterPorIdAsync(Guid id);
    Task<IEnumerable<PropriedadeDto>> ObterTodosAsync();
    Task<IEnumerable<PropriedadeDto>> ObterPorNomeAsync(string nome);
    Task<IEnumerable<PropriedadeDto>> ObterPorDescricaoAsync(string descricao);
    Task<IEnumerable<PropriedadeDto>> ObterPorEnderecoAsync(EnderecoDto endereco);
    Task<IEnumerable<PropriedadeDto>> ObterPorCepAsync(string cep);
    Task<IEnumerable<PropriedadeDto>> ObterPorValorAvaliadoAsync(decimal valorAvaliado);
}
