using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Performance;
using Core.Utilities.Business;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class EvrakManager<TEntity> : IEvrakService<TEntity>
        where TEntity : Evrak, new()
    {
        IEvrakDal<TEntity> _faturaDal;
        ICariService<Cari> _cariService;
        ICariHareketService _cariHareketService;
        IPersonelService _personelService;
        IPersonelHareketService _personelHareketService;

        public EvrakManager(IEvrakDal<TEntity> faturaDal, ICariHareketService cariHareketService, IPersonelHareketService personelHareketService, ICariService<Cari> cariService, IPersonelService personelService)
        {
            _faturaDal = faturaDal;
            _cariService = cariService;
            _cariHareketService = cariHareketService;
            _personelService = personelService;
            _personelHareketService = personelHareketService;
        }

        #region BusinessRules
        private IResult CheckIfValidId(int Id)
        {
            var result = _faturaDal.Get(p => p.Id == Id) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.EvrakNotExists);
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
            var result = _cariService.GetById(cariId) == null;
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
        #endregion

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<TEntity> GetById(int faturaId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(faturaId));
            if (result != null)
                return (IDataResult<TEntity>)result;

            return new SuccessDataResult<TEntity>(_faturaDal.Get(p => p.Id == faturaId));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<TEntity> GetByCariHareketId(int cariHareketId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidCariHarId(cariHareketId));
            if (result != null)
                return (IDataResult<TEntity>)result;

            return new SuccessDataResult<TEntity>(_faturaDal.Get(p => p.CariHarId == cariHareketId));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<TEntity> GetByPersonelHareketId(int personelHareketId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidPersonelHarId(personelHareketId));
            if (result != null)
                return (IDataResult<TEntity>)result;

            return new SuccessDataResult<TEntity>(_faturaDal.Get(p => p.PersonelHarId == personelHareketId));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<TEntity>> GetListByCariId(int cariId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidCariId(cariId));
            if (result != null)
                return (IDataResult<List<TEntity>>)result;

            return new SuccessDataResult<List<TEntity>>(_faturaDal.GetAll(p =>
            _cariHareketService.GetListByCariId(cariId).Data.Select(s => s.Id).Contains(p.CariHarId)));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<TEntity>> GetListByPersonelId(int personelId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidPersonelId(personelId));
            if (result != null)
                return (IDataResult<List<TEntity>>)result;

            return new SuccessDataResult<List<TEntity>>(_faturaDal.GetAll(p =>
            _personelHareketService.GetListByPersonelId(personelId).Data.Select(s => s.PersonelId).Contains(p.PersonelHarId)));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<TEntity>> GetListByTarih(DateTime tarih)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidDate(tarih));
            if (result != null)
                return (IDataResult<List<TEntity>>)result;

            return new SuccessDataResult<List<TEntity>>(_faturaDal.GetAll(p => p.Tarih == tarih));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<TEntity>> GetListByKayitTarihi(DateTime tarih)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidSaveDate(tarih));
            if (result != null)
                return (IDataResult<List<TEntity>>)result;

            return new SuccessDataResult<List<TEntity>>(_faturaDal.GetAll(p => p.KayitTarihi == tarih));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<TEntity>> GetList()
        {
            return new SuccessDataResult<List<TEntity>>(_faturaDal.GetAll());
        }
    }
}