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
    public class IrsaliyeManager : IIrsaliyeService
    {
        IIrsaliyeDal _irsaliyeDal;
        ICariHareketService _cariHareketService;
        IPersonelHareketService _personelHareketService;
        ICariDal<Cari> _cariDal;
        IPersonelService _personelService;
        public IrsaliyeManager(IIrsaliyeDal irsaliyeDal, ICariHareketService cariHareketService, IPersonelHareketService personelHareketService, ICariDal<Cari> cariDal, IPersonelService personelService)
        {
            _irsaliyeDal = irsaliyeDal;
            _cariHareketService = cariHareketService;
            _personelHareketService = personelHareketService;
            _cariDal = cariDal;
            _personelService = personelService;
        }

        #region BusinessRules
        private IResult CheckIfValidId(int Id)
        {
            var result = _irsaliyeDal.Get(p => p.Id == Id) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.IrsaliyeNotExists);
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

        private IResult CheckIfValidDate(DateTime tarih)
        {
            var result = _irsaliyeDal.Get(p => p.Tarih == tarih) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.EvrakDateNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidSaveDate(DateTime tarih)
        {
            var result = _irsaliyeDal.Get(p => p.KayitTarihi == tarih) == null;
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
            var result = _irsaliyeDal.Get(p => p.CariHarId == cariHareketId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.CariActivityNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidPersonelHarId(int personelHareketId)
        {
            var result = _irsaliyeDal.Get(p => p.PersonelHarId == personelHareketId) == null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.PersonelActivityNotExists);
            }
            return new SuccessResult();
        }

        private IResult CheckIfValidAdding(Irsaliye entity)
        {
            var result = _irsaliyeDal.Get(p => p.IrsaliyeNo == entity.IrsaliyeNo) != null;
            if (result)
            {
                return new ErrorResult(Messages.ErrorMessages.IrsaliyeNoAlreadyExists);
            }
            return new SuccessResult();
        }
        #endregion

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<Irsaliye> GetById(int irsaliyeId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(irsaliyeId));
            if (result != null)
                return (IDataResult<Irsaliye>)result;

            return new SuccessDataResult<Irsaliye>(_irsaliyeDal.Get(p => p.Id == irsaliyeId));
        }

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
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<Irsaliye> GetByCariHareketId(int cariHareketId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidCariHarId(cariHareketId));
            if (result != null)
                return (IDataResult<Irsaliye>)result;

            return new SuccessDataResult<Irsaliye>(_irsaliyeDal.Get(p => p.CariHarId == cariHareketId));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<Irsaliye> GetByPersonelHareketId(int personelHareketId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidPersonelHarId(personelHareketId));
            if (result != null)
                return (IDataResult<Irsaliye>)result;

            return new SuccessDataResult<Irsaliye>(_irsaliyeDal.Get(p => p.PersonelHarId == personelHareketId));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<Irsaliye>> GetListByCariId(int cariId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidCariId(cariId));
            if (result != null)
                return (IDataResult<List<Irsaliye>>)result;

            return new SuccessDataResult<List<Irsaliye>>(_irsaliyeDal.GetAll(p =>
            _cariHareketService.GetListByCariId(cariId).Data.Select(s => s.Id).Contains(p.CariHarId)));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<Irsaliye>> GetListByPersonelId(int personelId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidPersonelId(personelId));
            if (result != null)
                return (IDataResult<List<Irsaliye>>)result;

            return new SuccessDataResult<List<Irsaliye>>(_irsaliyeDal.GetAll(p =>
            _personelHareketService.GetListByPersonelId(personelId).Data.Select(s => s.PersonelId).Contains(p.PersonelHarId)));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<Irsaliye>> GetListByTarih(DateTime tarih)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidDate(tarih));
            if (result != null)
                return (IDataResult<List<Irsaliye>>)result;

            return new SuccessDataResult<List<Irsaliye>>(_irsaliyeDal.GetAll(p => p.Tarih == tarih));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<Irsaliye>> GetListByKayitTarihi(DateTime tarih)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidSaveDate(tarih));
            if (result != null)
                return (IDataResult<List<Irsaliye>>)result;

            return new SuccessDataResult<List<Irsaliye>>(_irsaliyeDal.GetAll(p => p.KayitTarihi == tarih));
        }

        [PerformanceAspect(1)]
        [CacheAspect()]
        [LogAspect()]
        public IDataResult<List<Irsaliye>> GetList()
        {
            return new SuccessDataResult<List<Irsaliye>>(_irsaliyeDal.GetAll());
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(IrsaliyeValidator))]
        [CacheRemoveAspect("IFaturaService.Get")]
        public IResult Add(Irsaliye entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAdding(entity));
            if (result != null)
                return result;

            _irsaliyeDal.Add(entity);
            return new SuccessResult(Messages.SuccessMessages.IrsaliyeInserted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(IrsaliyeValidator))]
        [CacheRemoveAspect("IFaturaService.Get")]
        public IResult Delete(Irsaliye entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _irsaliyeDal.Delete(entity);
            return new SuccessResult(Messages.SuccessMessages.IrsaliyeDeleted);
        }

        [PerformanceAspect(1)]
        [LogAspect()]
        [ValidationAspect(typeof(IrsaliyeValidator))]
        [CacheRemoveAspect("IFaturaService.Get")]
        public IResult Update(Irsaliye entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _irsaliyeDal.Update(entity);
            return new SuccessResult(Messages.SuccessMessages.IrsaliyeUpdated);
        }
    }
}