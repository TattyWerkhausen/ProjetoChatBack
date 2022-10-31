using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Chat.Domain.Models;

namespace Projeto.Chat.Repository.FluentApi
{
    public class UsuarioFA : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(cadastro => cadastro.Id);
            builder.Property(cadastro => cadastro.Nome).HasMaxLength(15);
            builder.Property(cadastro => cadastro.Sobrenome).HasMaxLength(15);
            builder.Property(cadastro => cadastro.Cpf).HasMaxLength(15);
            builder.Property(cadastro => cadastro.Telefone).HasMaxLength(15);
            builder.Property(cadastro => cadastro.Email).HasMaxLength(25);
            builder.Property(cadastro => cadastro.Senha).HasMaxLength(15);

            builder.HasMany(usuario => usuario.MensagensEnviadas).WithOne(mensagem => mensagem.UsuarioEnviou).
                HasForeignKey(mensagem => mensagem.IdUsuarioEnviou);

            builder.HasMany(usuario => usuario.MensagensRecebidas).WithOne(mensagem => mensagem.UsuarioRecebeu).
               HasForeignKey(mensagem => mensagem.IdUsuarioRecebeu);
        }
    }
}
