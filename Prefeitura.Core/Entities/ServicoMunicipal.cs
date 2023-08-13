﻿using Prefeitura.Core.Aggregates;

namespace Prefeitura.Core.Entities;

public class ServicoMunicipal
{
    public Guid Id { get; private set; }
    public string Nome { get; private set; }
    public string Descricao { get; private set; }
    public decimal Valor { get; private set; }
    public decimal ValorMulta { get; private set; }
    public decimal ValorJuros { get; private set; }
    public decimal ValorTotal { get; private set; }
    public DateTime DataVencimento { get; private set; }
    public DateTime DataPagamento { get; private set; }
    public bool Pago { get; private set; }
    public Empresa Empresa { get; private set; }
    public Propriedade Propriedade { get; private set; }
    public Cidadao Cidadao { get; private set; }
    public Familia Familia { get; private set; }
    public Reclamacao Reclamacao { get; private set; }

    // Constutro privado para o Entity Framework
    private ServicoMunicipal() { }
}