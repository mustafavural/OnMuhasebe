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
using System.Collections.Generic;

namespace Business.Concrete
{
    public class KasaManager : IKasaService
    {
        IKasaDal _kasaDal;

        public KasaManager(IKasaDal kasaDal)
        {
            _kasaDal = kasaDal;
        }

        #region BusinessRules
        private IResult CheckIfValidAdding(Kasa entity)
        {
            var result = _kasaDal.Get(p => p.Ad == entity.Ad) != null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.KasaAlreadyExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidId(int Id)
        {
            var result = _kasaDal.Get(p => p.Id == Id) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.KasaNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidAd(string ad)
        {
            var result = _kasaDal.Get(p => p.Ad == ad) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.KasaNotExists);
            }
            return new SuccessResult();
        }
        #endregion

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<Kasa> GetById(int Id)
        {
            var result = BusinessRules.Run(
                CheckIfValidId(Id));
            if (result != null)
                return (IDataResult<Kasa>)result;

            return new SuccessDataResult<Kasa>(_kasaDal.Get(p => p.Id == Id));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<Kasa> GetByAd(string ad)
        {
            var result = BusinessRules.Run(
                CheckIfValidAd(ad));
            if (result != null)
                return (IDataResult<Kasa>)result;

            return new SuccessDataResult<Kasa>(_kasaDal.Get(p => p.Ad == ad));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<Kasa>> GetList()
        {
            return new SuccessDataResult<List<Kasa>>(_kasaDal.GetAll());
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(KasaValidator))]
        [CacheRemoveAspect("IKasaService.Get")]
        public IResult Add(Kasa entity)
        {
            var result = BusinessRules.Run(
                CheckIfValidAdding(entity));
            if (result != null)
                return result;

            _kasaDal.Add(entity);
            return new SuccessResult(Messages.SuccessMessages.KasaInserted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(KasaValidator))]
        [CacheRemoveAspect("IKasaService.Get")]
        public IResult Delete(Kasa entity)
        {
            var result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _kasaDal.Delete(entity);
            return new SuccessResult(Messages.SuccessMessages.KasaDeleted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(KasaValidator))]
        [CacheRemoveAspect("IKasaService.Get")]
        public IResult Update(Kasa entity)
        {
            var result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _kasaDal.Update(entity);
            return new SuccessResult(Messages.SuccessMessages.KasaUpdated);
        }
    }
}
