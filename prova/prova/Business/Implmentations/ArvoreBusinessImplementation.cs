using prova.Data.Converters;
using prova.Data.VO;
using prova.Model;
using prova.Repository.Generic;
using System;
using System.Collections.Generic;

namespace prova.Business.Implmentations
{
    public class ArvoreBusinessImplementation : IArvoreBusiness
    {
        private IRepository<Arvore> _repository;
        private readonly ArvoreConverter _converter;

        public ArvoreBusinessImplementation(IRepository<Arvore> repository)
        {
            _repository = repository;
            _converter = new ArvoreConverter();
        }

        public ArvoreVO Create(ArvoreVO arvore)
        {
            return _converter.Parse(_repository.Create(_converter.Parse(arvore)));
        }

        public void Delete(long Id)
        {
            _repository.Delete(Id);
        }

        public bool Exist(long id)
        {
            return _repository.Exist(id);
        }

        public List<ArvoreVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public ArvoreVO FindById(long Id)
        {
            return _converter.Parse(_repository.FindById(Id));
        }

        public ArvoreVO Update(ArvoreVO arvore)
        {
            return _converter.Parse(_repository.Update(_converter.Parse(arvore)));
        }
    }
}
