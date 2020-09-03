using prova.HATEOAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prova.Data.VO
{
    public class Recurso
    {
        public long? Id { get; set; }
        public List<LinkDTO> Links { get; set; } = new List<LinkDTO>();
    }
}
