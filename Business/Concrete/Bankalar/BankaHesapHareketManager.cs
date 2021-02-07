using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class BankaHesapHareketManager : IBankaHesapHareketService
    {//TODO:implementasyon eksik
        IBankaHesapHareketDal _bankaHesapHareketDal;

        public BankaHesapHareketManager(IBankaHesapHareketDal bankaHesapHareketDal)
        {
            _bankaHesapHareketDal = bankaHesapHareketDal;
        }

        public IDataResult<BankaHesapHareket> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<BankaHesapHareket> GetByBelgeNo(string belgeNo)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BankaHesapHareket>> GetList()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BankaHesapHareket>> GetListByCariHarId(int cariHarId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BankaHesapHareket>> GetListByCikanMiktar(decimal cikanMiktar)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BankaHesapHareket>> GetListByGirenMiktar(decimal girenMiktar)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BankaHesapHareket>> GetListByHesapId(int hesapId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BankaHesapHareket>> GetListByPersonelHarId(int persnoelHarId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BankaHesapHareket>> GetListByTarih(DateTime tarih)
        {
            throw new NotImplementedException();
        }

        public IResult Add(BankaHesapHareket entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(BankaHesapHareket entity)
        {
            throw new NotImplementedException();
        }

        public IResult Update(BankaHesapHareket entity)
        {
            throw new NotImplementedException();
        }
    }
}