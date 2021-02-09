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
    public class FaturaManager : EvrakManager<Fatura>, IFaturaService
    {
        IEvrakDal<Fatura> _faturaDal;

        public FaturaManager(IEvrakDal<Fatura> faturaDal, ICariHareketService cariHareketService, IPersonelHareketService personelHareketService, ICariService<Cari> cariService, IPersonelService personelService)
            : base(faturaDal, cariHareketService, personelHareketService, cariService, personelService)
        {
            _faturaDal = faturaDal;
        }

        #region BusinessRules
        private IResult CheckIfValidAdding(Fatura entity)
        {
            var result = _faturaDal.Get(p => p.FaturaNo == entity.FaturaNo) != null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.EvrakAlreadyExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidId(int Id)
        {
            var result = _faturaDal.Get(p => p.Id == Id) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.EvrakNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidNo(string faturaNo)
        {
            var result = _faturaDal.Get(p => p.FaturaNo == faturaNo) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.FaturaNoNotExists);
            }
            return new SuccessResult();
        }
        #endregion

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<Fatura> GetByNo(string faturaNo)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidNo(faturaNo));
            if (result != null)
                return (IDataResult<Fatura>)result;

            return new SuccessDataResult<Fatura>(_faturaDal.Get(p => p.FaturaNo == faturaNo));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(FaturaValidator))]
        [CacheRemoveAspect("IFaturaService.Get")]
        public IResult Add(Fatura entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAdding(entity));
            if (result != null)
                return result;

            _faturaDal.Add(entity);
            return new SuccessResult(Messages.SuccessMessages.EvrakInserted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(FaturaValidator))]
        [CacheRemoveAspect("IFaturaService.Get")]
        public IResult Delete(Fatura entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _faturaDal.Delete(entity);
            return new SuccessResult(Messages.SuccessMessages.EvrakDeleted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(FaturaValidator))]
        [CacheRemoveAspect("IFaturaService.Get")]
        public IResult Update(Fatura entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _faturaDal.Update(entity);
            return new SuccessResult(Messages.SuccessMessages.EvrakUpdated);
        }
    }
}