using Microsoft.EntityFrameworkCore;
using Projeto.Chat.Domain.Models.Mensagens;
using Projeto.Chat.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task EnviarMensagemAsync(Mensagem mensagem)
        {
            await _db.Mensagens.AddAsync(mensagem);
            await _db.SaveChangesAsync();
        }
        public async Task<List<Mensagem>> BuscarTodasMensagensAsync(Guid idUsuarioLogado, Guid idUsuarioSelecionado)
        {
            return await _db.Mensagens.Where(mensagem =>
                // todas as mensagens que o usuario que logado enviou -> para o usuario selecionado
                (mensagem.IdUsuarioEnviou == idUsuarioLogado &&
                mensagem.IdUsuarioRecebeu == idUsuarioSelecionado)
                || // ou
                   // todas as mensagens que o usuario selecionado enviou -> para o usuario logado
                (mensagem.IdUsuarioEnviou == idUsuarioSelecionado &&
                mensagem.IdUsuarioRecebeu == idUsuarioLogado))
                .OrderBy(mensagem => mensagem.Data)
            .ToListAsync();
        }
    }
}
