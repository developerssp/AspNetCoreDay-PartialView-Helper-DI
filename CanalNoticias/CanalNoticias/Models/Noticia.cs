using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CanalNoticias.Models
{
    public class Noticia
    {
        public int Id { get; set; }
        public string TituloURL { get; set; }
        [Display(Name = "Título")]
        [Required]
        public string Titulo { get; set; }
        [Display(Name = "Descrição")]
        [Required]
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        [Display(Name ="Banda")]
        [Required]
        public string FotoPrincipal { get; set; }
        [Display(Name = "Destaque")]
        public bool EhDestaque { get; set; }
        [Display(Name = "Estilo Musical")]
        public string EstiloMusical { get; set; }

        public void FormatarTituloUrl(string titulo)
        {
            TituloURL = titulo.ToLower().Trim().Replace(" ", "-");                 
        }

        public Noticia()
        {

        }        
    }
}
