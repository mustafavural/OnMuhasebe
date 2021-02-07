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
    public class CekManager<TEntity> : DegerliKagitManager<TEntity>, ICekService<TEntity>
        where TEntity : Cek, new()
    {
        IDegerliKagitDal<TEntity> _cekDal;

        public CekManager(IDegerliKagitDal<TEntity> cekDal) : base(cekDal)
        {
            _cekDal = cekDal;
        }

        #region BusinessRules
        private IResult CheckIfValidKod(string kod)
        {
            var result = _cekDal.Get(p => p.Kod == kod) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.DegerliKagitNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidBanka(int bankaId)
        {
            var result = _cekDal.Get(p => p.BankaId == bankaId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.BankaNotExists);
            }
            return new SuccessResult();
        }
        #endregion

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<TEntity> GetByKod(string kod)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidKod(kod));
            if (result != null)
                return (IDataResult<TEntity>)result;

            return new SuccessDataResult<TEntity>(_cekDal.Get(p => p.Kod == kod));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<TEntity>> GetByBankaId(int bankaId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidBanka(bankaId));
            if (result != null)
                return (IDataResult<List<TEntity>>)result;

            return new SuccessDataResult<List<TEntity>>(_cekDal.GetAll(p => p.BankaId == bankaId));
        }
    }
}
