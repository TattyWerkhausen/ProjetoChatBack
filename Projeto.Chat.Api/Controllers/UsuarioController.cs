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
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        public UsuarioController(UsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }
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
    }
}
