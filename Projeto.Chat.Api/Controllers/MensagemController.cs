using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Projeto.Chat.Api.ViewModels;
using Projeto.Chat.Domain.Models.Mensagens;
using Projeto.Chat.Repository.MensagensRepository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Projeto.Chat.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MensagemController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly MensagemRepository _mensagemRepository;
        public MensagemController(MensagemRepository mensagemRepository, IMapper mapper)
        {
            _mapper = mapper;
            _mensagemRepository = mensagemRepository;
        }
        [HttpPost("enviarMensagem")]
        public async Task<IActionResult> EnviarMensagem([FromBody] MensagemViewModel mensagemViewModel)
        {
            mensagemViewModel.Id = Guid.NewGuid();
            var novaMensagem = _mapper.Map<Mensagem>(mensagemViewModel);
            await _mensagemRepository.SalvarMensagemAsync(novaMensagem);
            return Ok();
        }
        [HttpGet("buscarTodasMensagens")]
        public async Task<IActionResult> BuscarTodasMensagem()
        {
            var mensagens = await _mensagemRepository.BuscarTodasMensagens();
            var mensagemVM = _mapper.Map<List<MensagemViewModel>>(mensagens);
            return Ok(mensagemVM);
        }
    }
}
