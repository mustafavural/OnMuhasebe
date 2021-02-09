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

namespace Business.Concrete
{
    public class BankaHesapHareketManager : IBankaHesapHareketService
    {
        IBankaHesapHareketDal _bankaHesapHareketDal;

        public BankaHesapHareketManager(IBankaHesapHareketDal bankaHesapHareketDal)
        {
            _bankaHesapHareketDal = bankaHesapHareketDal;
        }

        #region BusinessRules
        private IResult CheckIfValidId(int Id)
        {
            var result = _bankaHesapHareketDal.Get(p => p.Id == Id) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.BankaHesapActivityNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidAdding(BankaHesapHareket entity)
        {
            var result = _bankaHesapHareketDal.Get(p => p.BelgeNo == entity.BelgeNo) != null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.BankaHesapActivityAlreadyExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidDate(DateTime tarih)
        {
            var result = _bankaHesapHareketDal.Get(p => p.Tarih == tarih) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.BankaHesapActivityDateNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidPersonelHarId(int personelHarId)
        {
            var result = _bankaHesapHareketDal.Get(p => p.PersonelHarId == personelHarId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.PersonelActivityNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidHesapId(int hesapId)
        {
            var result = _bankaHesapHareketDal.Get(p => p.HesapId == hesapId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.BankaHesapNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidGirenMiktar(decimal girenMiktar)
        {
            var result = _bankaHesapHareketDal.Get(p => p.GirenMiktar == girenMiktar) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.GirenMiktarIsInvalid);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidCikanMiktar(decimal cikanMiktar)
        {
            var result = _bankaHesapHareketDal.Get(p => p.CikanMiktar == cikanMiktar) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CikanMiktarIsInvalid);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidCariHarId(int cariHarId)
        {
            var result = _bankaHesapHareketDal.Get(p => p.CariHarId == cariHarId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariActivityNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidBelgeNo(string belgeNo)
        {
            var result = _bankaHesapHareketDal.Get(p => p.BelgeNo == belgeNo) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.BankaHesapActivityNotExists);
            }
            return new SuccessResult();
        }
        #endregion

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<BankaHesapHareket> GetById(int Id)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(Id));
            if (result != null)
                return (SuccessDataResult<BankaHesapHareket>)result;

            return new SuccessDataResult<BankaHesapHareket>(_bankaHesapHareketDal.Get(p => p.Id == Id));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<BankaHesapHareket> GetByBelgeNo(string belgeNo)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidBelgeNo(belgeNo));
            if (result != null)
                return (SuccessDataResult<BankaHesapHareket>)result;

            return new SuccessDataResult<BankaHesapHareket>(_bankaHesapHareketDal.Get(p => p.BelgeNo == belgeNo));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<List<BankaHesapHareket>> GetList()
        {
            return new SuccessDataResult<List<BankaHesapHareket>>(_bankaHesapHareketDal.GetAll());
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<List<BankaHesapHareket>> GetListByCariHarId(int cariHarId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidCariHarId(cariHarId));
            if (result != null)
                return (SuccessDataResult<List<BankaHesapHareket>>)result;

            return new SuccessDataResult<List<BankaHesapHareket>>(_bankaHesapHareketDal.GetAll(p => p.CariHarId == cariHarId));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<List<BankaHesapHareket>> GetListByCikanMiktar(decimal cikanMiktar)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidCikanMiktar(cikanMiktar));
            if (result != null)
                return (SuccessDataResult<List<BankaHesapHareket>>)result;

            return new SuccessDataResult<List<BankaHesapHareket>>(_bankaHesapHareketDal.GetAll(p => p.CikanMiktar == cikanMiktar));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<List<BankaHesapHareket>> GetListByGirenMiktar(decimal girenMiktar)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidGirenMiktar(girenMiktar));
            if (result != null)
                return (SuccessDataResult<List<BankaHesapHareket>>)result;

            return new SuccessDataResult<List<BankaHesapHareket>>(_bankaHesapHareketDal.GetAll(p => p.GirenMiktar == girenMiktar));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<List<BankaHesapHareket>> GetListByHesapId(int hesapId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidHesapId(hesapId));
            if (result != null)
                return (SuccessDataResult<List<BankaHesapHareket>>)result;

            return new SuccessDataResult<List<BankaHesapHareket>>(_bankaHesapHareketDal.GetAll(p => p.HesapId == hesapId));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<List<BankaHesapHareket>> GetListByPersonelHarId(int personelHarId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidPersonelHarId(personelHarId));
            if (result != null)
                return (SuccessDataResult<List<BankaHesapHareket>>)result;

            return new SuccessDataResult<List<BankaHesapHareket>>(_bankaHesapHareketDal.GetAll(p => p.PersonelHarId == personelHarId));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<List<BankaHesapHareket>> GetListByTarih(DateTime tarih)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidDate(tarih));
            if (result != null)
                return (SuccessDataResult<List<BankaHesapHareket>>)result;

            return new SuccessDataResult<List<BankaHesapHareket>>(_bankaHesapHareketDal.GetAll(p => p.Tarih == tarih));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(BankaHesapHareketValidator))]
        [CacheRemoveAspect("IBankaHesapHareketService.Get")]
        public IResult Add(BankaHesapHareket entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAdding(entity));
            if (result != null)
                return result;

            _bankaHesapHareketDal.Add(entity);
            return new SuccessResult(Messages.SuccessMessages.BankaHesapActivityInserted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(BankaHesapHareketValidator))]
        [CacheRemoveAspect("IBankaHesapHareketService.Get")]
        public IResult Delete(BankaHesapHareket entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _bankaHesapHareketDal.Delete(entity);
            return new SuccessResult(Messages.SuccessMessages.BankaHesapActivityDeleted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(BankaHesapHareketValidator))]
        [CacheRemoveAspect("IBankaHesapHareketService.Get")]
        public IResult Update(BankaHesapHareket entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _bankaHesapHareketDal.Update(entity);
            return new SuccessResult(Messages.SuccessMessages.BankaHesapActivityUpdated);
        }
    }
}