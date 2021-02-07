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
    public class CariGrupManager : ICariGrupService
    {
        ICariGrupDal _cariGrupDal;

        public CariGrupManager(ICariGrupDal cariGrupDal)
        {
            _cariGrupDal = cariGrupDal;
        }
        #region BusinessRules
        private IResult CheckIfValidId(int cariGrupId)
        {
            var result = _cariGrupDal.Get(p => p.Id == cariGrupId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariGrupAssignmentNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidCariGrupKodId(int cariGrupKodId)
        {
            var result = _cariGrupDal.GetAll(p => p.CariGrupKodId == cariGrupKodId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariGrupNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidCariId(int cariId)
        {
            var result = _cariGrupDal.GetAll(p => p.CariId == cariId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidAdding(CariGrup cariGrup)
        {
            var result = _cariGrupDal.Get(p => p.CariGrupKodId == cariGrup.CariGrupKodId &&
                                               p.CariId == cariGrup.CariId) != null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariGrupAssignmentAlreadyExists);
            }
            return new SuccessResult();
        }
        #endregion
        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<CariGrup> GetById(int cariGrupId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(cariGrupId));
            if (result != null)
                return (IDataResult<CariGrup>)result;

            return new SuccessDataResult<CariGrup>(_cariGrupDal.Get(p => p.Id == cariGrupId));
        }
        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<List<CariGrup>> GetListByCariGrupKodId(int cariGrupKodId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidCariGrupKodId(cariGrupKodId));
            if (result != null)
                return (IDataResult<List<CariGrup>>)result;

            return new SuccessDataResult<List<CariGrup>>(_cariGrupDal.GetAll(p => p.CariGrupKodId == cariGrupKodId));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<List<CariGrup>> GetByCariId(int cariId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidCariId(cariId));
            if (result != null)
                return (IDataResult<List<CariGrup>>)result;

            return new SuccessDataResult<List<CariGrup>>(_cariGrupDal.GetAll(p => p.CariId == cariId));
        }


        [PerformanceAspect(1)]
        [LogAspect()]
        [CacheAspect()]
        public IDataResult<List<CariGrup>> GetList()
        {
            return new SuccessDataResult<List<CariGrup>>(_cariGrupDal.GetAll());
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(CariGrupValidator))]
        [CacheRemoveAspect("ICariGrupService.Get")]
        public IResult Add(CariGrup cariGrup)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAdding(cariGrup));
            if (result != null)
                return result;

            _cariGrupDal.Add(cariGrup);
            return new SuccessResult(Messages.SuccessMessages.CariInsertedToGrup);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(CariGrupValidator))]
        [CacheRemoveAspect("ICariGrupService.Get")]
        public IResult Delete(CariGrup cariGrup)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(cariGrup.Id));
            if (result != null)
                return result;

            _cariGrupDal.Delete(cariGrup);
            return new SuccessResult(Messages.SuccessMessages.CariDeletedFromGrup);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(CariGrupValidator))]
        [CacheRemoveAspect("ICariGrupService.Get")]
        public IResult Update(CariGrup cariGrup)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(cariGrup.Id));
            if (result != null)
                return result;

            _cariGrupDal.Update(cariGrup);
            return new SuccessResult(Messages.SuccessMessages.CariTransferredToGrup);
        }
    }
}