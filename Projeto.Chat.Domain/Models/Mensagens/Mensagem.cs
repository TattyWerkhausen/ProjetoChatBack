using System;

namespace Projeto.Chat.Domain.Models.Mensagens
{
    public class Mensagem
    {
        public Mensagem()
        {
        }
        public Guid Id { get; private set; }
        public Guid UsuarioEnviouId { get; private set; }
        public Guid UsuarioRecebeuId { get; private set; }
        public string Conteudo { get; private set; }
        public DateTime Data { get; private set; }
        public Usuario UsuarioEnviou { get; private set; }
        public Usuario UsuarioRecebeu { get; private set; }
        public Mensagem(Guid id, Guid usuarioEnviouId, Guid usuarioRecebeuId, string conteudo, DateTime data)
        {
            Id = id;
            UsuarioEnviouId = usuarioEnviouId;
            UsuarioRecebeuId = usuarioRecebeuId;
            Conteudo = conteudo;
            Data = data;
        }

        public void Editar(Guid usuarioEnviouId, Guid usuarioRecebeuId, string conteudo)
        {
            UsuarioEnviouId = usuarioEnviouId;
            UsuarioRecebeuId = usuarioRecebeuId;
            Conteudo = conteudo;
        }
    }
}
