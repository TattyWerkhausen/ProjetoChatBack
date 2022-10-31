using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Chat.Domain.Models.Mensagens;

namespace Projeto.Chat.Repository.FluentApi
{
    class MensagemFA : IEntityTypeConfiguration<Mensagem>
    {
        public void Configure(EntityTypeBuilder<Mensagem> builder)
        {
            builder.HasKey(mensagem => mensagem.Id);
          /*  builder.HasOne(mensagem => mensagem.UsuarioEnviou).WithMany(usuario => usuario.MensagensEnviadas)
                .HasForeignKey(mensagens => mensagens.UsuarioEnviouId);
            builder.HasOne(mensagem => mensagem.UsuarioRecebeu).WithMany(usuario => usuario.MensagensRecebidas)
                .HasForeignKey(mensagens => mensagens.UsuarioRecebeuId);*/
        }
    }
}
