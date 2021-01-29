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
        private ISirketCariDal _sirketCariDal;
        private ICariDal _cariDal;
        private ICariGrupService _cariGrupService;
        private ICariGrupKodService _cariGrupKodService;
        public SirketCariManager(ISirketCariDal sirketCariDal, ICariGrupKodService cariGrupKodService, ICariGrupService cariGrupService, ICariDal cariDal)
        {
            _sirketCariDal = sirketCariDal;
            _cariDal = cariDal;
            _cariGrupService = cariGrupService;
            _cariGrupKodService = cariGrupKodService;
        }

        public IDataResult<SirketCari> GetById(int cariId)
        {
            return new SuccessDataResult<SirketCari>(_sirketCariDal.GetBy(p => p.CariId == cariId).SingleOrDefault());
        }

        public IDataResult<SirketCari> GetByKod(string cariKod)
        {
            return new SuccessDataResult<SirketCari>(_sirketCariDal.GetBy(p => p.Kod == cariKod).SingleOrDefault());
        }

        public IDataResult<SirketCari> GetByUnvan(string cariUnvan)
        {
            return new SuccessDataResult<SirketCari>(_sirketCariDal.GetBy(p => p.Unvan == cariUnvan).SingleOrDefault());
        }

        public IDataResult<SirketCari> GetByVergiNo(string VergiNo)
        {
            return new SuccessDataResult<SirketCari>(_sirketCariDal.GetBy(p => p.VergiNo == VergiNo).SingleOrDefault());
        }

        public IDataResult<List<SirketCari>> GetList()
        {
            return new SuccessDataResult<List<SirketCari>>(_sirketCariDal.GetBy());
        }

        public IDataResult<List<SirketCari>> GetListByVergiDairesi(string vergiDairesi)
        {
            return new SuccessDataResult<List<SirketCari>>(_sirketCariDal.GetBy(p => p.VergiDairesi == vergiDairesi));
        }

        public IDataResult<List<SirketCari>> GetListByGrupAd(string grupKodAd)
        {
            return new SuccessDataResult<List<SirketCari>>(_sirketCariDal.GetBy().Where(p =>
            _cariGrupService.GetListByCariGrupKodId(
                _cariGrupKodService.GetByAd(grupKodAd).Data.Id).Data.Select(s => s.Id).Contains(p.Id)).ToList());
        }

        public IResult Add(SirketCari cari)
        {
            _cariDal.Add(new Cari { Kod = cari.Kod, Unvan = cari.Unvan, VergiDairesi = cari.VergiDairesi });
            _sirketCariDal.Add(new SirketCari { CariId = _cariDal.Get(p => p.Kod == cari.Kod).Id, VergiNo = cari.VergiNo });
            return new SuccessResult(Messages.CariInserted);
        }

        public IResult Delete(SirketCari cari)
        {
            _sirketCariDal.Delete(_sirketCariDal.Get(p => p.VergiNo == cari.VergiNo));
            _cariDal.Delete(_cariDal.Get(p => p.Kod == cari.Kod));
            return new SuccessResult(Messages.CariDeleted);
        }

        public IResult Update(SirketCari cari)
        {
            var updateCari = _sirketCariDal.Get(p => p.VergiNo == cari.VergiNo);
            updateCari.Kod = cari.Kod;
            updateCari.Unvan = cari.Unvan;
            updateCari.VergiDairesi = cari.VergiDairesi;
            updateCari.VergiNo = cari.VergiNo;
            _sirketCariDal.Update(updateCari);
            _cariDal.Update(new Cari { Id = updateCari.CariId, Kod = updateCari.Kod, Unvan = updateCari.Unvan, VergiDairesi = updateCari.VergiDairesi });
            return new SuccessResult(Messages.CariUpdated);
        }
    }
}