using CanalNoticias.Data;
using CanalNoticias.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanalNoticias.DataAccess
{
    public class NoticiaDataAccess : INoticiaDataAccess
    {
        private readonly ApplicationDbContext _context;

        public NoticiaDataAccess(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Noticia>> ObterTodos()
        {
            return await _context.Noticias.ToListAsync();
        }

        public async Task<Noticia> ObterPorId(int id)
        {
            var noticia = await _context.Noticias
                .SingleOrDefaultAsync(m => m.Id == id);
            return noticia;
        }

        public async Task<Noticia> ObterPorUrl(string tituloUrl)
        {
            var noticia = await _context.Noticias
                .SingleOrDefaultAsync(m => m.TituloURL == tituloUrl);
            return noticia;
        }

        public async Task Criar(Noticia noticia)
        {
            _context.Add(noticia);
            await _context.SaveChangesAsync();
        }

        public async Task Atualizar(Noticia noticia)
        {
            _context.Attach(noticia);
            _context.Entry(noticia).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Remover(Noticia noticia)
        {
            _context.Attach(noticia);
            _context.Entry(noticia).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
    }
}
