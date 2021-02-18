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
    public class PersonelManager : IPersonelService
    {
        IPersonelDal _personelDal;

        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        #region BusinessRules
        private IResult CheckIfValidAdding(Personel entity)
        {
            var result = _personelDal.Get(p => p.TCNo == entity.TCNo) != null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.PersonelAlreadyExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidId(int Id)
        {
            var result = _personelDal.Get(p => p.Id == Id) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.PersonelNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidAd(string ad)
        {
            var result = _personelDal.GetAll(p => p.Ad == ad) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.PersonelNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidIkinciAd(string ikinciAd)
        {
            var result = _personelDal.GetAll(p => p.IkinciAd == ikinciAd) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.PersonelNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidSoyad(string soyad)
        {
            var result = _personelDal.GetAll(p => p.Soyad == soyad) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.PersonelNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidTCNo(string tcNo)
        {
            var result = _personelDal.Get(p => p.TCNo == tcNo) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.PersonelNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidDogumTarihi(DateTime tarih)
        {
            var result = _personelDal.GetAll(p => p.DogumTarihi == tarih) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.PersonelNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidCinsiyet(string cinsiyet)
        {
            var result = _personelDal.GetAll(p => p.Cinsiyet == cinsiyet) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.PersonelNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidMedeniHal(string medenihal)
        {
            var result = _personelDal.GetAll(p => p.MedeniHal == medenihal) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.PersonelNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidCocukSayisi(int cocukSayisi)
        {
            var result = _personelDal.GetAll(p => p.CocukSayisi == cocukSayisi) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.PersonelNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidBirim(string birim)
        {
            var result = _personelDal.GetAll(p => p.Birim == birim) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.PersonelNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidGorev(string gorev)
        {
            var result = _personelDal.GetAll(p => p.Gorev == gorev) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.PersonelNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidIzin(int izin)
        {
            var result = _personelDal.GetAll(p => p.Izin == izin) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.PersonelNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidKatSayi(int katSayi)
        {
            var result = _personelDal.GetAll(p => p.KatSayi == katSayi) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.PersonelNotExists);
            }
            return new SuccessResult();
        }
        #endregion

        
        public IDataResult<Personel> GetById(int Id)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(Id));
            if (result != null)
                return (IDataResult<Personel>)result;

            return new SuccessDataResult<Personel>(_personelDal.Get(p => p.Id == Id));
        }

        
        public IDataResult<List<Personel>> GetListByAd(string ad)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAd(ad));
            if (result != null)
                return (IDataResult<List<Personel>>)result;

            return new SuccessDataResult<List<Personel>>(_personelDal.GetAll(p => p.Ad == ad));
        }

        
        public IDataResult<List<Personel>> GetListByIkinciAd(string ikinciAd)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidIkinciAd(ikinciAd));
            if (result != null)
                return (IDataResult<List<Personel>>)result;

            return new SuccessDataResult<List<Personel>>(_personelDal.GetAll(p => p.IkinciAd == ikinciAd));
        }

        
        public IDataResult<List<Personel>> GetListBySoyad(string soyad)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidSoyad(soyad));
            if (result != null)
                return (IDataResult<List<Personel>>)result;

            return new SuccessDataResult<List<Personel>>(_personelDal.GetAll(p => p.Soyad == soyad));
        }

        
        public IDataResult<List<Personel>> GetListByTCNo(string tcNo)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidTCNo(tcNo));
            if (result != null)
                return (IDataResult<List<Personel>>)result;

            return new SuccessDataResult<List<Personel>>(_personelDal.GetAll(p => p.TCNo == tcNo));
        }

        
        public IDataResult<List<Personel>> GetListByDogumTarihi(DateTime tarih)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidDogumTarihi(tarih));
            if (result != null)
                return (IDataResult<List<Personel>>)result;

            return new SuccessDataResult<List<Personel>>(_personelDal.GetAll(p => p.DogumTarihi == tarih));
        }

        
        public IDataResult<List<Personel>> GetListByCinsiyet(string cinsiyet)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidCinsiyet(cinsiyet));
            if (result != null)
                return (IDataResult<List<Personel>>)result;

            return new SuccessDataResult<List<Personel>>(_personelDal.GetAll(p => p.Cinsiyet == cinsiyet));
        }

        
        public IDataResult<List<Personel>> GetListByMedeniHal(string medeniHal)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidMedeniHal(medeniHal));
            if (result != null)
                return (IDataResult<List<Personel>>)result;

            return new SuccessDataResult<List<Personel>>(_personelDal.GetAll(p => p.MedeniHal == medeniHal));
        }

        
        public IDataResult<List<Personel>> GetListByCocukSayisi(int cocukSayisi)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidCocukSayisi(cocukSayisi));
            if (result != null)
                return (IDataResult<List<Personel>>)result;

            return new SuccessDataResult<List<Personel>>(_personelDal.GetAll(p => p.CocukSayisi == cocukSayisi));
        }

        
        public IDataResult<List<Personel>> GetListByBirim(string birim)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidBirim(birim));
            if (result != null)
                return (IDataResult<List<Personel>>)result;

            return new SuccessDataResult<List<Personel>>(_personelDal.GetAll(p => p.Birim == birim));
        }

        
        public IDataResult<List<Personel>> GetListByGorev(string gorev)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidGorev(gorev));
            if (result != null)
                return (IDataResult<List<Personel>>)result;

            return new SuccessDataResult<List<Personel>>(_personelDal.GetAll(p => p.Gorev == gorev));
        }

        
        public IDataResult<List<Personel>> GetListByIzin(int izin)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidIzin(izin));
            if (result != null)
                return (IDataResult<List<Personel>>)result;

            return new SuccessDataResult<List<Personel>>(_personelDal.GetAll(p => p.Izin == izin));
        }

        
        public IDataResult<List<Personel>> GetListByKatSayi(int katSayi)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidKatSayi(katSayi));
            if (result != null)
                return (IDataResult<List<Personel>>)result;

            return new SuccessDataResult<List<Personel>>(_personelDal.GetAll(p => p.KatSayi == katSayi));
        }

        
        public IDataResult<List<Personel>> GetList()
        {
            throw new NotImplementedException();
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(PersonelValidator))]
        [CacheRemoveAspect("IPersonelService.Get")]
        public IResult Add(Personel entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAdding(entity));
            if (result != null)
                return result;

            _personelDal.Add(entity);
            return new SuccessResult(Messages.SuccessMessages.PersonelInserted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(PersonelValidator))]
        [CacheRemoveAspect("IPersonelService.Get")]
        public IResult Delete(Personel entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _personelDal.Delete(entity);
            return new SuccessResult(Messages.SuccessMessages.PersonelDeleted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(PersonelValidator))]
        [CacheRemoveAspect("IPersonelService.Get")]
        public IResult Update(Personel entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _personelDal.Update(entity);
            return new SuccessResult(Messages.SuccessMessages.PersonelUpdated);
        }
    }
}