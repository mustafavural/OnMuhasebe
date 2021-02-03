using Business.Abstract;
using Business.Constants;
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
        ICariHareketService _cariHareketService;
        IPersonelHareketService _personelHareketService;

        public FaturaManager(IFaturaDal faturaDal, ICariHareketService cariHareketService, IPersonelHareketService personelHareketService)
        {
            _faturaDal = faturaDal;
            _cariHareketService = cariHareketService;
            _personelHareketService = personelHareketService;
        }

        #region BusinessRules
        private IResult CheckIfValidId(int ıd)
        {
            throw new NotImplementedException();
        }

        private IResult CheckIfValidNo(string faturaNo)
        {
            throw new NotImplementedException();
        }

        private IResult CheckIfValidDate(DateTime tarih)
        {
            throw new NotImplementedException();
        }

        private IResult CheckIfValidCariId(int cariId)
        {
            throw new NotImplementedException();
        }

        private IResult CheckIfValidPersonelId(int personelId)
        {
            throw new NotImplementedException();
        }

        private IResult CheckIfValidCariHarId(int cariHareketId)
        {
            throw new NotImplementedException();
        }

        private IResult CheckIfValidPersonelHarId(int personelHareketId)
        {
            throw new NotImplementedException();
        }

        private IResult CheckIfValidAdding(Fatura entity)
        {
            throw new NotImplementedException();
        }
        #endregion

        public IDataResult<Fatura> GetById(int faturaId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(faturaId));
            if (result != null)
                return (IDataResult<Fatura>)result;

            return new SuccessDataResult<Fatura>(_faturaDal.Get(p => p.Id == faturaId));
        }

        public IDataResult<Fatura> GetByNo(string faturaNo)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidNo(faturaNo));
            if (result != null)
                return (IDataResult<Fatura>)result;

            return new SuccessDataResult<Fatura>(_faturaDal.Get(p => p.FaturaNo == faturaNo));
        }

        public IDataResult<Fatura> GetByCariHareketId(int cariHareketId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidCariHarId(cariHareketId));
            if (result != null)
                return (IDataResult<Fatura>)result;

            return new SuccessDataResult<Fatura>(_faturaDal.Get(p => p.CariHarId == cariHareketId));
        }

        public IDataResult<Fatura> GetByPersonelHareketId(int personelHareketId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidPersonelHarId(personelHareketId));
            if (result != null)
                return (IDataResult<Fatura>)result;

            return new SuccessDataResult<Fatura>(_faturaDal.Get(p => p.PersonelHarId == personelHareketId));
        }

        public IDataResult<List<Fatura>> GetListByCariId(int cariId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidCariId(cariId));
            if (result != null)
                return (IDataResult<List<Fatura>>)result;

            return new SuccessDataResult<List<Fatura>>(_faturaDal.GetAll(p =>
            _cariHareketService.GetListByCariId(cariId).Data.Select(s => s.Id).Contains(p.CariHarId)));
        }

        public IDataResult<List<Fatura>> GetListByPersonelId(int personelId)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidPersonelId(personelId));
            if (result != null)
                return (IDataResult<List<Fatura>>)result;

            return new SuccessDataResult<List<Fatura>>(_faturaDal.GetAll(p =>
            _personelHareketService.GetListByPersonelId(personelId).Data.Select(s => s.Id).Contains(p.PersonelHarId)));
        }

        public IDataResult<List<Fatura>> GetListByTarih(DateTime tarih)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidDate(tarih));
            if (result != null)
                return (IDataResult<List<Fatura>>)result;

            return new SuccessDataResult<List<Fatura>>(_faturaDal.GetAll(p => p.Tarih == tarih));
        }

        public IDataResult<List<Fatura>> GetListByKayitTarihi(DateTime tarih)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidDate(tarih));
            if (result != null)
                return (IDataResult<List<Fatura>>)result;

            return new SuccessDataResult<List<Fatura>>(_faturaDal.GetAll(p => p.KayitTarihi == tarih));
        }

        public IDataResult<List<Fatura>> GetList()
        {
            return new SuccessDataResult<List<Fatura>>(_faturaDal.GetAll());
        }

        public IResult Add(Fatura entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidAdding(entity));
            if (result != null)
                return result;

            _faturaDal.Add(entity);
            return new SuccessResult(Messages.SuccessMessages.FaturaInserted);
        }

        public IResult Delete(Fatura entity)
        {
            IResult result = BusinessRules.Run(
                CheckIfValidId(entity.Id));
            if (result != null)
                return result;

            _faturaDal.Delete(entity);
            return new SuccessResult(Messages.SuccessMessages.FaturaDeleted);
        }

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