using Business.Abstract;
using Business.Constants;
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

        public IrsaliyeManager(IIrsaliyeDal irsaliyeDal, ICariHareketService cariHareketService)
        {
            _irsaliyeDal = irsaliyeDal;
            _cariHareketService = cariHareketService;
        }

        public IDataResult<Irsaliye> GetById(int irsaliyeId)
        {
            return new SuccessDataResult<Irsaliye>(_irsaliyeDal.Get(p => p.Id == irsaliyeId));
        }

        public IDataResult<Irsaliye> GetByNo(string irsaliyeNo)
        {
            return new SuccessDataResult<Irsaliye>(_irsaliyeDal.Get(p => p.IrsaliyeNo == irsaliyeNo));
        }

        public IDataResult<Irsaliye> GetByCariHareketId(int cariHareketId)
        {
            return new SuccessDataResult<Irsaliye>(_irsaliyeDal.Get(p => p.CariHarId == cariHareketId));
        }

        public IDataResult<Irsaliye> GetByPersonelHareketId(int personelHareketId)
        {
            return new SuccessDataResult<Irsaliye>(_irsaliyeDal.Get(p => p.PersonelHarId == personelHareketId));
        }

        public IDataResult<List<Irsaliye>> GetListByCariId(int cariId)
        {
            return new SuccessDataResult<List<Irsaliye>>(_irsaliyeDal.GetAll(p =>
            _cariHareketService.GetListByCariId(cariId).Data.Select(s => s.Id).Contains(p.CariHarId)));
        }

        public IDataResult<List<Irsaliye>> GetListByTarih(DateTime tarih)
        {
            return new SuccessDataResult<List<Irsaliye>>(_irsaliyeDal.GetAll(p => p.Tarih == tarih));
        }

        public IDataResult<List<Irsaliye>> GetListByKayitTarihi(DateTime tarih)
        {
            return new SuccessDataResult<List<Irsaliye>>(_irsaliyeDal.GetAll(p => p.KayitTarihi == tarih));
        }

        public IDataResult<List<Irsaliye>> GetList()
        {
            return new SuccessDataResult<List<Irsaliye>>(_irsaliyeDal.GetAll());
        }

        public IResult Add(Irsaliye entity)
        {
            _irsaliyeDal.Add(entity);
            return new SuccessResult(Messages.SuccessMessages.IrsaliyeInserted);
        }

        public IResult Delete(Irsaliye entity)
        {
            _irsaliyeDal.Delete(entity);
            return new SuccessResult(Messages.SuccessMessages.IrsaliyeDeleted);
        }

        public IResult Update(Irsaliye entity)
        {
            _irsaliyeDal.Update(entity);
            return new SuccessResult(Messages.SuccessMessages.IrsaliyeUpdated);
        }
    }
}