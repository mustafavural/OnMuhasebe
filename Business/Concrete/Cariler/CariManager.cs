using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Performance;
using Core.Utilities.Business;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class CariManager<TEntity> : ICariService<TEntity>
        where TEntity : Cari, new()
    {
        private ICariDal<TEntity> _cariDal;
        private ICariGrupService _cariGrupService;
        private ICariGrupKodService _cariGrupKodService;

        public CariManager(ICariDal<TEntity> cariDal, ICariGrupKodService cariGrupKodService, ICariGrupService cariGrupService)
        {
            _cariDal = cariDal;
            _cariGrupService = cariGrupService;
            _cariGrupKodService = cariGrupKodService;
        }

        #region BusinessRules
        private IResult CheckIfValidId(int cariId)
        {
            var result = _cariDal.Get(p => p.Id == cariId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidKod(string cariKod)
        {
            var result = _cariDal.Get(p => p.Kod == cariKod) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariKodNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidUnvan(string cariUnvan)
        {
            var result = _cariDal.Get(p => p.Unvan == cariUnvan) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariUnvanNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfListValidVergiDairesi(string vergiDairesi)
        {
            var result = _cariDal.GetAll(p => p.VergiDairesi == vergiDairesi) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariVergiDairesiNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfListValidGrupAd(string grupKodAd)
        {
            var result = _cariGrupKodService.GetByAd(grupKodAd) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariGrupAdNotExists);
            }
            return new SuccessResult();
        }
        #endregion

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<TEntity> GetById(int cariId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(cariId));
            if (result != null)
                return (IDataResult<TEntity>)result;

            return new SuccessDataResult<TEntity>(_cariDal.Get(p => p.Id == cariId));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<TEntity> GetByKod(string cariKod)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidKod(cariKod));
            if (result != null)
                return (IDataResult<TEntity>)result;

            return new SuccessDataResult<TEntity>(_cariDal.Get(p => p.Kod == cariKod));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<TEntity> GetByUnvan(string cariUnvan)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidUnvan(cariUnvan));
            if (result != null)
                return (IDataResult<TEntity>)result;

            return new SuccessDataResult<TEntity>(_cariDal.Get(p => p.Unvan == cariUnvan));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<TEntity>> GetListByVergiDairesi(string vergiDairesi)
        {
            IResult result = BusinessRules.Run(
                CheckIfListValidVergiDairesi(vergiDairesi));
            if (result != null)
                return (IDataResult<List<TEntity>>)result;

            return new SuccessDataResult<List<TEntity>>(_cariDal.GetAll(p => p.VergiDairesi == vergiDairesi));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<TEntity>> GetListByGrupAd(string grupKodAd)
        {
            IResult result = BusinessRules.Run(
                CheckIfListValidGrupAd(grupKodAd));
            if (result != null)
                return (IDataResult<List<TEntity>>)result;

            return new SuccessDataResult<List<TEntity>>(_cariDal.GetAll(p =>
            _cariGrupService.GetListByCariGrupKodId(
                _cariGrupKodService.GetByAd(grupKodAd).Data.Id).Data.Select(s => s.Id).Contains(p.Id)).ToList());
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<TEntity>> GetList()
        {
            return new SuccessDataResult<List<TEntity>>(_cariDal.GetAll());
        }
    }
}