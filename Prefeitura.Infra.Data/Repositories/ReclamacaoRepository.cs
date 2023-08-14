using Microsoft.EntityFrameworkCore;
using Prefeitura.Core.Entities;
using Prefeitura.Core.Repositories;
using Prefeitura.Core.ValueObjects;
using Prefeitura.Infra.Data.Context;

namespace Prefeitura.Infra.Data.Repositories;

public class ReclamacaoRepository : IReclamacaoRepository
{
    private readonly PrefeituraContext _context;

    public ReclamacaoRepository(PrefeituraContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Reclamacao>> ObterPorDataAsync(DateTime data)
    {
        return await _context.Reclamacoes.Where(r => r.Data == data).ToListAsync();
    }

    public async Task<IEnumerable<Reclamacao>> ObterPorDescricaoAsync(string descricao)
    {
        return await _context.Reclamacoes.Where(r => r.Descricao == descricao).ToListAsync();
    }

    public async Task<Reclamacao> ObterPorIdAsync(Guid id)
    {
        return await _context.Reclamacoes.FindAsync(id);
    }

    public async Task<IEnumerable<Reclamacao>> ObterPorObservacaoAsync(string observacao)
    {
        return await _context.Reclamacoes.Where(r => r.Observacao == observacao).ToListAsync();
    }

    public async Task<IEnumerable<Reclamacao>> ObterPorStatusAsync(string status)
    {
        return await _context.Reclamacoes.Where(r => r.Status == status).ToListAsync();
    }

    public async Task<IEnumerable<Reclamacao>> ObterPorTipoAsync(string tipo)
    {
        return await _context.Reclamacoes.Where(r => r.Tipo == tipo).ToListAsync();
    }

    public async Task<IEnumerable<Reclamacao>> ObterPorTipoEnderecoAsync(Endereco tipoEndereco)
    {
        return await _context.Reclamacoes.Where(r => r.TipoEndereco == tipoEndereco).ToListAsync();
    }

    public async Task<IEnumerable<Reclamacao>> ObterPorTipoOcorrenciaAsync(string tipoOcorrencia)
    {
        return await _context.Reclamacoes.Where(r => r.TipoOcorrencia == tipoOcorrencia).ToListAsync();
    }

    public async Task<IEnumerable<Reclamacao>> ObterPorTipoReclamacaoAsync(string tipoReclamacao)
    {
        return await _context.Reclamacoes.Where(r => r.TipoReclamacao == tipoReclamacao).ToListAsync();
    }

    public async Task<IEnumerable<Reclamacao>> ObterPorTipoServicoAsync(string tipoServico)
    {
        return await _context.Reclamacoes.Where(r => r.TipoServico == tipoServico).ToListAsync();
    }

    public async Task<IEnumerable<Reclamacao>> ObterPorTipoSolicitacaoAsync(string tipoSolicitacao)
    {
        return await _context.Reclamacoes.Where(r => r.TipoSolicitacao == tipoSolicitacao).ToListAsync();
    }

    public async Task<IEnumerable<Reclamacao>> ObterPorTipoSolicitanteAsync(string tipoSolicitante)
    {
        return await _context.Reclamacoes.Where(r => r.TipoSolicitante == tipoSolicitante).ToListAsync();
    }

    public async Task<IEnumerable<Reclamacao>> ObterTodosAsync()
    {
        return await _context.Reclamacoes.ToListAsync();
    }

    public async Task Adicionar(Reclamacao reclamacao)
    {
        await _context.Reclamacoes.AddAsync(reclamacao);
        await _context.SaveChangesAsync();
    }

    public async Task Atualizar(Reclamacao reclamacao)
    {
        _context.Reclamacoes.Update(reclamacao);
        await _context.SaveChangesAsync();
    }

    public async Task Remover(Reclamacao reclamacao)
    {
        _context.Reclamacoes.Remove(reclamacao);
        await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context?.Dispose();
    }
}
