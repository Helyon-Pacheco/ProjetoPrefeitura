using Prefeitura.Core.Aggregates;

namespace Prefeitura.Core.DTOs;

public class ServicoMunicipalDto
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
    public decimal ValorMulta { get; set; }
    public decimal ValorJuros { get; set; }
    public decimal ValorTotal { get; set; }
    public DateTime DataVencimento { get; set; }
    public DateTime DataPagamento { get; set; }
    public bool Pago { get; set; }
    public EmpresaDto Empresa { get; set; }
    public PropriedadeDto Propriedade { get; set; }
    public CidadaoDto Cidadao { get; set; }
    public FamiliaDto Familia { get; set; }
    public ReclamacaoDto Reclamacao { get; set; }
    public string Status { get; set; }
    public string Observacao { get; set; }
    public string Tipo { get; set; }

    public ServicoMunicipalDto() { }
}
