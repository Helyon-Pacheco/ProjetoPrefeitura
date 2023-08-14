using Microsoft.EntityFrameworkCore;
using Prefeitura.Core.Entities;
using Prefeitura.Core.Repositories;
using Prefeitura.Infra.Data.Context;

namespace Prefeitura.Infra.Data.Repositories;

public class CidadaoRepository : ICidadaoRepository
{
    private readonly PrefeituraContext _context;

    public CidadaoRepository(PrefeituraContext context)
    {
        _context = context;
    }

    public async Task<Cidadao> ObterPorId(Guid id)
    {
        return await _context.Cidadaos
            .Include(c => c.Endereco)
            .Include(c => c.Familia)
            .FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<Cidadao> ObterPorCpf(string cpf)
    {
        return await _context.Cidadaos
            .Include(c => c.Endereco)
            .Include(c => c.Familia)
            .FirstOrDefaultAsync(c => c.Cpf == cpf);
    }

    public async Task<IEnumerable<Cidadao>> ObterTodos()
    {
        return await _context.Cidadaos
            .Include(c => c.Endereco)
            .Include(c => c.Familia)
            .ToListAsync();
    }

    public async Task<IEnumerable<Cidadao>> ObterTodosAtivos()
    {
        return await _context.Cidadaos
            .Include(c => c.Endereco)
            .Include(c => c.Familia)
            .Where(c => c.Ativo)
            .ToListAsync();
    }

    public async Task<IEnumerable<Cidadao>> ObterTodosInativos()
    {
        return await _context.Cidadaos
            .Include(c => c.Endereco)
            .Include(c => c.Familia)
            .Where(c => !c.Ativo)
            .ToListAsync();
    }

    public async Task<IEnumerable<Cidadao>> ObterTodosPorFamilia(Guid familiaId)
    {
        return await _context.Cidadaos
            .Include(c => c.Endereco)
            .Include(c => c.Familia)
            .Where(c => c.FamiliaId == familiaId)
            .ToListAsync();
    }

    public async Task<IEnumerable<Cidadao>> ObterTodosAtivosPorFamilia(Guid familiaId)
    {
        return await _context.Cidadaos
            .Include(c => c.Endereco)
            .Include(c => c.Familia)
            .Where(c => c.FamiliaId == familiaId && c.Ativo)
            .ToListAsync();
    }

    public async Task<IEnumerable<Cidadao>> ObterTodosInativosPorFamilia(Guid familiaId)
    {
        return await _context.Cidadaos
            .Include(c => c.Endereco)
            .Include(c => c.Familia)
            .Where(c => c.FamiliaId == familiaId && !c.Ativo)
            .ToListAsync();
    }

    public async Task Adicionar(Cidadao cidadao)
    {
        await _context.Cidadaos.AddAsync(cidadao);
        await _context.SaveChangesAsync();
    }

    public async Task Atualizar(Cidadao cidadao)
    {
        _context.Cidadaos.Update(cidadao);
        await _context.SaveChangesAsync();
    }

    public async Task Remover(Cidadao cidadao)
    {
        _context.Cidadaos.Remove(cidadao);
        await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context?.Dispose();
    }
}
