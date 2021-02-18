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

namespace Business.Concrete
{
    public class BankaHesapManager : IBankaHesapService
    {
        IBankaHesapDal _bankaHesapDal;

        public BankaHesapManager(IBankaHesapDal bankaHesapDal)
        {
            _bankaHesapDal = bankaHesapDal;
        }

        #region BusinessRules
        private IResult CheckIfValidAdding(BankaHesap entity)
        {
            var result = _bankaHesapDal.Get(p => p.IBAN == entity.IBAN) != null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.BankaHesapAlreadyExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidId(int Id)
        {
            var result = _bankaHesapDal.Get(p => p.Id == Id) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.BankaHesapNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidAd(string ad)
        {
            var result = _bankaHesapDal.Get(p => p.Ad == ad) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.BankaHesapAdNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidIBAN(string iban)
        {
            var result = _bankaHesapDal.Get(p => p.IBAN == iban) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.BankaHesapIBANNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidNo(string no)
        {
            var result = _bankaHesapDal.Get(p => p.No == no) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.BankaHesapNoNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidMusteriYetkili(string musteriYetkili)
        {
            var result = _bankaHesapDal.Get(p => p.MusteriYetkili == musteriYetkili) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.BankaHesapMusteriYetkiliNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidSubeId(int subeId)
        {
            var result = _bankaHesapDal.Get(p => p.SubeId == subeId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.BankaSubeNotExists);
            }
            return new SuccessResult();
        }
        #endregion

        
        public IDataResult<BankaHesap> GetById(int Id)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(Id));
            if (result != null)
                return (IDataResult<BankaHesap>)result;

            return new SuccessDataResult<BankaHesap>(_bankaHesapDal.Get(p => p.Id == Id));
        }

        
        public IDataResult<BankaHesap> GetByAd(string ad)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAd(ad));
            if (result != null)
                return (IDataResult<BankaHesap>)result;

            return new SuccessDataResult<BankaHesap>(_bankaHesapDal.Get(p => p.Ad == ad));
        }

        
        public IDataResult<BankaHesap> GetByIBAN(string iban)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidIBAN(iban));
            if (result != null)
                return (IDataResult<BankaHesap>)result;

            return new SuccessDataResult<BankaHesap>(_bankaHesapDal.Get(p => p.IBAN == iban));
        }

        
        public IDataResult<BankaHesap> GetByNo(string no)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidNo(no));
            if (result != null)
                return (IDataResult<BankaHesap>)result;

            return new SuccessDataResult<BankaHesap>(_bankaHesapDal.Get(p => p.No == no));
        }

        
        public IDataResult<List<BankaHesap>> GetList()
        {
            return new SuccessDataResult<List<BankaHesap>>(_bankaHesapDal.GetAll());
        }

        
        public IDataResult<List<BankaHesap>> GetListByMusteriYetkili(string musteriYetkili)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidMusteriYetkili(musteriYetkili));
            if (result != null)
                return (IDataResult<List<BankaHesap>>)result;

            return new SuccessDataResult<List<BankaHesap>>(_bankaHesapDal.GetAll(p => p.MusteriYetkili == musteriYetkili));
        }

        
        public IDataResult<List<BankaHesap>> GetListBySubeId(int subeId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidSubeId(subeId));
            if (result != null)
                return (IDataResult<List<BankaHesap>>)result;

            return new SuccessDataResult<List<BankaHesap>>(_bankaHesapDal.GetAll(p => p.SubeId == subeId));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(BankaHesapValidator))]
        [CacheRemoveAspect("IBankaHesapService.Get")]
        public IResult Add(BankaHesap entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAdding(entity));
            if (result != null)
                return result;

            _bankaHesapDal.Add(entity);
            return new SuccessResult(Messages.SuccessMessages.BankaHesapInserted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(BankaHesapValidator))]
        [CacheRemoveAspect("IBankaHesapService.Get")]
        public IResult Delete(BankaHesap entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _bankaHesapDal.Delete(entity);
            return new SuccessResult(Messages.SuccessMessages.BankaHesapDeleted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(BankaHesapValidator))]
        [CacheRemoveAspect("IBankaHesapService.Get")]
        public IResult Update(BankaHesap entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _bankaHesapDal.Update(entity);
            return new SuccessResult(Messages.SuccessMessages.BankaHesapUpdated);
        }
    }
}