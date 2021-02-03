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
    public class SirketCariManager : ISirketCariService
    {
        private ISirketCariDal _sirketCariDal;
        private ICariGrupService _cariGrupService;
        private ICariGrupKodService _cariGrupKodService;
        public SirketCariManager(ISirketCariDal sirketCariDal, ICariGrupKodService cariGrupKodService, ICariGrupService cariGrupService)
        {
            _sirketCariDal = sirketCariDal;
            _cariGrupService = cariGrupService;
            _cariGrupKodService = cariGrupKodService;
        }

        #region BusinessRules
        private IResult CheckIfValidAdding(SirketCari cari)
        {
            var result = _sirketCariDal.Get(p => p.Kod == cari.Kod) != null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariAlreadyExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidId(int cariId)
        {
            var result = _sirketCariDal.Get(p => p.Id == cariId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidKod(string cariKod)
        {
            var result = _sirketCariDal.Get(p => p.Kod == cariKod) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariKodNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidVergiNo(string VergiNo)
        {
            var result = _sirketCariDal.Get(p => p.VergiNo == VergiNo) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.SirketCariVergiNoNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidUnvan(string cariUnvan)
        {
            var result = _sirketCariDal.Get(p => p.Unvan == cariUnvan) == null;
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
            var result = _sirketCariDal.GetAll(p => p.VergiDairesi == vergiDairesi) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariVergiDairesiNotExists);
            }
            return new SuccessResult();
        }
        #endregion

        [PerformanceAspect(1), CacheAspect(), LogAspect()]
        public IDataResult<SirketCari> GetById(int cariId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(cariId));
            if (result != null)
                return (IDataResult<SirketCari>)result;

            return new SuccessDataResult<SirketCari>(_sirketCariDal.Get(p => p.Id == cariId));
        }

        [PerformanceAspect(1), CacheAspect(), LogAspect()]
        public IDataResult<SirketCari> GetByKod(string cariKod)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidKod(cariKod));
            if (result != null)
                return (IDataResult<SirketCari>)result;

            return new SuccessDataResult<SirketCari>(_sirketCariDal.Get(p => p.Kod == cariKod));
        }

        [PerformanceAspect(1), CacheAspect(), LogAspect()]
        public IDataResult<SirketCari> GetByUnvan(string cariUnvan)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidUnvan(cariUnvan));
            if (result != null)
                return (IDataResult<SirketCari>)result;

            return new SuccessDataResult<SirketCari>(_sirketCariDal.Get(p => p.Unvan == cariUnvan));
        }

        [PerformanceAspect(1), CacheAspect(), LogAspect()]
        public IDataResult<SirketCari> GetByVergiNo(string VergiNo)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidVergiNo(VergiNo));
            if (result != null)
                return (IDataResult<SirketCari>)result;

            return new SuccessDataResult<SirketCari>(_sirketCariDal.Get(p => p.VergiNo == VergiNo));
        }

        [PerformanceAspect(1), CacheAspect(), LogAspect()]
        public IDataResult<List<SirketCari>> GetList()
        {
            return new SuccessDataResult<List<SirketCari>>(_sirketCariDal.GetAll());
        }

        [PerformanceAspect(1), CacheAspect(), LogAspect()]
        public IDataResult<List<SirketCari>> GetListByVergiDairesi(string vergiDairesi)
        {
            IResult result = BusinessRules.Run(
                CheckIfListValidVergiDairesi(vergiDairesi));
            if (result != null)
                return (IDataResult<List<SirketCari>>)result;

            return new SuccessDataResult<List<SirketCari>>(_sirketCariDal.GetAll(p => p.VergiDairesi == vergiDairesi));
        }

        [PerformanceAspect(1), CacheAspect(), LogAspect()]
        public IDataResult<List<SirketCari>> GetListByGrupAd(string grupKodAd)
        {
            IResult result = BusinessRules.Run(
                CheckIfListValidGrupAd(grupKodAd));
            if (result != null)
                return (IDataResult<List<SirketCari>>)result;

            return new SuccessDataResult<List<SirketCari>>(_sirketCariDal.GetAll(p =>
            _cariGrupService.GetListByCariGrupKodId(
                _cariGrupKodService.GetByAd(grupKodAd).Data.Id).Data.Select(s => s.Id).Contains(p.Id)).ToList());
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(CariValidator))]
        [ValidationAspect(typeof(SirketCariValidator))]
        [CacheRemoveAspect("ISirketCariService.Get")]
        public IResult Add(SirketCari cari)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAdding(cari));
            if (result != null)
                return result;

            _sirketCariDal.Add(cari);
            return new SuccessResult(Messages.SuccessMessages.SirketCariInserted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(CariValidator))]
        [ValidationAspect(typeof(SirketCariValidator))]
        [CacheRemoveAspect("ISirketCariService.Get")]
        public IResult Delete(SirketCari cari)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(cari.Id));
            if (result != null)
                return result;

            _sirketCariDal.Delete(cari);
            return new SuccessResult(Messages.SuccessMessages.SirketCariDeleted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(CariValidator))]
        [ValidationAspect(typeof(SirketCariValidator))]
        [CacheRemoveAspect("ISirketCariService.Get")]
        public IResult Update(SirketCari cari)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(cari.Id));
            if (result != null)
                return result;

            _sirketCariDal.Update(cari);
            return new SuccessResult(Messages.SuccessMessages.SirketCariUpdated);
        }
    }
}