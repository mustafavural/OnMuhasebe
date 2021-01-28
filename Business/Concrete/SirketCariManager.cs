using Business.Abstract;
using Business.Constans;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class SirketCariManager : ISirketCariService
    {
        ICariDal _cariDal;
        ISirketCariDal _sirketCariDal;
        ICariGrupService _cariGrupService;
        ICariGrupKodService _cariGrupKodService;
        public SirketCariManager(ISirketCariDal sirketCariDal, ICariGrupKodService cariGrupKodService, ICariGrupService cariGrupService, ICariDal cariDal)
        {
            _cariDal = cariDal;
            _sirketCariDal = sirketCariDal;
            _cariGrupService = cariGrupService;
            _cariGrupKodService = cariGrupKodService;
        }

        public IDataResult<SirketCari> GetByVergiNo(string VergiNo)
        {
            SirketCari temp = _sirketCariDal.Get(p => p.VergiNo == VergiNo);
            SirketCari dataresult = (SirketCari)_cariDal.Get(p => p.Id == temp.Id);
            dataresult.VergiNo = temp.VergiNo;
            return new SuccessDataResult<SirketCari>(dataresult);
        }

        public IDataResult<SirketCari> GetById(int sirketCariId)
        {
            SirketCari dataresult = (SirketCari)_cariDal.Get(p => p.Id == sirketCariId);
            dataresult.VergiNo = _sirketCariDal.Get(p => p.Id == dataresult.Id).VergiNo;
            return new SuccessDataResult<SirketCari>(dataresult);
        }

        public IDataResult<SirketCari> GetByKod(string sirketCariKod)
        {
            SirketCari dataresult = (SirketCari)_cariDal.Get(p => p.Kod == sirketCariKod);
            dataresult.VergiNo = _sirketCariDal.Get(p => p.Id == dataresult.Id).VergiNo;
            return new SuccessDataResult<SirketCari>(dataresult);
        }

        public IDataResult<SirketCari> GetByUnvan(string sirketCariUnvan)
        {
            SirketCari dataresult = (SirketCari)_cariDal.Get(p => p.Unvan == sirketCariUnvan);
            dataresult.VergiNo = _sirketCariDal.Get(p => p.Id == dataresult.Id).VergiNo;
            return new SuccessDataResult<SirketCari>(dataresult);
        }

        public IDataResult<List<SirketCari>> GetList()
        {
            var result = _cariDal.GetAll().Join(_sirketCariDal.GetAll(),
                c => c.Id, s => s.Id,
                (c, s) =>
                new
                {
                    Id = c.Id,
                    Kod = c.Kod,
                    Unvan = c.Unvan,
                    VergiDairesi = c.VergiDairesi,
                    VergiNo = s.VergiNo
                }).ToList();
            return new SuccessDataResult<List<SirketCari>>(result);
        }

        public IDataResult<List<SirketCari>> GetListByVergiDairesi(string sirketVergiDairesi)
        {
            return new SuccessDataResult<List<SirketCari>>(_sirketCariDal.GetAll(p => p.VergiDairesi == sirketVergiDairesi));
        }

        public IDataResult<List<SirketCari>> GetListByGrupKodId(int grupKodId)
        {
            return new SuccessDataResult<List<SirketCari>>(_sirketCariDal.GetAll(p =>
            _cariGrupService.GetListByCariGrupKodId(grupKodId).Data.Select(s => s.CariId).Contains(p.Id)));
        }

        public IDataResult<List<SirketCari>> GetListByGrupAd(string grupKodAd)
        {
            return new SuccessDataResult<List<SirketCari>>(_sirketCariDal.GetAll(p =>
            _cariGrupService.GetListByCariGrupKodId(_cariGrupKodService.GetByAd(grupKodAd).Data.Id).Data.Select(s => s.Id).Contains(p.Id)));
        }

        public IResult Add(SirketCari sirketCari)
        {
            _sirketCariDal.Add(sirketCari);
            return new SuccessResult(Messages.SirketCariInserted);
        }

        public IResult Delete(SirketCari sirketCari)
        {
            _sirketCariDal.Delete(sirketCari);
            return new SuccessResult(Messages.SirketCariDeleted);
        }

        public IResult Update(SirketCari sirketCari)
        {
            _sirketCariDal.Update(sirketCari);
            return new SuccessResult(Messages.SirketCariUpdated);
        }
    }
}