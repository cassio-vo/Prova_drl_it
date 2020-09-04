using prova.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prova.Model
{
    public class GrupoArvore : BaseEntity
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }

        [NotMapped]
        public ICollection<Arvore> Arvores { get; set; }
    }
}
