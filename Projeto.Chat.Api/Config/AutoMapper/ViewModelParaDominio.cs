using AutoMapper;
using ChatWeb.ViewModels;
using Projeto.Chat.Api.Command;
using Projeto.Chat.Api.ViewModels;
using Projeto.Chat.Domain.Models;
using Projeto.Chat.Domain.Models.Loggins;
using Projeto.Chat.Domain.Models.Mensagens;

namespace ChatWeb.Config.AutoMapper
{
    public class ViewModelParaDominio : Profile
    {
        public ViewModelParaDominio()
        {
            CreateMap<UsuarioViewModel, Usuario>().ConstructUsing((cadastroVm) => new Usuario(cadastroVm.Id,
                cadastroVm.Nome, cadastroVm.Sobrenome, cadastroVm.Cpf, cadastroVm.Telefone, cadastroVm.Email,
                cadastroVm.Senha, cadastroVm.DataNascimento));

            CreateMap<LogginViewModel, Loggin>().ConstructUsing(logginVm => new Loggin(logginVm.Id,
                logginVm.Nome, logginVm.Cpf, logginVm.Senha));

           
        }
    }
}
