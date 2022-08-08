using Microsoft.EntityFrameworkCore;
using Projeto.Chat.Domain.Models;
using Projeto.Chat.Repository.Context;
using System.Threading.Tasks;

namespace Projeto.Chat.Repository.LogginsRepository
{
    public class LogginRepository
    {
        private readonly ChatDb _db;
        public LogginRepository(ChatDb db)
        {
            _db = db;
        }
        public async Task<Usuario> BuscarCadastroAsync(string nome, string senha)
        {
            return await _db.Usuarios.FirstOrDefaultAsync(cadastro => cadastro.Nome.ToLower().
            Contains(nome.ToLower()) && cadastro.Senha.ToLower().Contains(senha.ToLower()));
        }
    }
}
