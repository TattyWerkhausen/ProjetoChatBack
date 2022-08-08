using Microsoft.EntityFrameworkCore;
using Projeto.Chat.Domain.Models;
using Projeto.Chat.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Chat.Repository.CadastrosRepository
{
    public class UsuarioRepository
    {
        // Leitura do meu banco de dados
        private readonly ChatDb _db;

        // 
        public UsuarioRepository(ChatDb db)
        {
            _db = db;
        }
        // Cadastro de usuario
        public async Task CadastrandoAsync(Usuario cadastro)
        {
            await _db.Usuarios.AddAsync(cadastro);
            await _db.SaveChangesAsync();
        }
        // Busca todos os usuarios que tenham id diferente do id que está acessando o chat
        public async Task<List<Usuario>> BuscarTodosUsuariosAsync(Guid id)
        {
            return await _db.Usuarios.Where(usuario => usuario.Id != id).ToListAsync();
        }
        // Busca usuario por id
        public async Task<Usuario> BuscandoPorIdAsync(Guid id)
        {
            return await _db.Usuarios.FirstOrDefaultAsync(usuario => usuario.Id == id);
        }
        // Busca usuario por Nome e senha, transformando maiscula em minusculaa
        public async Task<Usuario> BuscandoPorNomeAsync(string nome, string senha)
        {
            return await _db.Usuarios.FirstOrDefaultAsync(usuario => usuario.Nome.ToLower().
            Contains(nome.ToLower()) && usuario.Senha.ToLower().Contains(senha.ToLower()));
        }
        // Edita o usuario passado por parametro
        public async Task EditandoAsync(Usuario cadastro)
        {
            _db.Usuarios.UpdateRange(cadastro);
            await _db.SaveChangesAsync();
        }
        // Exclui usuario passado por parametro
        public async Task ExcluindoAsync(Guid id)
        {
            var idDoCadastro = await BuscandoPorIdAsync(id);
            _db.Usuarios.RemoveRange(idDoCadastro);
            await _db.SaveChangesAsync();
        }
    }
}
