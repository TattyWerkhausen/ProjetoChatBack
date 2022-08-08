using Projeto.Chat.Domain.Models.Mensagens;
using System;
using System.Collections.Generic;

namespace ChatWeb.ViewModels
{
    public class UsuarioViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public List<Mensagem> MensagensEnviadas { get; set; }
        public List<Mensagem> MensagensRecebidas { get; set; }
    }
}
