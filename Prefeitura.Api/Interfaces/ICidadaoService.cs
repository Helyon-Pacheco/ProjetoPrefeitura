using Prefeitura.Core.DTOs;

namespace Prefeitura.Api.Interfaces;

public interface ICidadaoService
{
    Task<CidadaoDto> AdicionarCidadaoAsync(CidadaoDto cidadaoDto);
    Task<CidadaoDto> AtualizarCidadaoAsync(CidadaoDto cidadaoDto);
    Task<CidadaoDto> RemoverCidadaoAsync(CidadaoDto cidadaoDto);
    Task<CidadaoDto> ObterCidadaoPorIdAsync(Guid id);
    Task<IEnumerable<CidadaoDto>> ObterCidadaosAsync();
    Task<CidadaoDto> ObterCidadaoPorCpfAsync(string cpf);
    Task<CidadaoDto> ObterCidadaoPorEmailAsync(string email);
    Task<IEnumerable<CidadaoDto>> ObterCidadaosAtivosAsync();
    Task<IEnumerable<CidadaoDto>> ObterCidadaosInativosAsync();
}
