using prova.Data.Converter;
using prova.Data.VO;
using prova.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prova.Data.Converters
{
    public class EspecieConverter : IParser<EspecieVO, Especie>, IParser<Especie, EspecieVO>
    {
        public Especie Parse(EspecieVO origin)
        {
            if (origin == null)
                return null;
            else
                return new Especie
                {
                    Id = origin.Id,
                    Descricao = origin.Descricao
                };
        }

        public EspecieVO Parse(Especie origin)
        {
            if (origin == null)
                return null;
            else
                return new EspecieVO
                {
                    Id = origin.Id,
                    Descricao = origin.Descricao
                };
        }

        public List<Especie> ParseList(List<EspecieVO> origin)
        {
            if (origin == null)
                return null;
            else
                return origin.Select(x => Parse(x)).ToList();
        }

        public List<EspecieVO> ParseList(List<Especie> origin)
        {
            if (origin == null)
                return null;
            else
                return origin.Select(x => Parse(x)).ToList();
        }
    }
}
