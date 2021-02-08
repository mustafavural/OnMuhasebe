using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class PersonelHareketManager : IPersonelHareketService
    {//TODO:implementasyon eksik
        IPersonelHareketDal _personelHareketDal;

        public PersonelHareketManager(IPersonelHareketDal personelHareketDal)
        {
            _personelHareketDal = personelHareketDal;
        }

        public IDataResult<PersonelHareket> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<PersonelHareket>> GetList()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<PersonelHareket>> GetListByIslemTarihi(DateTime tarih)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<PersonelHareket>> GetListByPersonelId(int personelId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<PersonelHareket>> GetListByTur(string tur)
        {
            throw new NotImplementedException();
        }

        public IResult Add(PersonelHareket entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(PersonelHareket entity)
        {
            throw new NotImplementedException();
        }

        public IResult Update(PersonelHareket entity)
        {
            throw new NotImplementedException();
        }
    }
}