using Projeto.Chat.Domain.Models.DadosBasicos;
using Projeto.Chat.Domain.Models.Mensagens;
using System;
using System.Collections.Generic;

namespace Projeto.Chat.Domain.Models
{
    public class Usuario : Dados
    {
        public string Sobrenome { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public List<Mensagem> MensagensEnviadas { get; private set; }
        public List<Mensagem> MensagensRecebidas { get; private set; }
        public Usuario()
        {
        }
        public Usuario(Guid id, string nome, string sobrenome, string cpf, string telefone, string email, string senha, DateTime dataNascimento) : base(id, nome, cpf, senha)
        {
            Sobrenome = sobrenome;
            Telefone = telefone;
            Email = email;
            DataNascimento = dataNascimento;
        }
        public void Editar(string nome, string sobrenome, string cpf, string telefone, string email, string senha, DateTime dataNascimento)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Senha = senha;
            DataNascimento = dataNascimento;
        }
    }
}
