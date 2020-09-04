using prova.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prova.Model
{
    public class Arvore : BaseEntity
    {
        public string Descricao { get; set; }

        public int Idade { get; set; }

        public int IdEspecie { get; set; }
        [NotMapped]
        public Especie Especie { get; set; }

        public int IdGrupoArvore { get; set; }
        [NotMapped]
        public GrupoArvore GrupoArvore { get; set; }

        [NotMapped]
        public ICollection<Colheita> Colheitas { get; set; }
    }
}
