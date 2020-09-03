using prova.Data.Converter;
using prova.Data.VO;
using prova.Model;
using System.Collections.Generic;
using System.Linq;

namespace prova.Data.Converters
{
    public class ColheitaConverter : IParser<ColheitaVO, Colheita>, IParser<Colheita, ColheitaVO>
    {
        public Colheita Parse(ColheitaVO origin)
        {
            if (origin == null)
                return null;
            else
                return new Colheita
                {
                    Id = origin.Id,
                    IdArvore = origin.Arvore,
                    DataColheita = origin.DataColheita,
                    Informacoes = origin.Informacoes,
                    PesoBruto = origin.PesoBruto
                };
        }

        public ColheitaVO Parse(Colheita origin)
        {
            if (origin == null)
                return null;
            else
                return new ColheitaVO
                {
                    Id = origin.Id,
                    Arvore = origin.IdArvore,
                    DataColheita = origin.DataColheita,
                    Informacoes = origin.Informacoes,
                    PesoBruto = origin.PesoBruto
                };
        }

        public List<Colheita> ParseList(List<ColheitaVO> origin)
        {
            if (origin == null)
                return null;
            else
                return origin.Select(x => Parse(x)).ToList();
        }

        public List<ColheitaVO> ParseList(List<Colheita> origin)
        {
            if (origin == null)
                return null;
            else
                return origin.Select(x => Parse(x)).ToList();
        }
    }
}
