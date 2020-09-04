using prova.Model.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace prova.Model
{
    public class Especie : BaseEntity
    {
        public string Descricao { get; set; }

        [NotMapped]
        public ICollection<Arvore> Arvores { get; set; }
    }
}
