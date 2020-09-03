using prova.Data.Converter;
using prova.Data.VO;
using prova.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prova.Data.Converters
{
    public class GrupoArvoreConverter : IParser<GrupoArvoreVO, GrupoArvore>, IParser<GrupoArvore, GrupoArvoreVO>
    {
        public GrupoArvore Parse(GrupoArvoreVO origin)
        {
            if (origin == null)
                return null;
            else
                return new GrupoArvore
                {
                    Id = origin.Id,
                    Descricao = origin.Descricao,
                    Nome = origin.Nome
                };
        }

        public GrupoArvoreVO Parse(GrupoArvore origin)
        {
            if (origin == null)
                return null;
            else
                return new GrupoArvoreVO
                {
                    Id = origin.Id,
                    Descricao = origin.Descricao,
                    Nome = origin.Nome
                };
        }

        public List<GrupoArvore> ParseList(List<GrupoArvoreVO> origin)
        {
            if (origin == null)
                return null;
            else
                return origin.Select(x => Parse(x)).ToList();
        }

        public List<GrupoArvoreVO> ParseList(List<GrupoArvore> origin)
        {
            if (origin == null)
                return null;
            else
                return origin.Select(x => Parse(x)).ToList();
        }
    }
}
