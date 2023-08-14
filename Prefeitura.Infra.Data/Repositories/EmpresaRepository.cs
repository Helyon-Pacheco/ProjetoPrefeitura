using Microsoft.EntityFrameworkCore;
using Prefeitura.Core.Entities;
using Prefeitura.Core.Repositories;
using Prefeitura.Core.ValueObjects;
using Prefeitura.Infra.Data.Context;

namespace Prefeitura.Infra.Data.Repositories;

public class EmpresaRepository : IEmpresaRepository
{
    private readonly PrefeituraContext _context;

    public EmpresaRepository(PrefeituraContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Empresa>> ObterPorCnpjAsync(string cnpj)
    {
        return await _context.Empresas.Where(e => e.CNPJ == cnpj).ToListAsync();
    }

    public async Task<IEnumerable<Empresa>> ObterPorEmailAsync(string email)
    {
        return await _context.Empresas.Where(e => e.Email == email).ToListAsync();
    }

    public async Task<IEnumerable<Empresa>> ObterPorEmailResponsavelAsync(string emailResponsavel)
    {
        return await _context.Empresas.Where(e => e.EmailResponsavel == emailResponsavel).ToListAsync();
    }

    public async Task<IEnumerable<Empresa>> ObterPorEnderecoAsync(Endereco endereco)
    {
        return await _context.Empresas.Where(e => e.Endereco == endereco).ToListAsync();
    }

    public async Task<Empresa> ObterPorIdAsync(Guid id)
    {
        return await _context.Empresas.FindAsync(id);
    }

    public async Task<IEnumerable<Empresa>> ObterPorInscricaoEstadualAsync(string inscricaoEstadual)
    {
        return await _context.Empresas.Where(e => e.InscricaoEstadual == inscricaoEstadual).ToListAsync();
    }

    public async Task<IEnumerable<Empresa>> ObterPorInscricaoMunicipalAsync(string inscricaoMunicipal)
    {
        return await _context.Empresas.Where(e => e.InscricaoMunicipal == inscricaoMunicipal).ToListAsync();
    }

    public async Task<IEnumerable<Empresa>> ObterPorNomeAsync(string nome)
    {
        return await _context.Empresas.Where(e => e.Nome == nome).ToListAsync();
    }

    public async Task<IEnumerable<Empresa>> ObterPorResponsavelAsync(string responsavel)
    {
        return await _context.Empresas.Where(e => e.Responsavel == responsavel).ToListAsync();
    }

    public async Task<IEnumerable<Empresa>> ObterPorTelefoneAsync(string telefone)
    {
        return await _context.Empresas.Where(e => e.Telefone == telefone).ToListAsync();
    }

    public async Task<IEnumerable<Empresa>> ObterPorTelefoneResponsavelAsync(string telefoneResponsavel)
    {
        return await _context.Empresas.Where(e => e.TelefoneResponsavel == telefoneResponsavel).ToListAsync();
    }

    public async Task<IEnumerable<Empresa>> ObterTodosAsync()
    {
        return await _context.Empresas.ToListAsync();
    }

    public async Task Adicionar(Empresa empresa)
    {
        await _context.Empresas.AddAsync(empresa);
        await _context.SaveChangesAsync();
    }

    public async Task Atualizar(Empresa empresa)
    {
        _context.Empresas.Update(empresa);
        await _context.SaveChangesAsync();
    }

    public async Task Remover(Empresa empresa)
    {
        _context.Empresas.Remove(empresa);
        await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context?.Dispose();
    }
}
