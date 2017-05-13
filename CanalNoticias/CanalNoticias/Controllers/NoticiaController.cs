using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CanalNoticias.Models;
using CanalNoticias.DataAccess;

namespace CanalNoticias.Controllers
{
    public class NoticiaController : Controller
    {
        private readonly INoticiaDataAccess _noticiasDataAccess;

        public NoticiaController(INoticiaDataAccess noticiasDataAccess)
        {
            _noticiasDataAccess = noticiasDataAccess;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _noticiasDataAccess.ObterTodos());
        }

        [Route("/noticias/{tituloUrl}")]
        public async Task<IActionResult> Details(string tituloUrl)
        {
            if (string.IsNullOrEmpty(tituloUrl))
                return NotFound();
            var noticia = await _noticiasDataAccess.ObterPorUrl(tituloUrl);
            if (noticia == null)
                return NotFound();
            return View(noticia);
        }

        public async Task<IActionResult> Edit(int id)
        {
            if (id == 0)
                return View("_Details");
            else
            {
                var noticia = await _noticiasDataAccess.ObterPorId(id);
                if (noticia == null)
                    return NotFound();
                return PartialView("_Details", noticia);
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
                return NotFound();
            var noticia = await _noticiasDataAccess.ObterPorId(id);
            if (noticia == null)
                return NotFound();
            await _noticiasDataAccess.Remover(noticia);
            return View("Index", await _noticiasDataAccess.ObterTodos());
        }

        public IActionResult Create()
        {
            return PartialView("_Details", new Noticia());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(Noticia noticia)
        {
            if (ModelState.IsValid)
            {
                if (noticia.Id.Equals(0))
                {
                    noticia.FormatarTituloUrl(noticia.Titulo);
                    noticia.Data = DateTime.Now;
                    await _noticiasDataAccess.Criar(noticia);
                }
                else
                {
                    noticia.FormatarTituloUrl(noticia.Titulo);
                    await _noticiasDataAccess.Atualizar(noticia);
                }
                return View("Index", await _noticiasDataAccess.ObterTodos());
            }
            return View(noticia);
        }
    }
}
