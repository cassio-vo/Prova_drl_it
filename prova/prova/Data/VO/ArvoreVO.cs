﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prova.Data.VO
{
    public class ArvoreVO : Recurso
    {
        public string Descricao { get; set; }

        public int Idade { get; set; }

        public int IdEspecie { get; set; }

        public int IdGrupoArvore { get; set; }
    }
}
