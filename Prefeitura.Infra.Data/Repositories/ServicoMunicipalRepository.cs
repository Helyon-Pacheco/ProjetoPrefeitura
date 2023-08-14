using Microsoft.EntityFrameworkCore;
using Prefeitura.Core.Aggregates;
using Prefeitura.Core.Entities;
using Prefeitura.Core.Repositories;
using Prefeitura.Infra.Data.Context;

namespace Prefeitura.Infra.Data.Repositories;

public class ServicoMunicipalRepository : IServicoMunicipalRepository
{
    private readonly PrefeituraContext _context;

    public ServicoMunicipalRepository(PrefeituraContext context)
    {
        _context = context;
    }


    public async Task<IEnumerable<ServicoMunicipal>> ObterPorCidadaoAsync(Cidadao cidadao)
    {
        return await _context.Servicos.Where(s => s.Cidadao == cidadao).ToListAsync();
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterPorDataPagamentoAsync(DateTime dataPagamento)
    {
        return await _context.Servicos.Where(s => s.DataPagamento == dataPagamento).ToListAsync();
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterPorDataVencimentoAsync(DateTime dataVencimento)
    {
        return await _context.Servicos.Where(s => s.DataVencimento == dataVencimento).ToListAsync();
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterPorDescricaoAsync(string descricao)
    {
        return await _context.Servicos.Where(s => s.Descricao == descricao).ToListAsync();
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterPorEmpresaAsync(Empresa empresa)
    {
        return await _context.Servicos.Where(s => s.Empresa == empresa).ToListAsync();
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterPorFamiliaAsync(Familia familia)
    {
        return await _context.Servicos.Where(s => s.Familia == familia).ToListAsync();
    }

    public async Task<ServicoMunicipal> ObterPorIdAsync(Guid id)
    {
        return await _context.Servicos.FirstOrDefaultAsync(s => s.Id == id);
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterPorNomeAsync(string nome)
    {
        return await _context.Servicos.Where(s => s.Nome == nome).ToListAsync();
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterPorPagoAsync(bool pago)
    {
        return await _context.Servicos.Where(s => s.Pago == pago).ToListAsync();
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterPorPropriedadeAsync(Propriedade propriedade)
    {
        return await _context.Servicos.Where(s => s.Propriedade == propriedade).ToListAsync();
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterPorReclamacaoAsync(Reclamacao reclamacao)
    {
        return await _context.Servicos.Where(s => s.Reclamacao == reclamacao).ToListAsync();
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterPorValorAsync(decimal valor)
    {
        return await _context.Servicos.Where(s => s.Valor == valor).ToListAsync();
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterPorValorJurosAsync(decimal valorJuros)
    {
        return await _context.Servicos.Where(s => s.ValorJuros == valorJuros).ToListAsync();
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterPorValorMultaAsync(decimal valorMulta)
    {
        return await _context.Servicos.Where(s => s.ValorMulta == valorMulta).ToListAsync();
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterPorValorTotalAsync(decimal valorTotal)
    {
        return await _context.Servicos.Where(s => s.ValorTotal == valorTotal).ToListAsync();
    }

    public async Task<IEnumerable<ServicoMunicipal>> ObterTodosAsync()
    {
        return await _context.Servicos.ToListAsync();
    }

    public async Task Adicionar(ServicoMunicipal servicoMunicipal)
    {
        await _context.Servicos.AddAsync(servicoMunicipal);
        await _context.SaveChangesAsync();
    }

    public async Task Atualizar(ServicoMunicipal servicoMunicipal)
    {
        _context.Servicos.Update(servicoMunicipal);
        await _context.SaveChangesAsync();
    }

    public async Task Remover(ServicoMunicipal servicoMunicipal)
    {
        _context.Servicos.Remove(servicoMunicipal);
        await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context?.Dispose();
    }
}
