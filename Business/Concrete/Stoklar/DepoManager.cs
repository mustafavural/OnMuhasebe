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
    public class DepoManager : IDepoService
    {
        IDepoDal _depoDal;

        public DepoManager(IDepoDal depoDal)
        {
            _depoDal = depoDal;
        }

        #region BusinessRules
        private IResult CheckIfValidAdding(Depo entity)
        {
            var result = _depoDal.Get(p => p.Ad == entity.Ad) != null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.DepoAlreadyExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidAdresId(int adresId)
        {
            var result = _depoDal.Get(p => p.AdresId == adresId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.AdresNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidId(int id)
        {
            var result = _depoDal.Get(p => p.Id == id) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.DepoNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidAd(string ad)
        {
            var result = _depoDal.Get(p => p.Ad == ad) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.DepoAdNotExists);
            }
            return new SuccessResult();
        }
        #endregion

        
        public IDataResult<Depo> GetById(int Id)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(Id));
            if (result != null)
                return (IDataResult<Depo>)result;

            return new SuccessDataResult<Depo>(_depoDal.Get(p => p.Id == Id));
        }

        
        public IDataResult<Depo> GetByAdresId(int adresId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAdresId(adresId));
            if (result != null)
                return (IDataResult<Depo>)result;

            return new SuccessDataResult<Depo>(_depoDal.Get(p => p.AdresId == adresId));
        }

        
        public IDataResult<Depo> GetByAd(string ad)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAd(ad));
            if (result != null)
                return (IDataResult<Depo>)result;

            return new SuccessDataResult<Depo>(_depoDal.Get(p => p.Ad == ad));
        }

        
        public IDataResult<List<Depo>> GetList()
        {
            return new SuccessDataResult<List<Depo>>(_depoDal.GetAll());
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(DepoValidator))]
        [CacheRemoveAspect("IDepoService.Get")]
        public IResult Add(Depo entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAdding(entity));
            if (result != null)
                return result;

            _depoDal.Add(entity);
            return new SuccessResult(Messages.SuccessMessages.DepoInserted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(DepoValidator))]
        [CacheRemoveAspect("IDepoService.Get")]
        public IResult Delete(Depo entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _depoDal.Delete(entity);
            return new SuccessResult(Messages.SuccessMessages.DepoDeleted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(DepoValidator))]
        [CacheRemoveAspect("IDepoService.Get")]
        public IResult Update(Depo entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _depoDal.Update(entity);
            return new SuccessResult(Messages.SuccessMessages.DepoUpdated);
        }
    }
}