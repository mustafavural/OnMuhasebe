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
    public class BankaSubeManager : IBankaSubeService
    {
        IBankaSubeDal _bankaSubeDal;

        public BankaSubeManager(IBankaSubeDal bankaSubeDal)
        {
            _bankaSubeDal = bankaSubeDal;
        }

        #region BusinessRules
        private IResult CheckIfValidAdding(BankaSube entity)
        {
            var result = _bankaSubeDal.Get(p => p.Ad == entity.Ad && p.BankaId == entity.BankaId) != null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.BankaSubeAlreadyExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidId(int Id)
        {
            var result = _bankaSubeDal.Get(p => p.Id == Id) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.BankaSubeNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidAd(string ad)
        {
            var result = _bankaSubeDal.Get(p => p.Ad == ad) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.BankaSubeAdNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidBankaId(int bankaId)
        {
            var result = _bankaSubeDal.Get(p => p.BankaId == bankaId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.BankaNotExists);
            }
            return new SuccessResult();
        }
        #endregion

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<BankaSube> GetById(int Id)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(Id));
            if (result != null)
                return (IDataResult<BankaSube>)result;

            return new SuccessDataResult<BankaSube>(_bankaSubeDal.Get(p => p.Id == Id));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<BankaSube> GetByAd(string ad)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAd(ad));
            if (result != null)
                return (IDataResult<BankaSube>)result;

            return new SuccessDataResult<BankaSube>(_bankaSubeDal.Get(p => p.Ad == ad));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<List<BankaSube>> GetList()
        {
            return new SuccessDataResult<List<BankaSube>>(_bankaSubeDal.GetAll());
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<List<BankaSube>> GetListByBankaId(int bankaId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidBankaId(bankaId));
            if (result != null)
                return (IDataResult<List<BankaSube>>)result;

            return new SuccessDataResult<List<BankaSube>>(_bankaSubeDal.GetAll(p => p.BankaId == bankaId));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(BankaSubeValidator))]
        [CacheRemoveAspect("IBankaSubeService.Get")]
        public IResult Add(BankaSube entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAdding(entity));
            if (result != null)
                return result;

            _bankaSubeDal.Add(entity);
            return new SuccessResult(Messages.SuccessMessages.BankaSubeInserted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(BankaSubeValidator))]
        [CacheRemoveAspect("IBankaSubeService.Get")]
        public IResult Delete(BankaSube entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _bankaSubeDal.Delete(entity);
            return new SuccessResult(Messages.SuccessMessages.BankaSubeDeleted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(BankaSubeValidator))]
        [CacheRemoveAspect("IBankaSubeService.Get")]
        public IResult Update(BankaSube entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _bankaSubeDal.Update(entity);
            return new SuccessResult(Messages.SuccessMessages.BankaSubeUpdated);
        }
    }
}