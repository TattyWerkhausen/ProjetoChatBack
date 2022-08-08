using System;

namespace Projeto.Chat.Domain.Models.DadosBasicos
{
    public class Dados
    {
        public Dados()
        {
        }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }

        public Dados(Guid id, string nome, string cpf, string senha)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Senha = senha;
        }
    }
}
