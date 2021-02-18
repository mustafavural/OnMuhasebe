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
    public class PersonelHareketManager : IPersonelHareketService
    {
        IPersonelHareketDal _personelHareketDal;

        public PersonelHareketManager(IPersonelHareketDal personelHareketDal)
        {
            _personelHareketDal = personelHareketDal;
        }

        #region BusinessRules
        private IResult CheckIfValidAdding(PersonelHareket entity)
        {
            var result = _personelHareketDal.Get(p => p.IslemTarihi == entity.IslemTarihi &&
                                                      p.PersonelId == entity.PersonelId &&
                                                      p.Tur == entity.Tur) != null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.PersonelActivityAlreadyExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidId(int Id)
        {
            var result = _personelHareketDal.Get(p => p.Id == Id) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.PersonelActivityNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidIslemTarih(DateTime tarih)
        {
            var result = _personelHareketDal.Get(p => p.IslemTarihi == tarih) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.PersonelActivityDateNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidPersonelId(int personelId)
        {
            var result = _personelHareketDal.Get(p => p.PersonelId == personelId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.PersonelNotExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfValidTur(string tur)
        {
            var result = _personelHareketDal.Get(p => p.Tur == tur) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.PersonelActivityTurNotExists);
            }
            return new SuccessResult();
        }
        #endregion

        
        public IDataResult<PersonelHareket> GetById(int Id)
        {
            var result = BusinessRules.Run(
                CheckIfValidId(Id));
            if (result != null)
                return (IDataResult<PersonelHareket>)result;

            return new SuccessDataResult<PersonelHareket>(_personelHareketDal.Get(p => p.Id == Id));
        }

        
        public IDataResult<List<PersonelHareket>> GetList()
        {
            return new SuccessDataResult<List<PersonelHareket>>(_personelHareketDal.GetAll());
        }

        
        public IDataResult<List<PersonelHareket>> GetListByIslemTarihi(DateTime tarih)
        {
            var result = BusinessRules.Run(
                CheckIfValidIslemTarih(tarih));
            if (result != null)
                return (IDataResult<List<PersonelHareket>>)result;

            return new SuccessDataResult<List<PersonelHareket>>(_personelHareketDal.GetAll(p => p.IslemTarihi == tarih));
        }

        
        public IDataResult<List<PersonelHareket>> GetListByPersonelId(int personelId)
        {
            var result = BusinessRules.Run(
                CheckIfValidPersonelId(personelId));
            if (result != null)
                return (IDataResult<List<PersonelHareket>>)result;

            return new SuccessDataResult<List<PersonelHareket>>(_personelHareketDal.GetAll(p => p.PersonelId == personelId));
        }

        
        public IDataResult<List<PersonelHareket>> GetListByTur(string tur)
        {
            var result = BusinessRules.Run(
                CheckIfValidTur(tur));
            if (result != null)
                return (IDataResult<List<PersonelHareket>>)result;

            return new SuccessDataResult<List<PersonelHareket>>(_personelHareketDal.GetAll(p => p.Tur == tur));
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(PersonelHareketValidator))]
        [CacheRemoveAspect("IPersonelHareketService.Get")]
        public IResult Add(PersonelHareket entity)
        {
            var result = BusinessRules.Run(
                CheckIfValidAdding(entity));
            if (result != null)
                return (IDataResult<List<PersonelHareket>>)result;

            _personelHareketDal.Add(entity);
            return new SuccessResult(Messages.SuccessMessages.PersonelActivityInserted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(PersonelHareketValidator))]
        [CacheRemoveAspect("IPersonelHareketService.Get")]
        public IResult Delete(PersonelHareket entity)
        {
            var result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return (IDataResult<List<PersonelHareket>>)result;

            _personelHareketDal.Delete(entity);
            return new SuccessResult(Messages.SuccessMessages.PersonelActivityDeleted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(PersonelHareketValidator))]
        [CacheRemoveAspect("IPersonelHareketService.Get")]
        public IResult Update(PersonelHareket entity)
        {
            var result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return (IDataResult<List<PersonelHareket>>)result;

            _personelHareketDal.Update(entity);
            return new SuccessResult(Messages.SuccessMessages.PersonelActivityUpdated);
        }
    }
}