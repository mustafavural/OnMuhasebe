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
    public class IrsaliyeManager : EvrakManager<Irsaliye>, IIrsaliyeService
    {
        IEvrakDal<Irsaliye> _irsaliyeDal;
        public IrsaliyeManager(IEvrakDal<Irsaliye> irsaliyeDal, ICariHareketService cariHareketService, IPersonelHareketService personelHareketService, ICariService<Cari> cariService, IPersonelService personelService)
            : base(irsaliyeDal, cariHareketService, personelHareketService, cariService, personelService)
        {
            _irsaliyeDal = irsaliyeDal;
        }

        #region BusinessRules
        private IResult CheckIfValidAdding(Irsaliye entity)
        {
            var result = _irsaliyeDal.Get(p => p.IrsaliyeNo == entity.IrsaliyeNo) != null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.EvrakAlreadyExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidId(int Id)
        {
            var result = _irsaliyeDal.Get(p => p.Id == Id) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.EvrakNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidNo(string irsaliyeNo)
        {
            var result = _irsaliyeDal.Get(p => p.IrsaliyeNo == irsaliyeNo) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.IrsaliyeNoNotExists);
            }
            return new SuccessResult();
        }
        #endregion

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<Irsaliye> GetByNo(string irsaliyeNo)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidNo(irsaliyeNo));
            if (result != null)
                return (IDataResult<Irsaliye>)result;

            return new SuccessDataResult<Irsaliye>(_irsaliyeDal.Get(p => p.IrsaliyeNo == irsaliyeNo));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(IrsaliyeValidator))]
        [CacheRemoveAspect("IIrsaliyeService.Get")]
        public IResult Add(Irsaliye entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAdding(entity));
            if (result != null)
                return result;

            _irsaliyeDal.Add(entity);
            return new SuccessResult(Messages.SuccessMessages.EvrakInserted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(IrsaliyeValidator))]
        [CacheRemoveAspect("IIrsaliyeService.Get")]
        public IResult Delete(Irsaliye entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _irsaliyeDal.Delete(entity);
            return new SuccessResult(Messages.SuccessMessages.EvrakDeleted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(IrsaliyeValidator))]
        [CacheRemoveAspect("IIrsaliyeService.Get")]
        public IResult Update(Irsaliye entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _irsaliyeDal.Update(entity);
            return new SuccessResult(Messages.SuccessMessages.EvrakUpdated);
        }
    }
}