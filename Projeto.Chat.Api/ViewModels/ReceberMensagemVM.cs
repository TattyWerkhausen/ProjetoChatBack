using System;

namespace Projeto.Chat.Api.ViewModels
{
    public class ReceberMensagemVM
    {
        public Guid IdUsuarioRecebeu { get; set; }
        public Guid IdUsuarioEnviou { get; set; }
        public string Conteudo { get; set; }
        public DateTime Data { get; set; }
    }
}
