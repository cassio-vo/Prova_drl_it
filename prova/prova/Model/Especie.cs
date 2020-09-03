using prova.Model.Base;
using System.Collections.Generic;

namespace prova.Model
{
    public class Especie : BaseEntity
    {
        public string Descricao { get; set; }

        public ICollection<Arvore> Arvores { get; set; }
    }
}
