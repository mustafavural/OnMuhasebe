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
using System.Linq;

namespace Business.Concrete
{
    public class FaturaManager : IFaturaService
    {
        IFaturaDal _faturaDal;
        ICariDal<Cari> _cariDal;
        ICariHareketService _cariHareketService;
        IPersonelService _personelService;
        IPersonelHareketService _personelHareketService;

        public FaturaManager(IFaturaDal faturaDal, ICariHareketService cariHareketService, IPersonelHareketService personelHareketService, ICariDal<Cari> cariDal, IPersonelService personelService)
        {
            _faturaDal = faturaDal;
            _cariHareketService = cariHareketService;
            _personelHareketService = personelHareketService;
            _cariDal = cariDal;
            _personelService = personelService;
        }

        #region BusinessRules
        private IResult CheckIfValidId(int Id)
        {
            var result = _faturaDal.Get(p => p.Id == Id) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.FaturaNotExists);
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

        private IResult CheckIfValidDate(DateTime tarih)
        {
            var result = _faturaDal.Get(p => p.Tarih == tarih) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.EvrakDateNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidSaveDate(DateTime tarih)
        {
            var result = _faturaDal.Get(p => p.KayitTarihi == tarih) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.EvrakDateNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidCariId(int cariId)
        {
            var result = _cariDal.Get(p => p.Id == cariId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidPersonelId(int personelId)
        {
            var result = _personelService.GetById(personelId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.PersonelNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidCariHarId(int cariHareketId)
        {
            var result = _faturaDal.Get(p => p.CariHarId == cariHareketId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariActivityNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidPersonelHarId(int personelHareketId)
        {
            var result = _faturaDal.Get(p => p.PersonelHarId == personelHareketId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.PersonelActivityNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidAdding(Fatura entity)
        {
            var result = _faturaDal.Get(p => p.FaturaNo == entity.FaturaNo) != null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.FaturaNoAlreadyExists);
            }
            return new SuccessResult();
        }
        #endregion

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<Fatura> GetById(int faturaId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(faturaId));
            if (result != null)
                return (IDataResult<Fatura>)result;

            return new SuccessDataResult<Fatura>(_faturaDal.Get(p => p.Id == faturaId));
        }

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
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<Fatura> GetByCariHareketId(int cariHareketId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidCariHarId(cariHareketId));
            if (result != null)
                return (IDataResult<Fatura>)result;

            return new SuccessDataResult<Fatura>(_faturaDal.Get(p => p.CariHarId == cariHareketId));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<Fatura> GetByPersonelHareketId(int personelHareketId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidPersonelHarId(personelHareketId));
            if (result != null)
                return (IDataResult<Fatura>)result;

            return new SuccessDataResult<Fatura>(_faturaDal.Get(p => p.PersonelHarId == personelHareketId));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<Fatura>> GetListByCariId(int cariId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidCariId(cariId));
            if (result != null)
                return (IDataResult<List<Fatura>>)result;

            return new SuccessDataResult<List<Fatura>>(_faturaDal.GetAll(p =>
            _cariHareketService.GetListByCariId(cariId).Data.Select(s => s.Id).Contains(p.CariHarId)));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<Fatura>> GetListByPersonelId(int personelId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidPersonelId(personelId));
            if (result != null)
                return (IDataResult<List<Fatura>>)result;

            return new SuccessDataResult<List<Fatura>>(_faturaDal.GetAll(p =>
            _personelHareketService.GetListByPersonelId(personelId).Data.Select(s => s.PersonelId).Contains(p.PersonelHarId)));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<Fatura>> GetListByTarih(DateTime tarih)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidDate(tarih));
            if (result != null)
                return (IDataResult<List<Fatura>>)result;

            return new SuccessDataResult<List<Fatura>>(_faturaDal.GetAll(p => p.Tarih == tarih));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<Fatura>> GetListByKayitTarihi(DateTime tarih)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidSaveDate(tarih));
            if (result != null)
                return (IDataResult<List<Fatura>>)result;

            return new SuccessDataResult<List<Fatura>>(_faturaDal.GetAll(p => p.KayitTarihi == tarih));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<Fatura>> GetList()
        {
            return new SuccessDataResult<List<Fatura>>(_faturaDal.GetAll());
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
            return new SuccessResult(Messages.SuccessMessages.FaturaInserted);
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
            return new SuccessResult(Messages.SuccessMessages.FaturaDeleted);
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
            return new SuccessResult(Messages.SuccessMessages.FaturaUpdated);
        }
    }
}