using prova.Data.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prova.Business.Implmentations
{
    public interface IColheitaBusiness
    {
        ColheitaVO Create(ColheitaVO colheita);

        ColheitaVO FindById(long Id);

        List<ColheitaVO> FindAll();

        ColheitaVO Update(ColheitaVO colheita);

        void Delete(long Id);

        bool Exist(long id);
    }
}
