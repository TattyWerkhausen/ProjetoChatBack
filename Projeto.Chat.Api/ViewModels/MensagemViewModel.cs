using System;

namespace Projeto.Chat.Api.ViewModels
{
    public class MensagemViewModel
    {
        public Guid Id { get; set; }
        public Guid UsuarioEnviouId { get; set; }
        public Guid UsuarioRecebeuId { get; set; }
        public string Conteudo { get; set; }
        public DateTime Data { get; set; }
    }
}
