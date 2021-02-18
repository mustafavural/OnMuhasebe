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
    public class MusteriCekManager : CekManager<MusteriCek>, IMusteriCekService
    {
        IDegerliKagitDal<MusteriCek> _musteriCekDal;

        public MusteriCekManager(IDegerliKagitDal<MusteriCek> musteriCekDal)
            : base(musteriCekDal)
        {
            _musteriCekDal = musteriCekDal;
        }

        #region BusinessRules
        private IResult CheckIfValidAdding(string kod)
        {
            var result = _musteriCekDal.Get(p => p.Kod == kod) != null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.DegerliKagitAlreadyExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidId(int Id)
        {
            var result = _musteriCekDal.Get(p => p.Id == Id) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.DegerliKagitNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidCariIdCiroEden(int cariIdCiroEden)
        {
            var result = _musteriCekDal.Get(p => p.CariIdCiroEden == cariIdCiroEden) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidCariIdCiroEdilen(int cariIdCiroEdilen)
        {
            var result = _musteriCekDal.Get(p => p.CariIdCiroEdilen == cariIdCiroEdilen) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidAlisTarih(DateTime tarih)
        {
            var result = _musteriCekDal.Get(p => p.AlisTarihi == tarih) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.DegerliKagitDateNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidCikisTarih(DateTime tarih)
        {
            var result = _musteriCekDal.Get(p => p.CikisTarihi == tarih) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.DegerliKagitDateNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidAsilBorclu(string asilBorclu)
        {
            var result = _musteriCekDal.Get(p => p.AsilBorclu == asilBorclu) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.DegerliKagitAsilBorcluNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidHesapId(int hesapIdTahsileVerilen)
        {
            var result = _musteriCekDal.Get(p => p.HesapIdTahsileVerilen == hesapIdTahsileVerilen) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.BankaHesapNotExists);
            }
            return new SuccessResult();
        }
        #endregion

        
        public IDataResult<List<MusteriCek>> GetListByAlisTarihi(DateTime tarih)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAlisTarih(tarih));
            if (result != null)
                return (IDataResult<List<MusteriCek>>)result;

            return new SuccessDataResult<List<MusteriCek>>(_musteriCekDal.GetAll(p => p.AlisTarihi == tarih));
        }

        
        public IDataResult<List<MusteriCek>> GetListByAsilBorclu(string asilBorclu)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAsilBorclu(asilBorclu));
            if (result != null)
                return (IDataResult<List<MusteriCek>>)result;

            return new SuccessDataResult<List<MusteriCek>>(_musteriCekDal.GetAll(p => p.AsilBorclu == asilBorclu));
        }

        
        public IDataResult<List<MusteriCek>> GetListByCariIdCiroEden(int cariIdCiroEden)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidCariIdCiroEden(cariIdCiroEden));
            if (result != null)
                return (IDataResult<List<MusteriCek>>)result;

            return new SuccessDataResult<List<MusteriCek>>(_musteriCekDal.GetAll(p => p.CariIdCiroEden == cariIdCiroEden));
        }

        
        public IDataResult<List<MusteriCek>> GetListByCariIdCiroEdilen(int cariIdCiroEdilen)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidCariIdCiroEdilen(cariIdCiroEdilen));
            if (result != null)
                return (IDataResult<List<MusteriCek>>)result;

            return new SuccessDataResult<List<MusteriCek>>(_musteriCekDal.GetAll(p => p.CariIdCiroEdilen == cariIdCiroEdilen));
        }

        
        public IDataResult<List<MusteriCek>> GetListByCikisTarihi(DateTime tarih)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidCikisTarih(tarih));
            if (result != null)
                return (IDataResult<List<MusteriCek>>)result;

            return new SuccessDataResult<List<MusteriCek>>(_musteriCekDal.GetAll(p => p.CikisTarihi == tarih));
        }

        
        public IDataResult<List<MusteriCek>> GetListByHesapIdTahsileVerilen(int hesapIdTahsileVerilen)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidHesapId(hesapIdTahsileVerilen));
            if (result != null)
                return (IDataResult<List<MusteriCek>>)result;

            return new SuccessDataResult<List<MusteriCek>>(_musteriCekDal.GetAll(p => p.HesapIdTahsileVerilen == hesapIdTahsileVerilen));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(MusteriCekValidator))]
        [CacheRemoveAspect("IMusteriCekService.Get")]
        public IResult Add(MusteriCek entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAdding(entity.Kod));
            if (result != null)
                return result;

            _musteriCekDal.Delete(entity);
            return new SuccessResult(Messages.SuccessMessages.DegerliKagitInserted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(MusteriCekValidator))]
        [CacheRemoveAspect("IMusteriCekService.Get")]
        public IResult Delete(MusteriCek entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _musteriCekDal.Delete(entity);
            return new SuccessResult(Messages.SuccessMessages.DegerliKagitDeleted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(MusteriCekValidator))]
        [CacheRemoveAspect("IMusteriCekService.Get")]
        public IResult Update(MusteriCek entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _musteriCekDal.Update(entity);
            return new SuccessResult(Messages.SuccessMessages.DegerliKagitUpdated);
        }
    }
}