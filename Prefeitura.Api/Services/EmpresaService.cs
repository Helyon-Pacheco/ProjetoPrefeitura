using Prefeitura.Api.Interfaces;
using Prefeitura.Core.Entities;
using Prefeitura.Core.Repositories;
using Prefeitura.Core.ValueObjects;

namespace Prefeitura.Api.Services;

public class EmpresaService : IEmpresaService
{
    private readonly IEmpresaRepository _empresaRepository;

    public EmpresaService(IEmpresaRepository empresaRepository)
    {
        _empresaRepository = empresaRepository;
    }

    public async Task<Empresa> AdicionarEmpresa(Empresa empresa)
    {
        return await _empresaRepository.Adicionar(empresa);
    }

    public async Task<Empresa> AtualizarEmpresa(Empresa empresa)
    {
        return await _empresaRepository.Atualizar(empresa);
    }

    public async Task<Empresa> RemoverEmpresa(Empresa empresa)
    {
        return await _empresaRepository.Remover(empresa);
    }

    public async Task<IEnumerable<Empresa>> ObterEmpresaPorCnpj(string cnpj)
    {
        return await _empresaRepository.ObterPorCnpjAsync(cnpj);
    }

    public async Task<Empresa> ObterEmpresaPorId(Guid id)
    {
        return await _empresaRepository.ObterPorIdAsync(id);
    }

    public async Task<IEnumerable<Empresa>> ObterEmpresaPorInscricaoEstadual(string inscricaoEstadual)
    {
        return await _empresaRepository.ObterPorInscricaoEstadualAsync(inscricaoEstadual);
    }

    public async Task<IEnumerable<Empresa>> ObterEmpresaPorInscricaoMunicipal(string inscricaoMunicipal)
    {
        return await _empresaRepository.ObterPorInscricaoMunicipalAsync(inscricaoMunicipal);
    }

    public async Task<IEnumerable<Empresa>> ObterEmpresas()
    {
        return await _empresaRepository.ObterTodosAsync();
    }

    public async Task<IEnumerable<Empresa>> ObterEmpresasPorEmail(string email)
    {
        return await _empresaRepository.ObterPorEmailAsync(email);
    }

    public async Task<IEnumerable<Empresa>> ObterEmpresasPorEmailResponsavel(string emailResponsavel)
    {
        return await _empresaRepository.ObterPorEmailResponsavelAsync(emailResponsavel);
    }

    public async Task<IEnumerable<Empresa>> ObterEmpresasPorEndereco(Endereco endereco)
    {
        return await _empresaRepository.ObterPorEnderecoAsync(endereco);
    }

    public async Task<IEnumerable<Empresa>> ObterEmpresasPorNome(string nome)
    {
        return await _empresaRepository.ObterPorNomeAsync(nome);
    }

    public async Task<IEnumerable<Empresa>> ObterEmpresasPorResponsavel(string responsavel)
    {
        return await _empresaRepository.ObterPorResponsavelAsync(responsavel);
    }

    public async Task<IEnumerable<Empresa>> ObterEmpresasPorTelefone(string telefone)
    {
        return await _empresaRepository.ObterPorTelefoneAsync(telefone);
    }

    public async Task<IEnumerable<Empresa>> ObterEmpresasPorTelefoneResponsavel(string telefoneResponsavel)
    {
        return await _empresaRepository.ObterPorTelefoneResponsavelAsync(telefoneResponsavel);
    }
}
