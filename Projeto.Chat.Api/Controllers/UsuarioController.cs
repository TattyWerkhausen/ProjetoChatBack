using AutoMapper;
using ChatWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Projeto.Chat.Domain.Models;
using Projeto.Chat.Repository.CadastrosRepository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChatWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // Controller intermedia banco de dados e front end
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        public UsuarioController(UsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }
        // Metodo que recebe os dados enviados pela service e passa para o repositorio, cadastrando o usuario
        [HttpPost("cadastrando")]
        public async Task<IActionResult> Cadastrar([FromBody] UsuarioViewModel cadastroVM)
        {
            cadastroVM.Id = Guid.NewGuid();
            var novoCadastro = _mapper.Map<Usuario>(cadastroVM);
            await _usuarioRepository.CadastrandoAsync(novoCadastro);
            return Ok();
        }
        [HttpGet("buscarTodosUsuarios/{idUsuarioLogado}")]
        public async Task<IActionResult> BuscarTodosUsuarios(Guid idUsuarioLogado)
        {
            var usuarios = await _usuarioRepository.BuscarTodosUsuariosAsync(idUsuarioLogado);
            var usuariosVm = _mapper.Map<List<UsuarioViewModel>>(usuarios);
            return Ok(usuariosVm);
        }
        [HttpGet("buscarUsuario/{nome}")]
        public async Task<IActionResult> BuscarUsuarioNome(string nome)
        {
            var usuario = await _usuarioRepository.BuscarNomeUsuarioAsync(nome);
            var usuarioVM = _mapper.Map<UsuarioViewModel>(usuario);
            return Ok(usuarioVM);
        }
        /*   [HttpPost("enviarMensagem")]
           public async Task<IActionResult> EnviarMensagem([FromBody] UsuarioViewModel usuarioVM)
           {
               usuarioVM.Id = Guid.NewGuid();
               foreach(var msg in usuarioVM.MensagensEnviadas)
               {
                   msg.Id = Guid.NewGuid();
                   msg.IdUsuarioEnviou = usuarioVM.Id;
               }
               await _
           }*/
    }
}
