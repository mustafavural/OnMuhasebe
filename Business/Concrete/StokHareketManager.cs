using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation.Stoklar;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class StokHareketManager : IStokHareketService
    {
        IStokHareketDal _stokHareketDal;

        public StokHareketManager(IStokHareketDal stokHareketDal)
        {
            _stokHareketDal = stokHareketDal;
        }

        [ValidationAspect(typeof(StokHareketValidator), Priority = 1)]
        public IResult Add(StokHareket stokHareket)
        {
            _stokHareketDal.Add(stokHareket);
            return new SuccessResult(Messages.StockActivityAdded);
        }

        [ValidationAspect(typeof(StokHareketValidator), Priority = 1)]
        public IResult Delete(StokHareket stokHareket)
        {
            _stokHareketDal.Delete(stokHareket);
            return new SuccessResult(Messages.StockActivityDeleted);
        }

        [ValidationAspect(typeof(StokHareketValidator), Priority = 1)]
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