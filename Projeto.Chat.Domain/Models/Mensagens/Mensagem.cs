using System;

namespace Projeto.Chat.Domain.Models.Mensagens
{
    public class Mensagem
    {
        protected Mensagem()
        {
        }
        public Guid Id { get; private set; }
        public Guid? IdUsuarioEnviou { get; private set; }
        public Guid? IdUsuarioRecebeu { get; private set; }
        public string Conteudo { get; private set; }
        public DateTime Data { get; private set; }
        public Usuario UsuarioEnviou { get; private set; }
        public Usuario UsuarioRecebeu { get; private set; }
        public Mensagem(Guid id, Guid idUsuarioEnviou, Guid idUsuarioRecebeu, string conteudo)
        {
            Id = id;
            IdUsuarioEnviou = idUsuarioEnviou;
            IdUsuarioRecebeu = idUsuarioRecebeu;
            Conteudo = conteudo;
            Data = DateTime.Now;
        }

        public void Editar(Guid idUsuarioEnviou, Guid idUsuarioRecebeu, string conteudo)
        {
            IdUsuarioEnviou = idUsuarioEnviou;
            IdUsuarioRecebeu = idUsuarioRecebeu;
            Conteudo = conteudo;
        }
    }
}
