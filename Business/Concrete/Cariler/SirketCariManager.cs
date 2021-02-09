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

namespace Business.Concrete
{
    public class SirketCariManager : CariManager<SirketCari>, ISirketCariService
    {
        private ICariDal<SirketCari> _sirketCariDal;
        public SirketCariManager(ICariDal<SirketCari> sirketCariDal, ICariGrupKodService cariGrupKodService, ICariGrupService cariGrupService)
                : base(sirketCariDal, cariGrupKodService, cariGrupService)
        {
            _sirketCariDal = sirketCariDal;
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
            return new SuccessResult(Messages.SuccessMessages.CariInserted);
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
            return new SuccessResult(Messages.SuccessMessages.CariDeleted);
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
            return new SuccessResult(Messages.SuccessMessages.CariUpdated);
        }
    }
}