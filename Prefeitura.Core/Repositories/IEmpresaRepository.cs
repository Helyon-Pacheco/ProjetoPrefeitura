using Prefeitura.Core.Entities;
using Prefeitura.Core.ValueObjects;

namespace Prefeitura.Core.Repositories;

public interface IEmpresaRepository
{
    Task<Empresa> ObterPorIdAsync (Guid id);
    Task<IEnumerable<Empresa>> ObterTodosAsync ();
    Task<IEnumerable<Empresa>> ObterPorNomeAsync (string nome);
    Task<IEnumerable<Empresa>> ObterPorCnpjAsync (string cnpj);
    Task<IEnumerable<Empresa>> ObterPorInscricaoEstadualAsync (string inscricaoEstadual);
    Task<IEnumerable<Empresa>> ObterPorInscricaoMunicipalAsync (string inscricaoMunicipal);
    Task<IEnumerable<Empresa>> ObterPorTelefoneAsync (string telefone);
    Task<IEnumerable<Empresa>> ObterPorEmailAsync (string email);
    Task<IEnumerable<Empresa>> ObterPorResponsavelAsync (string responsavel);
    Task<IEnumerable<Empresa>> ObterPorTelefoneResponsavelAsync (string telefoneResponsavel);
    Task<IEnumerable<Empresa>> ObterPorEmailResponsavelAsync (string emailResponsavel);
    Task<IEnumerable<Empresa>> ObterPorEnderecoAsync (Endereco endereco);
    Task Adicionar(Empresa empresa);
    Task Atualizar(Empresa empresa);
    Task Remover(Empresa empresa);
}
