using Prefeitura.Core.ValueObjects;

namespace Prefeitura.Core.Entities;

public class Cidadao
{
    public Guid Id { get; private set; }
    public string Nome { get; private set; }
    public string Cpf { get; private set; }
    public DateTime DataNascimento { get; private set; }
    public string Email { get; private set; }
    public string Telefone { get; private set; }
    public Endereco Endereco { get; private set; }
    public bool Ativo { get; private set; }
    public DateTime DataCriacao { get; private set; }
    public DateTime? DataAtualizacao { get; private set; }

    // Construtor privado para o Entity Framework
    private Cidadao() { }

    public Cidadao(string nome, string cpf, DateTime dataNascimento, string email, Endereco endereco)
    {
        Id = Guid.NewGuid();
        Nome = nome;
        Cpf = cpf;
        DataNascimento = dataNascimento;
        Email = email;
        Endereco = endereco;
        Ativo = true;
        DataCriacao = DateTime.Now;
    }

    public void Atualizar(string nome, string cpf, DateTime dataNascimento, string email, Endereco endereco)
    {
        Nome = nome;
        Cpf = cpf;
        DataNascimento = dataNascimento;
        Email = email;
        Endereco = endereco;
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
}
