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

    public async Task<Cidadao> ObterPorIdAsync(Guid id)
    {
        return await _context.Cidadaos
            .Include(c => c.Endereco)
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<Cidadao> ObterPorCpfAsync(string cpf)
    {
        return await _context.Cidadaos
            .Include(c => c.Endereco)
            .FirstOrDefaultAsync(c => c.Cpf == cpf);
    }

    public async Task<Cidadao> ObterPorEmailAsync(string email)
    {
        return await _context.Cidadaos
            .Include(c => c.Endereco)
            .FirstOrDefaultAsync(c => c.Email == email);
    }

    public async Task<IEnumerable<Cidadao>> ObterTodosAsync()
    {
        return await _context.Cidadaos
            .Include(c => c.Endereco)
            .ToListAsync();
    }

    public async Task<IEnumerable<Cidadao>> ObterTodosAtivosAsync()
    {
        return await _context.Cidadaos
            .Include(c => c.Endereco)
            .Where(c => c.Ativo)
            .ToListAsync();
    }

    public async Task<IEnumerable<Cidadao>> ObterTodosInativosAsync()
    {
        return await _context.Cidadaos
            .Include(c => c.Endereco)
            .Where(c => !c.Ativo)
            .ToListAsync();
    }

    public async Task<Cidadao> Adicionar(Cidadao cidadao)
    {
        await _context.Cidadaos.AddAsync(cidadao);
        await _context.SaveChangesAsync();
        return cidadao;
    }

    public async Task<Cidadao> Atualizar(Cidadao cidadao)
    {
        var cidadaoExistente = await _context.Cidadaos.FirstOrDefaultAsync(c => c.Id == cidadao.Id);
        if (cidadaoExistente != null)
        {
            _context.Entry(cidadaoExistente).CurrentValues.SetValues(cidadao);
        }
        else
        {
            _context.Cidadaos.Update(cidadao);
        }

        await _context.SaveChangesAsync();
        return cidadao;
    }

    public async Task<Cidadao> Remover(Cidadao cidadao)
    {
        _context.Cidadaos.Remove(cidadao);
        await _context.SaveChangesAsync();
        return cidadao;
    }

    public void Dispose()
    {
        _context?.Dispose();
    }
}
