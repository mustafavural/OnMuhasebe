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
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class BorcCekManager : CekManager<BorcCek>, IBorcCekService
    {
        IDegerliKagitDal<BorcCek> _borcCekDal;

        public BorcCekManager(IDegerliKagitDal<BorcCek> borcCekDal)
            : base(borcCekDal)
        {
            _borcCekDal = borcCekDal;
        }

        #region BusinessRules
        private IResult CheckIfValidAdding(string kod)
        {
            var result = _borcCekDal.Get(p => p.Kod == kod) != null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.DegerliKagitAlreadyExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidId(int Id)
        {
            var result = _borcCekDal.Get(p => p.Id == Id) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.DegerliKagitNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidCariId(int cariIdVerilen)
        {
            var result = _borcCekDal.Get(p => p.CariIdVerilen == cariIdVerilen) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidTarih(DateTime tarih)
        {
            var result = _borcCekDal.Get(p => p.CikisTarihi == tarih) == null;
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
        public IDataResult<List<BorcCek>> GetListByCariIdVerilen(int cariIdVerilen)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidCariId(cariIdVerilen));
            if (result != null)
                return (IDataResult<List<BorcCek>>)result;

            return new SuccessDataResult<List<BorcCek>>(_borcCekDal.GetAll(p => p.CariIdVerilen == cariIdVerilen));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<BorcCek>> GetListByCikisTarihi(DateTime tarih)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidTarih(tarih));
            if (result != null)
                return (IDataResult<List<BorcCek>>)result;

            return new SuccessDataResult<List<BorcCek>>(_borcCekDal.GetAll(p => p.CikisTarihi == tarih));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<BorcCek>> GetListByHesapId(int hesapId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(hesapId));
            if (result != null)
                return (IDataResult<List<BorcCek>>)result;

            return new SuccessDataResult<List<BorcCek>>(_borcCekDal.GetAll(p => p.HesapId == hesapId));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(BorcCekValidator))]
        [CacheRemoveAspect("IBorcCekService.Get")]
        public IResult Add(BorcCek entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAdding(entity.Kod));
            if (result != null)
                return result;

            _borcCekDal.Add(entity);
            return new SuccessResult(Messages.SuccessMessages.DegerliKagitInserted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(BorcCekValidator))]
        [CacheRemoveAspect("IBorcCekService.Get")]
        public IResult Delete(BorcCek entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _borcCekDal.Delete(entity);
            return new SuccessResult(Messages.SuccessMessages.DegerliKagitDeleted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(BorcCekValidator))]
        [CacheRemoveAspect("IBorcCekService.Get")]
        public IResult Update(BorcCek entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _borcCekDal.Update(entity);
            return new SuccessResult(Messages.SuccessMessages.DegerliKagitUpdated);
        }
    }
}
