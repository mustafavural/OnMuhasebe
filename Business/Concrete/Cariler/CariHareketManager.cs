using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
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
        ICariDal<Cari> _cariDal;

        public CariHareketManager(ICariHareketDal cariHareketDal, ICariDal<Cari> cariDal)
        {
            _cariHareketDal = cariHareketDal;
            _cariDal = cariDal;
        }
        #region BusinessRules
        private IResult CheckIfValidId(int Id)
        {
            var result = _cariHareketDal.Get(p => p.Id == Id) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariActivityNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidCariId(int cariId)
        {
            var result = _cariHareketDal.Get(p => p.CariId == cariId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidAdding(CariHareket cariHareket)
        {
            var result = _cariDal.Get(p => p.Id == cariHareket.CariId) != null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariNotExists);
            }
            return new SuccessResult();
        }
        #endregion

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<CariHareket> GetById(int cariHareketId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(cariHareketId));
            if (result != null)
                return (IDataResult<CariHareket>)result;

            return new SuccessDataResult<CariHareket>(_cariHareketDal.Get(p => p.Id == cariHareketId));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<decimal> GetTotalBorcOnCari(int cariId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidCariId(cariId));
            if (result != null)
                return (IDataResult<decimal>)result;

            return new SuccessDataResult<decimal>(_cariHareketDal.GetAll(p => p.CariId == cariId).Select(s => s.Borc).Sum());
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<decimal> GetTotalAlacakOnCari(int cariId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidCariId(cariId));
            if (result != null)
                return (IDataResult<decimal>)result;

            return new SuccessDataResult<decimal>(_cariHareketDal.GetAll(p => p.CariId == cariId).Select(s => s.Alacak).Sum());
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<decimal> GetTotalBakiye(int cariId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidCariId(cariId));
            if (result != null)
                return (IDataResult<decimal>)result;

            return new SuccessDataResult<decimal>(GetTotalBorcOnCari(cariId).Data - GetTotalAlacakOnCari(cariId).Data);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<List<CariHareket>> GetList()
        {
            return new SuccessDataResult<List<CariHareket>>(_cariHareketDal.GetAll());
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<List<CariHareket>> GetListByCariId(int cariId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidCariId(cariId));
            if (result != null)
                return (IDataResult<List<CariHareket>>)result;

            return new SuccessDataResult<List<CariHareket>>(_cariHareketDal.GetAll(p => p.CariId == cariId));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<List<CariHareket>> GetListByDate(DateTime cariHareketTarih)
        {
            return new SuccessDataResult<List<CariHareket>>(_cariHareketDal.GetAll(p => p.Tarih == cariHareketTarih));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(CariHareketValidator))]
        [CacheRemoveAspect("ICariHareketService.Get")]
        public IResult Add(CariHareket cariHareket)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAdding(cariHareket));
            if (result != null)
                return result;

            _cariHareketDal.Add(cariHareket);
            return new SuccessResult(Messages.SuccessMessages.CariActivityInserted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(CariHareketValidator))]
        [CacheRemoveAspect("ICariHareketService.Get")]
        public IResult Delete(CariHareket cariHareket)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(cariHareket.Id));
            if (result != null)
                return result;

            _cariHareketDal.Delete(cariHareket);
            return new SuccessResult(Messages.SuccessMessages.CariActivityDeleted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(CariHareketValidator))]
        [CacheRemoveAspect("ICariHareketService.Get")]
        public IResult Update(CariHareket cariHareket)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(cariHareket.Id));
            if (result != null)
                return result;

            _cariHareketDal.Update(cariHareket);
            return new SuccessResult(Messages.SuccessMessages.CariActivityUpdated);
        }
    }
}