using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prova.HATEOAS
{
    public class LinkDTO
    {
        public string Href { get; private set; }
        public string Rel { get; private set; }
        public string Metodo { get; private set; }
        public LinkDTO(string href, string rel, string metodo)
        {
            Href = href;
            Rel = rel;
            Metodo = metodo;
        }
    }
}
