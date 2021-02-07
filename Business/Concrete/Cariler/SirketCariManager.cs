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
    public class SirketCariManager : CariManager<SirketCari>, ISirketCariService
    {
        private ICariDal<SirketCari> _sirketCariDal;
        private ICariGrupService _cariGrupService;
        private ICariGrupKodService _cariGrupKodService;
        public SirketCariManager(ICariDal<SirketCari> sirketCariDal, ICariGrupKodService cariGrupKodService, ICariGrupService cariGrupService)
                : base(sirketCariDal)
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
        private IResult CheckIfValidVergiNo(string VergiNo)
        {
            var result = _sirketCariDal.Get(p => p.VergiNo == VergiNo) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.SirketCariVergiNoNotExists);
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
        #endregion

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