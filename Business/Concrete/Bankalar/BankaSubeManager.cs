using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class BankaSubeManager : IBankaSubeService
    {//TODO:implementasyon eksik
        IBankaSubeDal _bankaSubeDal;

        public BankaSubeManager(IBankaSubeDal bankaSubeDal)
        {
            _bankaSubeDal = bankaSubeDal;
        }

        public IDataResult<BankaSube> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<BankaSube> GetByAd(string ad)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BankaSube>> GetList()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BankaSube>> GetListByBankaId(int bankaId)
        {
            throw new NotImplementedException();
        }

        public IResult Add(BankaSube entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(BankaSube entity)
        {
            throw new NotImplementedException();
        }

        public IResult Update(BankaSube entity)
        {
            throw new NotImplementedException();
        }
    }
}