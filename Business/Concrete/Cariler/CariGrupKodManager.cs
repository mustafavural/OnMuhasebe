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
    public class CariGrupKodManager : ICariGrupKodService
    {
        ICariGrupKodDal _cariGrupKodDal;
        ICariGrupService _cariGrupService;

        public CariGrupKodManager(ICariGrupKodDal cariGrupKodDal, ICariGrupService cariGrupService)
        {
            _cariGrupKodDal = cariGrupKodDal;
            _cariGrupService = cariGrupService;
        }
        #region BusinessRules
        private IResult CheckIfValidId(int cariGrupKodId)
        {
            var result = _cariGrupKodDal.Get(p => p.Id == cariGrupKodId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariGrupNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidAd(string cariGrupKodAd)
        {
            var result = _cariGrupKodDal.Get(p => p.Ad == cariGrupKodAd) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariGrupAdNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidTur(string cariGrupKodTur)
        {
            var result = _cariGrupKodDal.GetAll(p => p.Tur == cariGrupKodTur) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariGrupTurNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidCariId(int cariId)
        {
            var result = _cariGrupService.GetListByCariId(cariId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariGrupAssignmentNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidAdding(CariGrupKod cariGrupKod)
        {
            var result = _cariGrupKodDal.Get(p => p.Ad == cariGrupKod.Ad &&
                                               p.Tur == cariGrupKod.Tur) != null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariGrupAlreadyExists);
            }
            return new SuccessResult();
        }
        #endregion

        
        public IDataResult<CariGrupKod> GetById(int cariGrupKodId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(cariGrupKodId));
            if (result != null)
                return (IDataResult<CariGrupKod>)result;

            return new SuccessDataResult<CariGrupKod>(_cariGrupKodDal.Get(p => p.Id == cariGrupKodId));
        }

        
        public IDataResult<CariGrupKod> GetByAd(string cariGrupKodAd)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAd(cariGrupKodAd));
            if (result != null)
                return (IDataResult<CariGrupKod>)result;

            return new SuccessDataResult<CariGrupKod>(_cariGrupKodDal.Get(p => p.Ad == cariGrupKodAd));
        }

        
        public IDataResult<CariGrupKod> GetByTur(string cariGrupKodTur)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidTur(cariGrupKodTur));
            if (result != null)
                return (IDataResult<CariGrupKod>)result;

            return new SuccessDataResult<CariGrupKod>(_cariGrupKodDal.Get(p => p.Tur == cariGrupKodTur));
        }

        
        public IDataResult<List<CariGrupKod>> GetList()
        {
            return new SuccessDataResult<List<CariGrupKod>>(_cariGrupKodDal.GetAll());
        }

        
        public IDataResult<List<CariGrupKod>> GetListByCari(int cariId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidCariId(cariId));
            if (result != null)
                return (IDataResult<List<CariGrupKod>>)result;

            return new SuccessDataResult<List<CariGrupKod>>(_cariGrupKodDal.GetAll(p =>
            _cariGrupService.GetListByCariId(cariId).Data.Select(s => s.CariId).Contains(cariId)));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(CariGrupKodValidator))]
        [CacheRemoveAspect("ICariGrupKodService.Get")]
        public IResult Add(CariGrupKod cariGrupKod)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAdding(cariGrupKod));
            if (result != null)
                return result;

            _cariGrupKodDal.Add(cariGrupKod);
            return new SuccessResult(Messages.SuccessMessages.CariGrupInserted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(CariGrupKodValidator))]
        [CacheRemoveAspect("ICariGrupKodService.Get")]
        public IResult Delete(CariGrupKod cariGrupKod)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(cariGrupKod.Id));
            if (result != null)
                return result;

            _cariGrupKodDal.Delete(cariGrupKod);
            return new SuccessResult(Messages.SuccessMessages.CariGrupUpdated);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(CariGrupKodValidator))]
        [CacheRemoveAspect("ICariGrupKodService.Get")]
        public IResult Update(CariGrupKod cariGrupKod)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(cariGrupKod.Id));
            if (result != null)
                return result;

            _cariGrupKodDal.Update(cariGrupKod);
            return new SuccessResult(Messages.SuccessMessages.CariGrupDeleted);
        }
    }
}