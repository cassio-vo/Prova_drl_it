using prova.Data.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prova.Business
{
    public interface IGrupoArvoreBusiness
    {
        GrupoArvoreVO Create(GrupoArvoreVO grupo);

        GrupoArvoreVO FindById(long Id);

        List<GrupoArvoreVO> FindAll();

        GrupoArvoreVO Update(GrupoArvoreVO grupo);

        void Delete(long Id);

        bool Exist(long id);
    }
}
