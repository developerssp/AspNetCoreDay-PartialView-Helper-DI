using CanalNoticias.Services;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanalNoticias.TagHelpers
{
    [HtmlTargetElement("imagem-banda", TagStructure = TagStructure.WithoutEndTag)]
    [HtmlTargetElement(Attributes = "foto")]
    public class ImagemBandaTagHelper : TagHelper
    {
        private ListasService _listaService;
        private const string _caminhoImagens = "../images/";
        public string Foto { get; set; }

        public ImagemBandaTagHelper(ListasService listaService)
        {
            _listaService = listaService;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "img";
            if (string.IsNullOrEmpty(Foto))
                output.SuppressOutput();
            else
            {
                var nomeBanda = _listaService.ObterNomeBanda(Foto);
                output.Attributes.SetAttribute("alt", nomeBanda);
                output.Attributes.SetAttribute("src", $"{_caminhoImagens}{Foto}");
            }
        }
    }
}
