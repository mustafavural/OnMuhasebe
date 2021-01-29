using Business.Abstract;
using Business.Constans;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class CariHareketManager : ICariHareketService
    {
        ICariHareketDal _cariHareketDal;
        public IResult Add(CariHareket cariHareket)
        {
            _cariHareketDal.Add(cariHareket);
            return new SuccessResult(Messages.CariActivityAdded);
        }

        public IResult Delete(CariHareket cariHareket)
        {
            _cariHareketDal.Delete(cariHareket);
            return new SuccessResult(Messages.CariActivityDeleted);
        }

        public IResult Update(CariHareket cariHareket)
        {
            _cariHareketDal.Add(cariHareket);
            return new SuccessResult(Messages.CariActivityUpdated);
        }

        public IDataResult<CariHareket> GetById(int cariHareketId)
        {
            return new SuccessDataResult<CariHareket>(_cariHareketDal.Get(p => p.Id == cariHareketId));
        }

        public IDataResult<decimal> GetTotalBorcOnCari(int cariId)
        {
            return new SuccessDataResult<decimal>(_cariHareketDal.GetAll(p => p.CariId == cariId).Select(s => s.Borc).Sum());
        }

        public IDataResult<decimal> GetTotalAlacakOnCari(int cariId)
        {
            return new SuccessDataResult<decimal>(_cariHareketDal.GetAll(p => p.CariId == cariId).Select(s => s.Alacak).Sum());
        }

        public IDataResult<List<CariHareket>> GetListByCariId(int cariId)
        {
            return new SuccessDataResult<List<CariHareket>>(_cariHareketDal.GetAll(p => p.CariId == cariId));
        }

        public IDataResult<List<CariHareket>> GetListByDate(DateTime cariHareketTarih)
        {
            return new SuccessDataResult<List<CariHareket>>(_cariHareketDal.GetAll(p => p.Tarih == cariHareketTarih));
        }
    }
}