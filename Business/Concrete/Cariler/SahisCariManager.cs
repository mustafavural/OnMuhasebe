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
        private IResult CheckIfValidAdding(SahisCari cari)
        {
            var result = _sahisCariDal.Get(p => p.Kod == cari.Kod) != null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariAlreadyExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidId(int cariId)
        {
            var result = _sahisCariDal.Get(p => p.Id == cariId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidKod(string cariKod)
        {
            var result = _sahisCariDal.Get(p => p.Kod == cariKod) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariKodNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidTCNo(string TCNo)
        {
            var result = _sahisCariDal.Get(p => p.TCNo == TCNo) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.SahisCariTCNoNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidUnvan(string cariUnvan)
        {
            var result = _sahisCariDal.Get(p => p.Unvan == cariUnvan) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariUnvanNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfListValidGrupAd(string grupKodAd)
        {
            var result = _cariGrupKodService.GetByAd(grupKodAd) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariGrupKodAdNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfListValidVergiDairesi(string vergiDairesi)
        {
            var result = _sahisCariDal.GetAll(p => p.VergiDairesi == vergiDairesi) == null;
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
        public IDataResult<SahisCari> GetById(int cariId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(cariId));
            if (result != null)
                return (IDataResult<SahisCari>)result;

            return new SuccessDataResult<SahisCari>(_sahisCariDal.Get(p => p.Id == cariId));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<SahisCari> GetByKod(string cariKod)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidKod(cariKod));
            if (result != null)
                return (IDataResult<SahisCari>)result;

            return new SuccessDataResult<SahisCari>(_sahisCariDal.Get(p => p.Kod == cariKod));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<SahisCari> GetByTCNo(string TCNo)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidTCNo(TCNo));
            if (result != null)
                return (IDataResult<SahisCari>)result;

            return new SuccessDataResult<SahisCari>(_sahisCariDal.Get(p => p.TCNo == TCNo));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<SahisCari> GetByUnvan(string cariUnvan)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidUnvan(cariUnvan));
            if (result != null)
                return (IDataResult<SahisCari>)result;

            return new SuccessDataResult<SahisCari>(_sahisCariDal.Get(p => p.Unvan == cariUnvan));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<SahisCari>> GetList()
        {
            return new SuccessDataResult<List<SahisCari>>(_sahisCariDal.GetAll());
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<SahisCari>> GetListByGrupAd(string grupKodAd)
        {
            IResult result = BusinessRules.Run(
                CheckIfListValidGrupAd(grupKodAd));
            if (result != null)
                return (IDataResult<List<SahisCari>>)result;

            return new SuccessDataResult<List<SahisCari>>(_sahisCariDal.GetAll(p =>
            _cariGrupService.GetListByCariGrupKodId(
                _cariGrupKodService.GetByAd(grupKodAd).Data.Id).Data.Select(s => s.Id).Contains(p.Id)).ToList());
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<SahisCari>> GetListByVergiDairesi(string vergiDairesi)
        {
            IResult result = BusinessRules.Run(
                CheckIfListValidVergiDairesi(vergiDairesi));
            if (result != null)
                return (IDataResult<List<SahisCari>>)result;

            return new SuccessDataResult<List<SahisCari>>(_sahisCariDal.GetAll(p => p.VergiDairesi == vergiDairesi));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(SahisCariValidator))]
        [CacheRemoveAspect("ISahisCariService.Get")]
        public IResult Add(SahisCari cari)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAdding(cari));
            if (result != null)
                return result;

            _sahisCariDal.Add(cari);
            return new SuccessResult(Messages.SuccessMessages.SahisCariInserted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(SahisCariValidator))]
        [CacheRemoveAspect("ISahisCariService.Get")]
        public IResult Delete(SahisCari cari)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(cari.Id));
            if (result != null)
                return result;

            _sahisCariDal.Delete(cari);
            return new SuccessResult(Messages.SuccessMessages.SahisCariDeleted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(SahisCariValidator))]
        [CacheRemoveAspect("ISahisCariService.Get")]
        public IResult Update(SahisCari cari)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(cari.Id));
            if (result != null)
                return result;

            _sahisCariDal.Update(cari);
            return new SuccessResult(Messages.SuccessMessages.SahisCariUpdated);
        }
    }
}