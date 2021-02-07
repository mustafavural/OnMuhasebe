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

namespace Business.Concrete
{
    public class SahisCariManager : CariManager<SahisCari>, ISahisCariService
    {
        ICariDal<SahisCari> _sahisCariDal;
        public SahisCariManager(ICariDal<SahisCari> sahisCariDal, ICariGrupService cariGrupService, ICariGrupKodService cariGrupKodService)
                : base(sahisCariDal, cariGrupKodService, cariGrupService)
        {
            _sahisCariDal = sahisCariDal;
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
        private IResult CheckIfValidTCNo(string TCNo)
        {
            var result = _sahisCariDal.Get(p => p.TCNo == TCNo) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.SahisCariTCNoNotExists);
            }
            return new SuccessResult();
        }
        #endregion

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
            return new SuccessResult(Messages.SuccessMessages.CariInserted);
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
            return new SuccessResult(Messages.SuccessMessages.CariDeleted);
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
            return new SuccessResult(Messages.SuccessMessages.CariUpdated);
        }
    }
}