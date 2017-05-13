using CanalNoticias.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanalNoticias.ViewComponents
{
    public class UltimasNoticiasViewComponent : ViewComponent
    {
        private readonly INoticiaDataAccess _noticiasDataAccess;

        public UltimasNoticiasViewComponent(INoticiaDataAccess noticiasDataAccess)
        {
            _noticiasDataAccess = noticiasDataAccess;
        }

        public async Task<IViewComponentResult> InvokeAsync(string view = "Default")
        {
            var noticias = await _noticiasDataAccess.ObterTodos();
            return View(view, noticias.OrderByDescending(x=>x.Data));
        }
    }
}
