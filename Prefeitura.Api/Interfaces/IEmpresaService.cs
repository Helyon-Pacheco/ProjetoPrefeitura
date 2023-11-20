using Prefeitura.Core.DTOs;

namespace Prefeitura.Api.Interfaces;

public interface IEmpresaService
{
    Task<EmpresaDto> ObterEmpresaPorId(Guid id);
    Task<IEnumerable<EmpresaDto>> ObterEmpresas();
    Task<IEnumerable<EmpresaDto>> ObterEmpresaPorCnpj(string cnpj);
    Task<IEnumerable<EmpresaDto>> ObterEmpresaPorInscricaoEstadual(string inscricaoEstadual);
    Task<IEnumerable<EmpresaDto>> ObterEmpresaPorInscricaoMunicipal(string inscricaoMunicipal);
    Task<IEnumerable<EmpresaDto>> ObterEmpresasPorNome(string nome);
    Task<IEnumerable<EmpresaDto>> ObterEmpresasPorTelefone(string telefone);
    Task<IEnumerable<EmpresaDto>> ObterEmpresasPorEmail(string email);
    Task<IEnumerable<EmpresaDto>> ObterEmpresasPorResponsavel(string responsavel);
    Task<IEnumerable<EmpresaDto>> ObterEmpresasPorTelefoneResponsavel(string telefoneResponsavel);
    Task<IEnumerable<EmpresaDto>> ObterEmpresasPorEmailResponsavel(string emailResponsavel);
    Task<IEnumerable<EmpresaDto>> ObterEmpresasPorEndereco(EnderecoDto enderecoDto);
    Task<EmpresaDto> AdicionarEmpresa(EmpresaDto empresaDto);
    Task<EmpresaDto> AtualizarEmpresa(EmpresaDto empresaDto);
    Task<EmpresaDto> RemoverEmpresa(EmpresaDto empresaDto);
}
