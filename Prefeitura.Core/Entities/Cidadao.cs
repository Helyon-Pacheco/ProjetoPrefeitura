using Prefeitura.Core.Aggregates;
using Prefeitura.Core.ValueObjects;

namespace Prefeitura.Core.Entities;

public class Cidadao
{
    public Guid Id { get; private set; }
    public string Nome { get; private set; }
    public string Cpf { get; private set; }
    public DateTime DataNascimento { get; private set; }
    public string Email { get; private set; }
    public Endereco Endereco { get; private set; }
    public Familia Familia { get; private set; }
    public bool Ativo { get; private set; }
    public DateTime DataCriacao { get; private set; }
    public DateTime? DataAtualizacao { get; private set; }

    // Construtor privado para o Entity Framework
    private Cidadao() { }

    public Cidadao(string nome, string cpf, DateTime dataNascimento, string email, Endereco endereco, Familia familia)
    {
        Id = Guid.NewGuid();
        Nome = nome;
        Cpf = cpf;
        DataNascimento = dataNascimento;
        Email = email;
        Endereco = endereco;
        Familia = familia;
        Ativo = true;
        DataCriacao = DateTime.Now;
    }

    public void Atualizar(string nome, string cpf, DateTime dataNascimento, string email, Endereco endereco, Familia familia)
    {
        Nome = nome;
        Cpf = cpf;
        DataNascimento = dataNascimento;
        Email = email;
        Endereco = endereco;
        Familia = familia;
        DataAtualizacao = DateTime.Now;
    }

    public void Desativar()
    {
        Ativo = false;
        DataAtualizacao = DateTime.Now;
    }

    public void Ativar()
    {
        Ativo = true;
        DataAtualizacao = DateTime.Now;
    }

    public void AlterarEndereco(Endereco endereco)
    {
        Endereco = endereco;
        DataAtualizacao = DateTime.Now;
    }

    public void AlterarFamilia(Familia familia)
    {
        Familia = familia;
        DataAtualizacao = DateTime.Now;
    }
}
