using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Projeto.Chat.Api.Command;
using Projeto.Chat.Api.ViewModels;
using Projeto.Chat.Domain.Models;
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
        public async Task<IActionResult> EnviarMensagem([FromBody] EnviarMensagemCommand enviarMensagem)
        {
            var mensagem = new Mensagem(Guid.NewGuid(), enviarMensagem.IdUsuarioEnviou, enviarMensagem.IdUsuarioRecebe, enviarMensagem.Conteudo);
            await _mensagemRepository.EnviarMensagemAsync(mensagem);
            return Ok();
        }
        [HttpGet("todasMensagens/{idUsuarioLogado}/{idUsuarioSelecionado}")]
        // metodo exibir mensagens pegando de parametro os ids passado atravez da minha servic no front end.
        public async Task<IActionResult> ExibirTodasMensagens(Guid idUsuarioLogado, Guid idUsuarioSelecionado)
        {
            var mensagens = await _mensagemRepository.BuscarTodasMensagensAsync(idUsuarioLogado, idUsuarioSelecionado);
            var mensagensVM = _mapper.Map<List<ReceberMensagemVM>>(mensagens);
            return Ok(mensagensVM);
        }

    }
}
