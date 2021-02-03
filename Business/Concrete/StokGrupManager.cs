using Business.Abstract;
using Business.Constants;
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
    public class StokGrupManager : IStokGrupService
    {
        IStokGrupDal _stokGrupDal;

        public StokGrupManager(IStokGrupDal stokGrupDal)
        {
            _stokGrupDal = stokGrupDal;
        }

        #region BusinessRules
        private IResult CheckIfValidId(int stokGrupId)
        {
            var result = _stokGrupDal.Get(p => p.Id == stokGrupId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.StokGrupAssignmentNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidStokGrupKodId(int stokGrupKodId)
        {
            var result = _stokGrupDal.GetAll(p => p.StokGrupKodId == stokGrupKodId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.StokGrupKodNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidStokId(int stokId)
        {
            var result = _stokGrupDal.GetAll(p => p.StokId == stokId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.StokNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidAdding(StokGrup stokGrup)
        {
            var result = _stokGrupDal.Get(p => p.StokGrupKodId == stokGrup.StokGrupKodId &&
                                               p.StokId == stokGrup.StokId) != null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.StokGrupAssignmentAlreadyExists);
            }
            return new SuccessResult();
        }
        #endregion

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<StokGrup> GetById(int stokGrupId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(stokGrupId));
            if (result != null)
                return (IDataResult<StokGrup>)result;

            return new SuccessDataResult<StokGrup>(_stokGrupDal.Get(p =>
            p.Id == stokGrupId));
        }
        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<List<StokGrup>> GetByStokGrupKodId(int stokGrupKodId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidStokGrupKodId(stokGrupKodId));
            if (result != null)
                return (IDataResult<List<StokGrup>>)result;

            return new SuccessDataResult<List<StokGrup>>(_stokGrupDal.GetAll(p =>
            p.StokGrupKodId == stokGrupKodId));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<List<StokGrup>> GetByStokId(int stokId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidStokId(stokId));
            if (result != null)
                return (IDataResult<List<StokGrup>>)result;

            return new SuccessDataResult<List<StokGrup>>(_stokGrupDal.GetAll(p =>
            p.StokId == stokId));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<List<StokGrup>> GetList()
        {
            return new SuccessDataResult<List<StokGrup>>(_stokGrupDal.GetAll());
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(StokGrupValidator))]
        [CacheRemoveAspect("IStokGrupService.Get")]
        public IResult Add(StokGrup stokGrup)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAdding(stokGrup));
            if (result != null)
                return result;

            _stokGrupDal.Add(stokGrup);
            return new SuccessResult(Messages.SuccessMessages.StokAddedToGrup);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(StokGrupValidator))]
        [CacheRemoveAspect("IStokGrupService.Get")]
        public IResult Delete(StokGrup stokGrup)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(stokGrup.Id));
            if (result != null)
                return result;

            _stokGrupDal.Delete(stokGrup);
            return new SuccessResult(Messages.SuccessMessages.StokDeletedFromGrup);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(StokGrupValidator))]
        [CacheRemoveAspect("IStokGrupService.Get")]
        public IResult Update(StokGrup stokGrup)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(stokGrup.Id));
            if (result != null)
                return result;

            _stokGrupDal.Update(stokGrup);
            return new SuccessResult(Messages.SuccessMessages.StokTransferredToGrup);
        }
    }
}