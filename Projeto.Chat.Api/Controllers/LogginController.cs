using AutoMapper;
using ChatWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Projeto.Chat.Repository.LogginsRepository;
using System.Threading.Tasks;

namespace ChatWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogginController : ControllerBase
    {
        private readonly LogginRepository _logginRepository;
        private readonly IMapper _mapper;
        public LogginController(LogginRepository logginRepository, IMapper mapper)
        {
            _logginRepository = logginRepository;
            _mapper = mapper;
        }
        [HttpGet("buscarCadastro/{nome}/{senha}")]
        public async Task<IActionResult> BuscarCadastro(string nome, string senha)
        {
            var cadastro = await _logginRepository.BuscarCadastroAsync(nome, senha);
            var cadastroVm = _mapper.Map<UsuarioViewModel>(cadastro);
            return Ok(cadastroVm);
        }
    }
}
