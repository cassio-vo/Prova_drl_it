using System;

namespace prova.Data.VO
{
    public class ColheitaVO : Recurso
    {
        public string Informacoes { get; set; }

        public DateTime DataColheita { get; set; }

        public decimal PesoBruto { get; set; }

        public int Arvore { get; set; }
    }
}
