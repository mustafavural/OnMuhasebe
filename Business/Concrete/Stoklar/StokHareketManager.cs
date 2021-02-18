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
    public class StokHareketManager : IStokHareketService
    {
        IStokHareketDal _stokHareketDal;
        IStokService _stokService;

        public StokHareketManager(IStokHareketDal stokHareketDal, IStokService stokService)
        {
            _stokHareketDal = stokHareketDal;
            _stokService = stokService;
        }

        #region BusinessRules
        private IResult CheckIfValidAdding(StokHareket stokHareket)
        {
            var stok = _stokService.GetById(stokHareket.StokId);

            var error = stokHareket.CikanMiktar == 0 ? false : GetStokMiktar(stok.Data.Id).Data < stokHareket.CikanMiktar;
            if (error)
            {
                return new ErrorResult(Messages.ErrorMessages.StokAmountNotEnough);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidStokId(int stokId)
        {
            var error = _stokService.GetById(stokId) == null;
            if (error)
            {
                return new ErrorResult(Messages.ErrorMessages.StokNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidId(int stokHareketId)
        {
            var error = _stokHareketDal.Get(p => p.Id == stokHareketId) == null;
            if (error)
            {
                return new ErrorResult(Messages.ErrorMessages.StokHareketNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidDepoId(int depoId)
        {
            var error = _stokHareketDal.Get(p => p.DepoId == depoId) == null;
            if (error)
            {
                return new ErrorResult(Messages.ErrorMessages.DepoNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidEvrakId(int evrakId)
        {
            var error = _stokHareketDal.Get(p => p.EvrakId == evrakId) == null;
            if (error)
            {
                return new ErrorResult(Messages.ErrorMessages.EvrakNotExists);
            }
            return new SuccessResult();
        }
        #endregion

        
        public IDataResult<StokHareket> GetById(int stokHareketId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(stokHareketId));
            if (result != null)
                return (IDataResult<StokHareket>)result;

            return new SuccessDataResult<StokHareket>(_stokHareketDal.Get(p => p.Id == stokHareketId));
        }

        
        public IDataResult<List<StokHareket>> GetByDepoId(int depoId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidDepoId(depoId));
            if (result != null)
                return (IDataResult<List<StokHareket>>)result;

            return new SuccessDataResult<List<StokHareket>>(_stokHareketDal.GetAll(p => p.DepoId == depoId));
        }

        
        public IDataResult<List<StokHareket>> GetByEvrakId(int evrakId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidEvrakId(evrakId));
            if (result != null)
                return (IDataResult<List<StokHareket>>)result;

            return new SuccessDataResult<List<StokHareket>>(_stokHareketDal.GetAll(p => p.EvrakId == evrakId));
        }

        
        public IDataResult<List<StokHareket>> GetByStokId(int stokId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidStokId(stokId));
            if (result != null)
                return (IDataResult<List<StokHareket>>)result;

            return new SuccessDataResult<List<StokHareket>>(_stokHareketDal.GetAll(p => p.StokId == stokId));
        }

        
        public IDataResult<List<StokHareket>> GetList()
        {
            return new SuccessDataResult<List<StokHareket>>(_stokHareketDal.GetAll());
        }

        
        public IDataResult<decimal> GetStokMiktar(int stokId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidStokId(stokId));
            if (result != null)
                return (IDataResult<decimal>)result;

            var miktar = _stokHareketDal.GetAll(p => p.StokId == stokId)
                .Select(miktar => miktar.GirenMiktar - miktar.CikanMiktar).Sum();
            return new SuccessDataResult<decimal>(miktar);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(StokHareketValidator))]
        [CacheRemoveAspect("IStokHareketService.Get")]
        public IResult Add(StokHareket stokHareket)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAdding(stokHareket));
            if (result != null)
                return result;

            _stokHareketDal.Add(stokHareket);
            return new SuccessResult(Messages.SuccessMessages.StockActivityInserted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(StokHareketValidator))]
        [CacheRemoveAspect("IStokHareketService.Get")]
        public IResult Delete(StokHareket stokHareket)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(stokHareket.Id));
            if (result != null)
                return result;

            _stokHareketDal.Delete(stokHareket);
            return new SuccessResult(Messages.SuccessMessages.StockActivityDeleted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(StokHareketValidator))]
        [CacheRemoveAspect("IStokHareketService.Get")]
        public IResult Update(StokHareket stokHareket)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(stokHareket.Id));
            if (result != null)
                return result;

            _stokHareketDal.Update(stokHareket);
            return new SuccessResult(Messages.SuccessMessages.StockActivityUpdated);
        }
    }
}