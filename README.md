# Canal de Notícias
Exemplo de utilização de partial views, tag helpers, dependency injection e view components

## Partial Views
- Master Detail do cadastro de notícias, requisitando a partial Noticias/_Details.cshml na view Noticias/Index.cshml
- Filtro de estilos musicais, renderizando a partial Home/_Filtros.cshml na view Home/Index.cshml

## Tag Helpers
- ImagemBandaTagHelper, utilizado nas views ViewComponents/UltimasNoticias/Default.cshml e ViewComponents/NoticiasEmDetaque/Default.cshml

## Dependency Injection
- ListasServices, usada para retornar uma coleção de SelectListItem's de Estilos Musicais e Bandas (usada nas views Noticias/Index.cshml e Noticias/_Details.cshml), e obter banda por foto (usada na ImagemBandaTagHelper)

## View Components
- Componentes UltimaNoticias e NoticiasEmDestaque (com duas opções de visualização, em carousel ou lista). Usados nas páginas Home/Index.cshml e Noticia/\{tituloUrl\}.


