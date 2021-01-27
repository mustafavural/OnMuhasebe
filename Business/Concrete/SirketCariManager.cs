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
        ISirketCariDal _sirketCariDal;
        ICariGrupService _cariGrupService;
        ICariGrupKodService _cariGrupKodService;
        public SirketCariManager(ISirketCariDal sirketCariDal, ICariGrupService cariGrupService, ICariGrupKodService cariGrupKodService)
        {
            _sirketCariDal = sirketCariDal;
            _cariGrupKodService = cariGrupKodService;
            _cariGrupService = cariGrupService;
        }

        public IDataResult<SirketCari> GetById(int sirketCariId)
        {
            return new SuccessDataResult<SirketCari>(_sirketCariDal.Get(p => p.Id == sirketCariId));
        }

        public IDataResult<SirketCari> GetByKod(string sirketCariKod)
        {
            return new SuccessDataResult<SirketCari>(_sirketCariDal.Get(p => p.Kod == sirketCariKod));
        }

        public IDataResult<SirketCari> GetByUnvan(string sirketCariUnvan)
        {
            return new SuccessDataResult<SirketCari>(_sirketCariDal.Get(p => p.Unvan == sirketCariUnvan));
        }

        public IDataResult<SirketCari> GetByVergiNo(string VergiNo)
        {
            return new SuccessDataResult<SirketCari>(_sirketCariDal.Get(p => p.VergiNo == VergiNo));
        }

        public IDataResult<List<SirketCari>> GetList()
        {
            return new SuccessDataResult<List<SirketCari>>(_sirketCariDal.GetAll());
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