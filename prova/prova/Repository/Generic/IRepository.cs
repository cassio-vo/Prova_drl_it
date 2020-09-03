using prova.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prova.Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);

        T FindById(long? Id);

        List<T> FindAll();

        T Update(T item);

        void Delete(long Id);

        bool Exist(long? id);
    }
}
