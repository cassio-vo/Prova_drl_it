using prova.Data.Converters;
using prova.Data.VO;
using prova.Model;
using prova.Repository.Generic;
using System;
using System.Collections.Generic;

namespace prova.Business.Implmentations
{
    public class GrupoArvoreBusinessImplementation : IGrupoArvoreBusiness
    {
        private IRepository<GrupoArvore> _repository;
        private readonly GrupoArvoreConverter _converter;

        public GrupoArvoreBusinessImplementation(IRepository<GrupoArvore> repository)
        {
            _repository = repository;
            _converter = new GrupoArvoreConverter();
        }

        public GrupoArvoreVO Create(GrupoArvoreVO grupo)
        {
            return _converter.Parse(_repository.Create(_converter.Parse(grupo)));
        }

        public void Delete(long Id)
        {
            _repository.Delete(Id);
        }

        public bool Exist(long id)
        {
            return _repository.Exist(id);
        }

        public List<GrupoArvoreVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public GrupoArvoreVO FindById(long Id)
        {
            return _converter.Parse(_repository.FindById(Id));
        }

        public GrupoArvoreVO Update(GrupoArvoreVO grupo)
        {
            return _converter.Parse(_repository.Update(_converter.Parse(grupo)));
        }
    }
}
