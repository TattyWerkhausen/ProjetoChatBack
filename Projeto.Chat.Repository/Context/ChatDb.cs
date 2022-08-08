using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Projeto.Chat.Domain.Models;
using Projeto.Chat.Domain.Models.Loggins;
using Projeto.Chat.Domain.Models.Mensagens;
using Projeto.Chat.Repository.FluentApi;
using System.IO;

namespace Projeto.Chat.Repository.Context
{
    public class ChatDb : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Loggin> Loggins { get; set; }
        public DbSet<Mensagem> Mensagens { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioFA());
            modelBuilder.ApplyConfiguration(new LogginFA());
            modelBuilder.ApplyConfiguration(new MensagemFA());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json")
              .Build();

            optionsBuilder
                .EnableSensitiveDataLogging(true)
                .UseNpgsql(config.GetConnectionString("DefaultConnection"));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
