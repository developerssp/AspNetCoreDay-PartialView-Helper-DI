using System.Collections.Generic;
using System.Threading.Tasks;
using CanalNoticias.Models;

namespace CanalNoticias.DataAccess
{
    public interface INoticiaDataAccess
    {
        Task<Noticia> ObterPorId(int id);
        Task<Noticia> ObterPorUrl(string tituloUrl);
        Task<IList<Noticia>> ObterTodos();
        Task Criar(Noticia noticia);
        Task Atualizar(Noticia noticia);
        Task Remover(Noticia noticia);
    }
}