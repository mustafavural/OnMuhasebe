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
    public class MusteriSenetManager : SenetManager<MusteriSenet>, IMusteriSenetService
    {
        IDegerliKagitDal<MusteriSenet> _musteriSenetDal;

        public MusteriSenetManager(IDegerliKagitDal<MusteriSenet> musteriSenetDal)
            : base(musteriSenetDal)
        {
            _musteriSenetDal = musteriSenetDal;
        }

        #region BusinessRules
        private IResult CheckIfValidAdding(string kod)
        {
            var result = _musteriSenetDal.Get(p => p.Kod == kod) != null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.DegerliKagitAlreadyExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidId(int Id)
        {
            var result = _musteriSenetDal.Get(p => p.Id == Id) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.DegerliKagitNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidCariIdCiroEden(int cariIdCiroEden)
        {
            var result = _musteriSenetDal.Get(p => p.CariIdCiroEden == cariIdCiroEden) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidCariIdCiroEdilen(int cariIdCiroEdilen)
        {
            var result = _musteriSenetDal.Get(p => p.CariIdCiroEdilen == cariIdCiroEdilen) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidAlisTarih(DateTime tarih)
        {
            var result = _musteriSenetDal.Get(p => p.AlisTarihi == tarih) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.DegerliKagitDateNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidCikisTarih(DateTime tarih)
        {
            var result = _musteriSenetDal.Get(p => p.CikisTarihi == tarih) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.DegerliKagitDateNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidAsilBorclu(string asilBorclu)
        {
            var result = _musteriSenetDal.Get(p => p.AsilBorclu == asilBorclu) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.DegerliKagitAsilBorcluNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidHesapId(int hesapIdTahsileVerilen)
        {
            var result = _musteriSenetDal.Get(p => p.HesapIdTahsileVerilen == hesapIdTahsileVerilen) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.BankaHesapNotExists);
            }
            return new SuccessResult();
        }
        #endregion

        
        public IDataResult<List<MusteriSenet>> GetListByAlisTarihi(DateTime tarih)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAlisTarih(tarih));
            if (result != null)
                return (IDataResult<List<MusteriSenet>>)result;

            return new SuccessDataResult<List<MusteriSenet>>(_musteriSenetDal.GetAll(p => p.AlisTarihi == tarih));
        }

        
        public IDataResult<List<MusteriSenet>> GetListByAsilBorclu(string asilBorclu)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAsilBorclu(asilBorclu));
            if (result != null)
                return (IDataResult<List<MusteriSenet>>)result;

            return new SuccessDataResult<List<MusteriSenet>>(_musteriSenetDal.GetAll(p => p.AsilBorclu == asilBorclu));
        }

        
        public IDataResult<List<MusteriSenet>> GetListByCariIdCiroEden(int cariIdCiroEden)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidCariIdCiroEden(cariIdCiroEden));
            if (result != null)
                return (IDataResult<List<MusteriSenet>>)result;

            return new SuccessDataResult<List<MusteriSenet>>(_musteriSenetDal.GetAll(p => p.CariIdCiroEden == cariIdCiroEden));
        }

        
        public IDataResult<List<MusteriSenet>> GetListByCariIdCiroEdilen(int cariIdCiroEdilen)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidCariIdCiroEdilen(cariIdCiroEdilen));
            if (result != null)
                return (IDataResult<List<MusteriSenet>>)result;

            return new SuccessDataResult<List<MusteriSenet>>(_musteriSenetDal.GetAll(p => p.CariIdCiroEdilen == cariIdCiroEdilen));
        }

        
        public IDataResult<List<MusteriSenet>> GetListByCikisTarihi(DateTime tarih)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidCikisTarih(tarih));
            if (result != null)
                return (IDataResult<List<MusteriSenet>>)result;

            return new SuccessDataResult<List<MusteriSenet>>(_musteriSenetDal.GetAll(p => p.CikisTarihi == tarih));
        }

        
        public IDataResult<List<MusteriSenet>> GetListByHesapIdTahsileVerilen(int hesapIdTahsileVerilen)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidHesapId(hesapIdTahsileVerilen));
            if (result != null)
                return (IDataResult<List<MusteriSenet>>)result;

            return new SuccessDataResult<List<MusteriSenet>>(_musteriSenetDal.GetAll(p => p.HesapIdTahsileVerilen == hesapIdTahsileVerilen));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(MusteriSenetValidator))]
        [CacheRemoveAspect("IMusteriSenetService.Get")]
        public IResult Add(MusteriSenet entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAdding(entity.Kod));
            if (result != null)
                return result;

            _musteriSenetDal.Delete(entity);
            return new SuccessResult(Messages.SuccessMessages.DegerliKagitInserted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(MusteriSenetValidator))]
        [CacheRemoveAspect("IMusteriSenetService.Get")]
        public IResult Delete(MusteriSenet entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _musteriSenetDal.Delete(entity);
            return new SuccessResult(Messages.SuccessMessages.DegerliKagitDeleted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(MusteriSenetValidator))]
        [CacheRemoveAspect("IMusteriSenetService.Get")]
        public IResult Update(MusteriSenet entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _musteriSenetDal.Update(entity);
            return new SuccessResult(Messages.SuccessMessages.DegerliKagitUpdated);
        }
    }
}