using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class BankaManager : IBankaService
    {//TODO:implementasyon eksik
        IBankaDal _bankaDal;

        public BankaManager(IBankaDal bankaDal)
        {
            _bankaDal = bankaDal;
        }

        public IDataResult<Banka> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Banka> GetByAd(string ad)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Banka>> GetList()
        {
            throw new NotImplementedException();
        }

        public IResult Add(Banka entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Banka entity)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Banka entity)
        {
            throw new NotImplementedException();
        }
    }
}