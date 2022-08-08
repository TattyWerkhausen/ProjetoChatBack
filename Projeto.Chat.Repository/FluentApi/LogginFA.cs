using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Chat.Domain.Models.Loggins;

namespace Projeto.Chat.Repository.FluentApi
{
    public class LogginFA : IEntityTypeConfiguration<Loggin>
    {
        public void Configure(EntityTypeBuilder<Loggin> builder)
        {
            builder.HasKey(loggin => loggin.Id);
            builder.Property(loggin => loggin.Nome).HasMaxLength(15);
            builder.Property(loggin => loggin.Cpf).HasMaxLength(15);
            builder.Property(loggin => loggin.Senha).HasMaxLength(15);
        }
    }
}
