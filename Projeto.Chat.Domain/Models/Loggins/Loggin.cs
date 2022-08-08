using Projeto.Chat.Domain.Models.DadosBasicos;
using System;

namespace Projeto.Chat.Domain.Models.Loggins
{
    public class Loggin : Dados
    {
        public Loggin()
        {
        }
        public Loggin(Guid id, string nome, string cpf, string senha) : base(id, nome, cpf, senha) { }

    }
}
