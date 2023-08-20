using Microsoft.EntityFrameworkCore;
using Prefeitura.Core.Entities;
using Prefeitura.Core.Repositories;
using Prefeitura.Core.ValueObjects;
using Prefeitura.Infra.Data.Context;

namespace Prefeitura.Infra.Data.Repositories;

public class PropriedadeRepository : IPropriedadeRepository
{
    private readonly PrefeituraContext _context;

    public PropriedadeRepository(PrefeituraContext context)
    {
        _context = context;
    }

    public async Task<Propriedade> ObterPorIdAsync(Guid id)
    {
        return await _context.Propriedades
            .Include(p => p.Endereco)
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<IEnumerable<Propriedade>> ObterTodosAsync()
    {
        return await _context.Propriedades
            .Include(p => p.Endereco)
            .ToListAsync();
    }

    public async Task<IEnumerable<Propriedade>> ObterPorNomeAsync(string nome)
    {
        return await _context.Propriedades
            .Include(p => p.Endereco)
            .Where(p => p.Nome == nome)
            .ToListAsync();
    }

    public async Task<IEnumerable<Propriedade>> ObterPorDescricaoAsync(string descricao)
    {
        return await _context.Propriedades
            .Include(p => p.Endereco)
            .Where(p => p.Descricao == descricao)
            .ToListAsync();
    }

    public async Task<IEnumerable<Propriedade>> ObterPorEnderecoAsync(Endereco endereco)
    {
        return await _context.Propriedades
            .Include(p => p.Endereco)
            .Where(p => p.Endereco == endereco)
            .ToListAsync();
    }

    public async Task<IEnumerable<Propriedade>> ObterPorCepAsync(string cep)
    {
        return await _context.Propriedades
            .Include(p => p.Endereco)
            .Where(p => p.Endereco.Cep == cep)
            .ToListAsync();
    }

    public async Task<IEnumerable<Propriedade>> ObterPorValorAvaliadoAsync(decimal valorAvaliado)
    {
        return await _context.Propriedades
            .Include(p => p.Endereco)
            .Where(p => p.ValorAvaliado == valorAvaliado)
            .ToListAsync();
    }

    public async Task<Propriedade> Adicionar(Propriedade propriedade)
    {
        await _context.Propriedades.AddAsync(propriedade);
        await _context.SaveChangesAsync();
        return propriedade;
    }

    public async Task<Propriedade> Atualizar(Propriedade propriedade)
    {
        _context.Propriedades.Update(propriedade);
        await _context.SaveChangesAsync();
        return propriedade;
    }

    public async Task<Propriedade> Remover(Propriedade propriedade)
    {
        _context.Propriedades.Remove(propriedade);
        await _context.SaveChangesAsync();
        return propriedade;
    }

    public void Dispose()
    {
        _context?.Dispose();
    }
}
