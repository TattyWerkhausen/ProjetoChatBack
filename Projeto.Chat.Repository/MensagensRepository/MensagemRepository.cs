using Microsoft.EntityFrameworkCore;
using Projeto.Chat.Domain.Models.Mensagens;
using Projeto.Chat.Repository.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Projeto.Chat.Repository.MensagensRepository
{
    public class MensagemRepository
    {
        private readonly ChatDb _db;
        public MensagemRepository(ChatDb db)
        {
            _db = db;
        }
        public async Task SalvarMensagemAsync(Mensagem mensagem)
        {
            await _db.Mensagens.AddAsync(mensagem);
            await _db.SaveChangesAsync();
        }
        public async Task<List<Mensagem>> BuscarTodasMensagens()
        {
            return await _db.Mensagens.ToListAsync();
        }
    }
}
