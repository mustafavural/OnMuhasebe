using Business.Abstract;
using Business.Constants;
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

namespace Business.Concrete
{
    public class BorcSenetManager : SenetManager<BorcSenet>, IBorcSenetService
    {
        IDegerliKagitDal<BorcSenet> _borcSenetDal;

        public BorcSenetManager(IDegerliKagitDal<BorcSenet> borcSenetDal)
            : base(borcSenetDal)
        {
            _borcSenetDal = borcSenetDal;
        }

        #region BusinessRules
        private IResult CheckIfValidAdding(string kod)
        {
            var result = _borcSenetDal.Get(p => p.Kod == kod) != null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.DegerliKagitAlreadyExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidId(int Id)
        {
            var result = _borcSenetDal.Get(p => p.Id == Id) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.DegerliKagitNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidCariId(int cariIdVerilen)
        {
            var result = _borcSenetDal.Get(p => p.CariIdVerilen == cariIdVerilen) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidTarih(DateTime tarih)
        {
            var result = _borcSenetDal.Get(p => p.CikisTarihi == tarih) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.DegerliKagitDateNotExists);
            }
            return new SuccessResult();
        }
        #endregion

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<BorcSenet>> GetListByCariIdVerilen(int cariIdVerilen)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidCariId(cariIdVerilen));
            if (result != null)
                return (IDataResult<List<BorcSenet>>)result;

            return new SuccessDataResult<List<BorcSenet>>(_borcSenetDal.GetAll(p => p.CariIdVerilen == cariIdVerilen));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<BorcSenet>> GetListByCikisTarihi(DateTime tarih)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidTarih(tarih));
            if (result != null)
                return (IDataResult<List<BorcSenet>>)result;

            return new SuccessDataResult<List<BorcSenet>>(_borcSenetDal.GetAll(p => p.CikisTarihi == tarih));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(BorcSenetValidator))]
        [CacheRemoveAspect("IBorcSenetService.Get")]
        public IResult Add(BorcSenet entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAdding(entity.Kod));
            if (result != null)
                return result;

            _borcSenetDal.Add(entity);
            return new SuccessResult(Messages.SuccessMessages.DegerliKagitInserted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(BorcSenetValidator))]
        [CacheRemoveAspect("IBorcSenetService.Get")]
        public IResult Delete(BorcSenet entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _borcSenetDal.Delete(entity);
            return new SuccessResult(Messages.SuccessMessages.DegerliKagitDeleted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(BorcSenetValidator))]
        [CacheRemoveAspect("IBorcSenetService.Get")]
        public IResult Update(BorcSenet entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _borcSenetDal.Update(entity);
            return new SuccessResult(Messages.SuccessMessages.DegerliKagitUpdated);
        }
    }
}
