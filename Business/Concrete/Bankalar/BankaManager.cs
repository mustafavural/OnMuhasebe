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
    public class BankaManager : IBankaService
    {
        IBankaDal _bankaDal;

        public BankaManager(IBankaDal bankaDal)
        {
            _bankaDal = bankaDal;
        }

        #region BusinessRules
        private IResult CheckIfValidAdding(Banka entity)
        {
            var result = _bankaDal.Get(p => p.Ad == entity.Ad) != null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.BankaAlreadyExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidId(int Id)
        {
            var result = _bankaDal.Get(p => p.Id == Id) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.BankaNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidAd(string ad)
        {
            var result = _bankaDal.Get(p => p.Ad == ad) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.BankaNotExists);
            }
            return new SuccessResult();
        }
        #endregion

        
        public IDataResult<Banka> GetById(int Id)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(Id));
            if (result != null)
                return (IDataResult<Banka>)result;

            return new SuccessDataResult<Banka>(_bankaDal.Get(p => p.Id == Id));
        }

        
        public IDataResult<Banka> GetByAd(string ad)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAd(ad));
            if (result != null)
                return (IDataResult<Banka>)result;

            return new SuccessDataResult<Banka>(_bankaDal.Get(p => p.Ad == ad));
        }

        
        public IDataResult<List<Banka>> GetList()
        {
            return new SuccessDataResult<List<Banka>>(_bankaDal.GetAll());
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(BankaValidator))]
        [CacheRemoveAspect("IBankaService.Get")]
        public IResult Add(Banka entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAdding(entity));
            if (result != null)
                return result;

            _bankaDal.Add(entity);
            return new SuccessResult(Messages.SuccessMessages.BankaInserted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(BankaValidator))]
        [CacheRemoveAspect("IBankaService.Get")]
        public IResult Delete(Banka entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _bankaDal.Delete(entity);
            return new SuccessResult(Messages.SuccessMessages.BankaDeleted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(BankaValidator))]
        [CacheRemoveAspect("IBankaService.Get")]
        public IResult Update(Banka entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _bankaDal.Update(entity);
            return new SuccessResult(Messages.SuccessMessages.BankaUpdated);
        }
    }
}