using ChatWeb.Config.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Projeto.Chat.Repository.CadastrosRepository;
using Projeto.Chat.Repository.Context;
using Projeto.Chat.Repository.LogginsRepository;
using Projeto.Chat.Repository.MensagensRepository;

namespace Projeto.Chat.Api.Config
{
    public static class InjecaoDependencia
    {
        public static IServiceCollection AddInjecaoDependencia(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DominioParaViewModel), typeof(ViewModelParaDominio));
            services.AddDbContext<ChatDb>();
            services.AddScoped<UsuarioRepository>();
            services.AddScoped<LogginRepository>();
            services.AddScoped<MensagemRepository>();
            return services;
        }
    }
}
