using prova.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prova.Model
{
    public class Arvore : BaseEntity
    {
        public string Descricao { get; set; }

        public int Idade { get; set; }

        public int IdEspecie { get; set; }
        public Especie Especie { get; set; }

        public int IdGrupoArvore { get; set; }
        public GrupoArvore GrupoArvore { get; set; }

        public ICollection<Colheita> Colheitas { get; set; }
    }
}
