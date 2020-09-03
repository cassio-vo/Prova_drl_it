using prova.Data.Converter;
using prova.Data.VO;
using prova.Model;
using System.Collections.Generic;
using System.Linq;

namespace prova.Data.Converters
{
    public class ArvoreConverter : IParser<ArvoreVO, Arvore>, IParser<Arvore, ArvoreVO>
    {
        public Arvore Parse(ArvoreVO origin)
        {
            if (origin == null)
                return null;
            else
                return new Arvore
                {
                    Id = origin.Id,
                    IdEspecie = origin.IdEspecie,
                    IdGrupoArvore = origin.IdGrupoArvore,
                    Descricao = origin.Descricao,
                    Idade = origin.Idade
                };
        }

        public ArvoreVO Parse(Arvore origin)
        {
            if (origin == null)
                return null;
            else
                return new ArvoreVO
                {
                    Id = origin.Id,
                    IdEspecie = origin.IdEspecie,
                    IdGrupoArvore = origin.IdGrupoArvore,
                    Descricao = origin.Descricao,
                    Idade = origin.Idade
                };
        }

        public List<Arvore> ParseList(List<ArvoreVO> origin)
        {
            if (origin == null)
                return null;
            else
                return origin.Select(x => Parse(x)).ToList();
        }

        public List<ArvoreVO> ParseList(List<Arvore> origin)
        {
            if (origin == null)
                return null;
            else
                return origin.Select(x => Parse(x)).ToList();
        }
    }
}
