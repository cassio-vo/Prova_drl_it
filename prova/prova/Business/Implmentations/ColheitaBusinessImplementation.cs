using prova.Data.Converters;
using prova.Data.VO;
using prova.Model;
using prova.Repository.Generic;
using System;
using System.Collections.Generic;

namespace prova.Business.Implmentations
{
    public class ColheitaBusinessImplementation : IColheitaBusiness
    {
        private IRepository<Colheita> _repository;
        private readonly ColheitaConverter _converter;

        public ColheitaBusinessImplementation(IRepository<Colheita> repository)
        {
            _repository = repository;
            _converter = new ColheitaConverter();
        }

        public ColheitaVO Create(ColheitaVO colheita)
        {
            return _converter.Parse(_repository.Create(_converter.Parse(colheita)));
        }

        public void Delete(long Id)
        {
            _repository.Delete(Id);
        }

        public bool Exist(long id)
        {
            return _repository.Exist(id);
        }

        public List<ColheitaVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public ColheitaVO FindById(long Id)
        {
            return _converter.Parse(_repository.FindById(Id));
        }

        public ColheitaVO Update(ColheitaVO colheita)
        {
            return _converter.Parse(_repository.Update(_converter.Parse(colheita)));
        }
    }
}
