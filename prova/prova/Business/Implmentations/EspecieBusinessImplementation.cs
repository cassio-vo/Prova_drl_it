using prova.Data.Converters;
using prova.Data.VO;
using prova.Model;
using prova.Repository.Generic;
using System;
using System.Collections.Generic;

namespace prova.Business.Implmentations
{
    public class EspecieBusinessImplementation : IEspecieBusiness
    {
        private IRepository<Especie> _repository;
        private readonly EspecieConverter _converter;

        public EspecieBusinessImplementation(IRepository<Especie> repository)
        {
            _repository = repository;
            _converter = new EspecieConverter();
        }

        public EspecieVO Create(EspecieVO especie)
        {
            return _converter.Parse(_repository.Create(_converter.Parse(especie)));
        }

        public void Delete(long Id)
        {
            _repository.Delete(Id);
        }

        public bool Exist(long id)
        {
            return _repository.Exist(id);
        }

        public List<EspecieVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public EspecieVO FindById(long Id)
        {
            return _converter.Parse(_repository.FindById(Id));
        }

        public EspecieVO Update(EspecieVO especie)
        {
            return _converter.Parse(_repository.Update(_converter.Parse(especie)));
        }
    }
}
