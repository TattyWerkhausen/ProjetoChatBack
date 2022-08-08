using AutoMapper;
using ChatWeb.ViewModels;
using Projeto.Chat.Api.ViewModels;
using Projeto.Chat.Domain.Models;
using Projeto.Chat.Domain.Models.Loggins;
using Projeto.Chat.Domain.Models.Mensagens;

namespace ChatWeb.Config.AutoMapper
{
    public class DominioParaViewModel : Profile
    {
        public DominioParaViewModel()
        {
            CreateMap<Usuario, UsuarioViewModel>();
            CreateMap<Loggin, LogginViewModel>();
            CreateMap<Mensagem, MensagemViewModel>();
        }
    }
}
