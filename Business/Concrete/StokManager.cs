using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation.Stoklar;
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
    public class StokManager : IStokService
    {
        IStokDal _stokDal;
        IStokGrupService _stokGrupService;
        IStokGrupKodService _stokGrupKodService;

        public StokManager(IStokDal stokDal, IStokGrupService stokGrupService, IStokGrupKodService stokGrupKodService)
        {
            _stokDal = stokDal;
            _stokGrupService = stokGrupService;
            _stokGrupKodService = stokGrupKodService;
        }

        #region BusinessRules
        private IResult CheckIfValidAdding(Stok stok)
        {
            var result = _stokDal.Get(p => p.Kod == stok.Kod) != null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.StokAlreadyExists);
            }
            return new SuccessResult();
        }
        private IDataResult<Stok> CheckIfValidId(int id)
        {
            var result = _stokDal.Get(p => p.Id == id) == null;
            if (result)
            {
                return new ErrorDataResult<Stok>(Messages.ErrorMessages.StokIdNotExists);
            }
            return new SuccessDataResult<Stok>();
        }
        private IDataResult<Stok> CheckIfValidKod(string kod)
        {
            var result = _stokDal.Get(p => p.Kod == kod) == null;
            if (result)
            {
                return new ErrorDataResult<Stok>(Messages.ErrorMessages.StokKodNotExists);
            }
            return new SuccessDataResult<Stok>();
        }
        private IDataResult<Stok> CheckIfValidBarkod(string barkod)
        {
            var result = _stokDal.Get(p => p.Barkod == barkod) == null;
            if (result)
            {
                return new ErrorDataResult<Stok>(Messages.ErrorMessages.StokBarkodNotExists);
            }
            return new SuccessDataResult<Stok>();
        }
        private IDataResult<Stok> CheckIfValidAd(string ad)
        {
            var result = _stokDal.Get(p => p.Ad == ad) == null;
            if (result)
            {
                return new ErrorDataResult<Stok>(Messages.ErrorMessages.StokAdNotExists);
            }
            return new SuccessDataResult<Stok>();
        }
        private IDataResult<List<Stok>> CheckIfListValidGrupKodAd(string grupKodAd)
        {
            var result = _stokGrupKodService.GetByAd(grupKodAd) == null;
            if (result)
            {
                return new ErrorDataResult<List<Stok>>(Messages.ErrorMessages.StokGrupKodAdNotExists);
            }
            return new SuccessDataResult<List<Stok>>();
        }
        private IDataResult<List<Stok>> CheckIfListValidKDV(int kdv)
        {
            var result = _stokDal.GetAll(p => p.KDV == kdv) == null;
            if (result)
            {
                return new ErrorDataResult<List<Stok>>(Messages.ErrorMessages.StokKdvNotExists);
            }
            return new SuccessDataResult<List<Stok>>();
        }
        private IDataResult<List<Stok>> CheckIfListValidGrupKodId(int grupKodId)
        {
            var result = _stokGrupKodService.GetById(grupKodId) == null;
            if (result)
            {
                return new ErrorDataResult<List<Stok>>(Messages.ErrorMessages.StokGrupKodIdNotExists);
            }
            return new SuccessDataResult<List<Stok>>();
        }
        #endregion

        [PerformanceAspect(1), CacheAspect(), LogAspect()]
        public IDataResult<Stok> GetById(int stokId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(stokId));
            if (result != null)
                return (IDataResult<Stok>)result;

            return new SuccessDataResult<Stok>(_stokDal.Get(p => p.Id == stokId));
        }

        [PerformanceAspect(1), CacheAspect(), LogAspect()]
        public IDataResult<Stok> GetByKod(string stokKod)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidKod(stokKod));
            if (result != null)
                return (IDataResult<Stok>)result;

            return new SuccessDataResult<Stok>(_stokDal.Get(p => p.Kod == stokKod));
        }

        [PerformanceAspect(1), CacheAspect(), LogAspect()]
        public IDataResult<Stok> GetByBarkod(string stokBarkod)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidBarkod(stokBarkod));
            if (result != null)
                return (IDataResult<Stok>)result;

            return new SuccessDataResult<Stok>(_stokDal.Get(p => p.Barkod == stokBarkod));
        }

        [PerformanceAspect(1), CacheAspect(), LogAspect()]
        public IDataResult<Stok> GetByAd(string stokAd)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAd(stokAd));
            if (result != null)
                return (IDataResult<Stok>)result;

            return new SuccessDataResult<Stok>(_stokDal.Get(p => p.Ad == stokAd));
        }

        [PerformanceAspect(1), CacheAspect(), LogAspect()]
        public IDataResult<List<Stok>> GetList()
        {
            return new SuccessDataResult<List<Stok>>(_stokDal.GetAll());
        }

        [PerformanceAspect(1), CacheAspect(), LogAspect()]
        public IDataResult<List<Stok>> GetListByKDV(int KDV)
        {
            IResult result = BusinessRules.Run(
                CheckIfListValidKDV(KDV));
            if (result != null)
                return (IDataResult<List<Stok>>)result;

            return new SuccessDataResult<List<Stok>>(_stokDal.GetAll(p => p.KDV == KDV));
        }

        [PerformanceAspect(1), CacheAspect(), LogAspect()]
        public IDataResult<List<Stok>> GetListByGrupAd(string grupKodAd)
        {
            IResult result = BusinessRules.Run(
                CheckIfListValidGrupKodAd(grupKodAd));
            if (result != null)
                return (IDataResult<List<Stok>>)result;

            return new SuccessDataResult<List<Stok>>(_stokDal.GetAll(p =>
            _stokGrupService.GetByStokGrupKodId(
                _stokGrupKodService.GetByAd(grupKodAd).Data.Id).Data.Select(s => s.StokId).Contains(p.Id)));
        }

        [PerformanceAspect(1), CacheAspect(), LogAspect()]
        public IDataResult<List<Stok>> GetListByGrupKod(int grupKodId)
        {
            IResult result = BusinessRules.Run(
                CheckIfListValidGrupKodId(grupKodId));
            if (result != null)
                return (IDataResult<List<Stok>>)result;

            return new SuccessDataResult<List<Stok>>(_stokDal.GetAll(p =>
            _stokGrupService.GetByStokGrupKodId(grupKodId).Data.Select(s => s.StokId).Contains(p.Id)));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(StokValidator))]
        [CacheRemoveAspect("IStokService.Get")]
        public IResult Add(Stok stok)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAdding(stok));
            if (result != null)
                return result;

            _stokDal.Add(stok);
            return new SuccessResult(Messages.SuccessMessages.StokInserted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(StokValidator))]
        [CacheRemoveAspect("IStokService.Get")]
        public IResult Delete(Stok stok)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(stok.Id));
            if (result != null)
                return result;

            _stokDal.Delete(stok);
            return new SuccessResult(Messages.SuccessMessages.StokDeleted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(StokValidator))]
        [CacheRemoveAspect("IStokService.Get")]
        public IResult Update(Stok stok)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(stok.Id));
            if (result != null)
                return result;

            _stokDal.Update(stok);
            return new SuccessResult(Messages.SuccessMessages.StokUpdated);
        }
    }
}