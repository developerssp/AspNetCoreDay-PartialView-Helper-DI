using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanalNoticias.Services
{
    public class ListasService
    {
        private static List<SelectListItem> estilos;
        private static List<SelectListItem> bandas;

        public ListasService()
        {
            estilos = new List<SelectListItem>()
            {
                new SelectListItem { Value = "Death", Text = "Death" },
                new SelectListItem { Value = "Thrash", Text = "Thrash" },
                new SelectListItem { Value = "Symphonic", Text = "Symphonic" },
                new SelectListItem { Value = "Heavy", Text = "Heavy" }
            };
            bandas = new List<SelectListItem>()
            {
                new SelectListItem { Value = "arch-enemy.jpg", Text = "Arch Enemy" },
                new SelectListItem { Value = "epica.jpg", Text = "Epica" },
                new SelectListItem { Value = "ghost.jpg", Text = "Ghost" },
                new SelectListItem { Value = "nightwish.jpg", Text = "Nightwish" },
                new SelectListItem { Value = "sepultura.jpg", Text = "Sepultura" }
            };

        }

        public IList<SelectListItem> ObterEstilos()
        {
            return estilos;
        }

        public IList<SelectListItem> ObterBandas()
        {
            return bandas;
        }

        public string ObterNomeBanda(string foto)
        {
            return bandas.SingleOrDefault(x => x.Value == foto).Text;
        }
    }
}
