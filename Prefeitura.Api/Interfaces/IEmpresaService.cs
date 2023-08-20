using Prefeitura.Core.Entities;
using Prefeitura.Core.ValueObjects;

namespace Prefeitura.Api.Interfaces;

public interface IEmpresaService
{
    Task<Empresa> ObterEmpresaPorId(Guid id);
    Task<IEnumerable<Empresa>> ObterEmpresas();
    Task<IEnumerable<Empresa>> ObterEmpresaPorCnpj(string cnpj);
    Task<IEnumerable<Empresa>> ObterEmpresaPorInscricaoEstadual(string inscricaoEstadual);
    Task<IEnumerable<Empresa>> ObterEmpresaPorInscricaoMunicipal(string inscricaoMunicipal);
    Task<IEnumerable<Empresa>> ObterEmpresasPorNome(string nome);
    Task<IEnumerable<Empresa>> ObterEmpresasPorTelefone(string telefone);
    Task<IEnumerable<Empresa>> ObterEmpresasPorEmail(string email);
    Task<IEnumerable<Empresa>> ObterEmpresasPorResponsavel(string responsavel);
    Task<IEnumerable<Empresa>> ObterEmpresasPorTelefoneResponsavel(string telefoneResponsavel);
    Task<IEnumerable<Empresa>> ObterEmpresasPorEmailResponsavel(string emailResponsavel);
    Task<IEnumerable<Empresa>> ObterEmpresasPorEndereco(Endereco endereco);
    Task<Empresa> AdicionarEmpresa(Empresa empresa);
    Task<Empresa> AtualizarEmpresa(Empresa empresa);
    Task<Empresa> RemoverEmpresa(Guid id);
}
