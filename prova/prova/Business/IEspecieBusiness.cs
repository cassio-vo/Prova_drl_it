using prova.Data.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prova.Business
{
    public interface IEspecieBusiness
    {
        EspecieVO Create(EspecieVO especie);

        EspecieVO FindById(long Id);

        List<EspecieVO> FindAll();

        EspecieVO Update(EspecieVO especie);

        void Delete(long Id);

        bool Exist(long id);
    }
}
