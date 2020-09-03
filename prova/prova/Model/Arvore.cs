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

        public int CodigoEspecie { get; set; }

        public int CodigoGrupo { get; set; }
    }
}
