﻿using prova.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prova.Model
{
    public class Colheita : BaseEntity
    {
        public string Informacoes { get; set; }

        public DateTime DataColheita { get; set; }

        public decimal PesoBruto { get; set; }

        public int IdArvore { get; set; }
        [NotMapped]
        public Arvore Arvore { get; set; }
    }
}
