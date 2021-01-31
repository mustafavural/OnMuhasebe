using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation.Cariler;
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
    public class SahisCariManager : ISahisCariService
    {
        ISahisCariDal _sahisCariDal;
        ICariGrupService _cariGrupService;
        ICariGrupKodService _cariGrupKodService;
        public SahisCariManager(ISahisCariDal sahisCariDal, ICariGrupService cariGrupService, ICariGrupKodService cariGrupKodService)
        {
            _sahisCariDal = sahisCariDal;
            _cariGrupService = cariGrupService;
            _cariGrupKodService = cariGrupKodService;
        }

        #region BusinessRules
        private IResult CheckIfValidId(int cariId)
        {
            var result = _sahisCariDal.Get(p => p.CariId == cariId) == null;
            if (result)
            {
                return new ErrorResult(Messages.CariIdNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidKod(string cariKod)
        {
            var result = _sahisCariDal.Get(p => p.Kod == cariKod) == null;
            if (result)
            {
                return new ErrorResult(Messages.CariKodNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidTCNo(string TCNo)
        {
            var result = _sahisCariDal.Get(p => p.TCNo == TCNo) == null;
            if (result)
            {
                return new ErrorResult(Messages.SahisCariTCNoNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidUnvan(string cariUnvan)
        {
            var result = _sahisCariDal.Get(p => p.Unvan == cariUnvan) == null;
            if (result)
            {
                return new ErrorResult(Messages.CariUnvanNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfListValidGrupAd(string grupKodAd)
        {
            var result = _cariGrupKodService.GetByAd(grupKodAd) == null;
            if (result)
            {
                return new ErrorResult(Messages.CariGrupKodAdNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfListValidVergiDairesi(string vergiDairesi)
        {
            var result = _sahisCariDal.Get(p => p.VergiDairesi == vergiDairesi) == null;
            if (result)
            {
                return new ErrorResult(Messages.CariVergiDairesiNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidAdding(SahisCari cari)
        {
            var result = _sahisCariDal.Get(p => p.Kod == cari.Kod) != null;
            if (result)
            {
                return new ErrorResult(Messages.CariAlreadyExists);
            }
            return new SuccessResult();
        }
        #endregion

        [PerformanceAspect(1), CachAspect(), LogAspect()]
        public IDataResult<SahisCari> GetById(int cariId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(cariId));
            if (result != null)
                return (IDataResult<SahisCari>)result;

            return new SuccessDataResult<SahisCari>(_sahisCariDal.GetBy(p => p.CariId == cariId).SingleOrDefault());
        }

        [PerformanceAspect(1), CachAspect(), LogAspect()]
        public IDataResult<SahisCari> GetByKod(string cariKod)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidKod(cariKod));
            if (result != null)
                return (IDataResult<SahisCari>)result;

            return new SuccessDataResult<SahisCari>(_sahisCariDal.GetBy(p => p.Kod == cariKod).SingleOrDefault());
        }

        [PerformanceAspect(1), CachAspect(), LogAspect()]
        public IDataResult<SahisCari> GetByTCNo(string TCNo)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidTCNo(TCNo));
            if (result != null)
                return (IDataResult<SahisCari>)result;

            return new SuccessDataResult<SahisCari>(_sahisCariDal.GetBy(p => p.TCNo == TCNo).SingleOrDefault());
        }

        [PerformanceAspect(1), CachAspect(), LogAspect()]
        public IDataResult<SahisCari> GetByUnvan(string cariUnvan)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidUnvan(cariUnvan));
            if (result != null)
                return (IDataResult<SahisCari>)result;

            return new SuccessDataResult<SahisCari>(_sahisCariDal.GetBy(p => p.Unvan == cariUnvan).SingleOrDefault());
        }

        [PerformanceAspect(1), CachAspect(), LogAspect()]
        public IDataResult<List<SahisCari>> GetList()
        {
            return new SuccessDataResult<List<SahisCari>>(_sahisCariDal.GetBy());
        }

        [PerformanceAspect(1), CachAspect(), LogAspect()]
        public IDataResult<List<SahisCari>> GetListByGrupAd(string grupKodAd)
        {
            IResult result = BusinessRules.Run(
                CheckIfListValidGrupAd(grupKodAd));
            if (result != null)
                return (IDataResult<List<SahisCari>>)result;

            return new SuccessDataResult<List<SahisCari>>(_sahisCariDal.GetBy().Where(p =>
            _cariGrupService.GetListByCariGrupKodId(
                _cariGrupKodService.GetByAd(grupKodAd).Data.Id).Data.Select(s => s.Id).Contains(p.Id)).ToList());
        }

        [PerformanceAspect(1), CachAspect(), LogAspect()]
        public IDataResult<List<SahisCari>> GetListByVergiDairesi(string vergiDairesi)
        {
            IResult result = BusinessRules.Run(
                CheckIfListValidVergiDairesi(vergiDairesi));
            if (result != null)
                return (IDataResult<List<SahisCari>>)result;

            return new SuccessDataResult<List<SahisCari>>(_sahisCariDal.GetBy(p => p.VergiDairesi == vergiDairesi));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(CariValidator))]
        [ValidationAspect(typeof(SahisCariValidator))]
        [CacheRemoveAspect("ISahisCariService.Get")]
        public IResult Add(SahisCari cari)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAdding(cari));
            if (result != null)
                return result;

            _sahisCariDal.Add(cari);
            return new SuccessResult(Messages.SahisCariInserted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(CariValidator))]
        [ValidationAspect(typeof(SahisCariValidator))]
        [CacheRemoveAspect("ISahisCariService.Get")]
        public IResult Delete(SahisCari cari)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(cari.CariId));
            if (result != null)
                return result;

            _sahisCariDal.Delete(cari);
            return new SuccessResult(Messages.SahisCariDeleted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(CariValidator))]
        [ValidationAspect(typeof(SahisCariValidator))]
        [CacheRemoveAspect("ISahisCariService.Get")]
        public IResult Update(SahisCari cari)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(cari.CariId));
            if (result != null)
                return result;

            _sahisCariDal.Update(cari);
            return new SuccessResult(Messages.SahisCariUpdated);
        }
    }
}