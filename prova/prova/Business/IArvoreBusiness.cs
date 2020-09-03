using prova.Data.VO;
using System.Collections.Generic;

namespace prova.Business
{
    public interface IArvoreBusiness
    {
        ArvoreVO Create(ArvoreVO arvore);

        ArvoreVO FindById(long Id);

        List<ArvoreVO> FindAll();

        ArvoreVO Update(ArvoreVO arvore);

        void Delete(long Id);

        bool Exist(long id);
    }
}
