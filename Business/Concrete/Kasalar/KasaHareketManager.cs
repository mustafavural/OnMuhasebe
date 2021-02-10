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
    public class KasaHareketManager : IKasaHareketService
    {
        IKasaHareketDal _kasaHareketDal;

        public KasaHareketManager(IKasaHareketDal kasaHareketDal)
        {
            _kasaHareketDal = kasaHareketDal;
        }

        #region BusinessRules
        private IResult CheckIfValidAdding(KasaHareket entity)
        {
            var result = _kasaHareketDal.Get(p => p.BelgeNo == entity.BelgeNo) != null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.KasaActivityAlreadyExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidId(int Id)
        {
            var result = _kasaHareketDal.Get(p => p.Id == Id) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.KasaActivityNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidBelgeNo(string belgeNo)
        {
            var result = _kasaHareketDal.Get(p => p.BelgeNo == belgeNo) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.KasaActivityBelgeNoNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidTarih(DateTime tarih)
        {
            var result = _kasaHareketDal.Get(p => p.Tarih == tarih) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.KasaActivityDateNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidPersonelHarId(int personelHarId)
        {
            var result = _kasaHareketDal.Get(p => p.PersonelHarId == personelHarId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.PersonelActivityNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidKasaId(int kasaId)
        {
            var result = _kasaHareketDal.Get(p => p.KasaId == kasaId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.KasaNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidCariHarId(int cariHarId)
        {
            var result = _kasaHareketDal.Get(p => p.CariHarId == cariHarId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariActivityNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidGirenMiktar(decimal girenMiktar)
        {
            var result = _kasaHareketDal.Get(p => p.GirenMiktar == girenMiktar) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.GirenMiktarIsInvalid);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidCikanMiktar(decimal cikanMiktar)
        {
            var result = _kasaHareketDal.Get(p => p.CikanMiktar == cikanMiktar) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CikanMiktarIsInvalid);
            }
            return new SuccessResult();
        }
        #endregion

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<KasaHareket> GetById(int Id)
        {
            var result = BusinessRules.Run(
                CheckIfValidId(Id));
            if (result != null)
                return (IDataResult<KasaHareket>)result;

            return new SuccessDataResult<KasaHareket>(_kasaHareketDal.Get(p => p.Id == Id));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<KasaHareket> GetByBelgeNo(string belgeNo)
        {
            var result = BusinessRules.Run(
                CheckIfValidBelgeNo(belgeNo));
            if (result != null)
                return (IDataResult<KasaHareket>)result;

            return new SuccessDataResult<KasaHareket>(_kasaHareketDal.Get(p => p.BelgeNo == belgeNo));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<KasaHareket>> GetList()
        {
            return new SuccessDataResult<List<KasaHareket>>(_kasaHareketDal.GetAll());
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<KasaHareket>> GetListByCariId(int cariId)
        {
            var result = BusinessRules.Run(
                CheckIfValidCariHarId(cariId));
            if (result != null)
                return (IDataResult<List<KasaHareket>>)result;

            return new SuccessDataResult<List<KasaHareket>>(_kasaHareketDal.GetAll(p => p.CariHarId == cariId));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<KasaHareket>> GetListByCikanMiktar(decimal cikanMiktar)
        {
            var result = BusinessRules.Run(
                CheckIfValidCikanMiktar(cikanMiktar));
            if (result != null)
                return (IDataResult<List<KasaHareket>>)result;

            return new SuccessDataResult<List<KasaHareket>>(_kasaHareketDal.GetAll(p => p.CikanMiktar == cikanMiktar));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<KasaHareket>> GetListByGirenMiktar(decimal girenMiktar)
        {
            var result = BusinessRules.Run(
                CheckIfValidGirenMiktar(girenMiktar));
            if (result != null)
                return (IDataResult<List<KasaHareket>>)result;

            return new SuccessDataResult<List<KasaHareket>>(_kasaHareketDal.GetAll(p => p.GirenMiktar == girenMiktar));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<KasaHareket>> GetListByKasaId(int kasaId)
        {
            var result = BusinessRules.Run(
                CheckIfValidKasaId(kasaId));
            if (result != null)
                return (IDataResult<List<KasaHareket>>)result;

            return new SuccessDataResult<List<KasaHareket>>(_kasaHareketDal.GetAll(p => p.KasaId == kasaId));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<KasaHareket>> GetListByPersonelId(int personelId)
        {
            var result = BusinessRules.Run(
                CheckIfValidPersonelHarId(personelId));
            if (result != null)
                return (IDataResult<List<KasaHareket>>)result;

            return new SuccessDataResult<List<KasaHareket>>(_kasaHareketDal.GetAll(p => p.PersonelHarId == personelId));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<KasaHareket>> GetListByTarih(DateTime tarih)
        {
            var result = BusinessRules.Run(
                CheckIfValidTarih(tarih));
            if (result != null)
                return (IDataResult<List<KasaHareket>>)result;

            return new SuccessDataResult<List<KasaHareket>>(_kasaHareketDal.GetAll(p => p.Tarih == tarih));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(KasaHareketValidator))]
        [CacheRemoveAspect("IKasaHareketService.Get")]
        public IResult Add(KasaHareket entity)
        {
            var result = BusinessRules.Run(
                CheckIfValidAdding(entity));
            if (result != null)
                return (IDataResult<List<KasaHareket>>)result;

            _kasaHareketDal.Add(entity);
            return new SuccessResult(Messages.SuccessMessages.KasaActivityInserted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(KasaHareketValidator))]
        [CacheRemoveAspect("IKasaHareketService.Get")]
        public IResult Delete(KasaHareket entity)
        {
            var result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return (IDataResult<List<KasaHareket>>)result;

            _kasaHareketDal.Delete(entity);
            return new SuccessResult(Messages.SuccessMessages.KasaActivityDeleted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(KasaHareketValidator))]
        [CacheRemoveAspect("IKasaHareketService.Get")]
        public IResult Update(KasaHareket entity)
        {
            var result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return (IDataResult<List<KasaHareket>>)result;

            _kasaHareketDal.Add(entity);
            return new SuccessResult(Messages.SuccessMessages.KasaActivityUpdated);
        }
    }
}
