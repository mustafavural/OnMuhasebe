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

namespace Business.Concrete
{
    public class CariManager<TEntity> : ICariService<TEntity>
        where TEntity : Cari, new()
    {
        ICariDal<TEntity> _cariDal;

        public CariManager(ICariDal<TEntity> cariDal)
        {
            _cariDal = cariDal;
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
        public IDataResult<List<TEntity>> GetList()
        {
            return new SuccessDataResult<List<TEntity>>(_cariDal.GetAll());
        }
    }
}