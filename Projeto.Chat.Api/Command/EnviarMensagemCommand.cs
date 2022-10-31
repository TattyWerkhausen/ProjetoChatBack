using System;

namespace Projeto.Chat.Api.Command
{
    public class EnviarMensagemCommand
    {
        public Guid IdUsuarioEnviou { get; set; }
        public Guid IdUsuarioRecebe { get; set; }
        public string Conteudo { get; set; }
    }
}
