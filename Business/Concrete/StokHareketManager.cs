using Business.Abstract;
using Business.Constans;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class StokHareketManager : IStokHareketService
    {
        IStokHareketDal _stokHareketDal;

        public StokHareketManager(IStokHareketDal stokHareketDal)
        {
            _stokHareketDal = stokHareketDal;
        }

        public IResult Add(StokHareket stokHareket)
        {
            _stokHareketDal.Add(stokHareket);
            return new SuccessResult(Messages.StockActivityAdded);
        }

        public IResult Delete(StokHareket stokHareket)
        {
            _stokHareketDal.Delete(stokHareket);
            return new SuccessResult(Messages.StockActivityDeleted);
        }

        public IResult Update(StokHareket stokHareket)
        {
            _stokHareketDal.Update(stokHareket);
            return new SuccessResult(Messages.StockActivityUpdated);
        }

        public IDataResult<StokHareket> GetById(int stokHareketId)
        {
            return new SuccessDataResult<StokHareket>(_stokHareketDal.Get(p => p.Id == stokHareketId));
        }

        public IDataResult<List<StokHareket>> GetByDepoId(int depoId)
        {
            return new SuccessDataResult<List<StokHareket>>(_stokHareketDal.GetAll(p => p.DepoId == depoId));
        }

        public IDataResult<List<StokHareket>> GetByFaturaId(int faturaId)
        {
            return new SuccessDataResult<List<StokHareket>>(_stokHareketDal.GetAll(p => p.FaturaId == faturaId));
        }

        public IDataResult<List<StokHareket>> GetByStokId(int stokId)
        {
            return new SuccessDataResult<List<StokHareket>>(_stokHareketDal.GetAll(p => p.StokId == stokId));
        }
    }
}