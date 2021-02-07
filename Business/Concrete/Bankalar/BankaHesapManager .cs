using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class BankaHesapManager : IBankaHesapService
    {//TODO:implementasyon eksik
        IBankaHesapDal _bankaHesapDal;

        public BankaHesapManager(IBankaHesapDal bankaHesapDal)
        {
            _bankaHesapDal = bankaHesapDal;
        }

        public IDataResult<BankaHesap> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<BankaHesap> GetByAd(string ad)
        {
            throw new NotImplementedException();
        }

        public IDataResult<BankaHesap> GetByIBAN(string iban)
        {
            throw new NotImplementedException();
        }

        public IDataResult<BankaHesap> GetByNo(string no)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BankaHesap>> GetList()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BankaHesap>> GetListByMusteriYetkili(string musteriYetkili)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BankaHesap>> GetListBySubeId(int subeId)
        {
            throw new NotImplementedException();
        }

        public IResult Add(BankaHesap entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(BankaHesap entity)
        {
            throw new NotImplementedException();
        }

        public IResult Update(BankaHesap entity)
        {
            throw new NotImplementedException();
        }
    }
}