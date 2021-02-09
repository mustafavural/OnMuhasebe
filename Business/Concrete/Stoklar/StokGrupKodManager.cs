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
using System.Linq;

namespace Business.Concrete
{
    public class StokGrupKodManager : IStokGrupKodService
    {
        IStokGrupKodDal _stokGrupKodDal;
        IStokGrupService _stokGrupService;

        public StokGrupKodManager(IStokGrupKodDal stokGrupKodDal, IStokGrupService stokGrupService)
        {
            _stokGrupKodDal = stokGrupKodDal;
            _stokGrupService = stokGrupService;
        }

        #region BusinessRules
        private IResult CheckIfValidAdding(StokGrupKod stokGrupKod)
        {
            var result = _stokGrupKodDal.Get(p => p.Ad == stokGrupKod.Ad &&
                                               p.Tur == stokGrupKod.Tur) != null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.StokGrupAlreadyExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidId(int stokGrupKodId)
        {
            var result = _stokGrupKodDal.Get(p => p.Id == stokGrupKodId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.StokGrupNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidAd(string stokGrupKodAd)
        {
            var result = _stokGrupKodDal.Get(p => p.Ad == stokGrupKodAd) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.StokGrupAdNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidTur(string stokGrupKodTur)
        {
            var result = _stokGrupKodDal.GetAll(p => p.Tur == stokGrupKodTur) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.StokGrupTurNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidStokId(int stokId)
        {
            var result = _stokGrupService.GetByStokId(stokId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.StokGrupAssignmentNotExists);
            }
            return new SuccessResult();
        }
        #endregion

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<StokGrupKod> GetById(int stokGrupKodId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(stokGrupKodId));
            if (result != null)
                return (IDataResult<StokGrupKod>)result;

            return new SuccessDataResult<StokGrupKod>(_stokGrupKodDal.Get(p => p.Id == stokGrupKodId));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<StokGrupKod> GetByAd(string stokGrupKodAd)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAd(stokGrupKodAd));
            if (result != null)
                return (IDataResult<StokGrupKod>)result;

            return new SuccessDataResult<StokGrupKod>(_stokGrupKodDal.Get(p => p.Ad == stokGrupKodAd));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<List<StokGrupKod>> GetList()
        {
            return new SuccessDataResult<List<StokGrupKod>>(_stokGrupKodDal.GetAll());
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<List<StokGrupKod>> GetListByTur(string stokGrupKodTur)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidTur(stokGrupKodTur));
            if (result != null)
                return (IDataResult<List<StokGrupKod>>)result;

            return new SuccessDataResult<List<StokGrupKod>>(_stokGrupKodDal.GetAll(p => p.Tur == stokGrupKodTur));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<List<StokGrupKod>> GetListByStok(int stokId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidStokId(stokId));
            if (result != null)
                return (IDataResult<List<StokGrupKod>>)result;

            return new SuccessDataResult<List<StokGrupKod>>(_stokGrupKodDal.GetAll(p =>
            p.Id == _stokGrupService.GetByStokId(stokId).Data.Select(s => s.StokGrupKodId).Single()));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(StokGrupKodValidator))]
        [CacheRemoveAspect("IStokGrupKodService.Get")]
        public IResult Add(StokGrupKod stokGrupKod)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAdding(stokGrupKod));
            if (result != null)
                return result;

            _stokGrupKodDal.Add(stokGrupKod);
            return new SuccessResult(Messages.SuccessMessages.StokGrupInserted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(StokGrupKodValidator))]
        [CacheRemoveAspect("IStokGrupKodService.Get")]
        public IResult Delete(StokGrupKod stokGrupKod)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(stokGrupKod.Id));
            if (result != null)
                return result;

            _stokGrupKodDal.Delete(stokGrupKod);
            return new SuccessResult(Messages.SuccessMessages.StokGrupDeleted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(StokGrupKodValidator))]
        [CacheRemoveAspect("IStokGrupKodService.Get")]
        public IResult Update(StokGrupKod stokGrupKod)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(stokGrupKod.Id));
            if (result != null)
                return result;

            _stokGrupKodDal.Update(stokGrupKod);
            return new SuccessResult(Messages.SuccessMessages.StokGrupUpdated);
        }
    }
}