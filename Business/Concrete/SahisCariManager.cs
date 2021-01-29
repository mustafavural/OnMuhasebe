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
    public class SahisCariManager : ISahisCariService
    {
        ICariDal _cariDal;
        ISahisCariDal _sahisCariDal;
        ICariGrupService _cariGrupService;
        ICariGrupKodService _cariGrupKodService;
        public SahisCariManager(ISahisCariDal sahisCariDal, ICariGrupService cariGrupService, ICariGrupKodService cariGrupKodService, ICariDal cariDal)
        {
            _cariDal = cariDal;
            _sahisCariDal = sahisCariDal;
            _cariGrupService = cariGrupService;
            _cariGrupKodService = cariGrupKodService;
        }

        public IDataResult<SahisCari> GetById(int cariId)
        {
            return new SuccessDataResult<SahisCari>(_sahisCariDal.GetBy(p => p.CariId == cariId).SingleOrDefault());
        }

        public IDataResult<SahisCari> GetByKod(string cariKod)
        {
            return new SuccessDataResult<SahisCari>(_sahisCariDal.GetBy(p => p.Kod == cariKod).SingleOrDefault());
        }

        public IDataResult<SahisCari> GetByTCNo(string TCNo)
        {
            return new SuccessDataResult<SahisCari>(_sahisCariDal.GetBy(p => p.TCNo == TCNo).SingleOrDefault());
        }

        public IDataResult<SahisCari> GetByUnvan(string cariUnvan)
        {
            return new SuccessDataResult<SahisCari>(_sahisCariDal.GetBy(p => p.Unvan == cariUnvan).SingleOrDefault());
        }

        public IDataResult<List<SahisCari>> GetList()
        {
            return new SuccessDataResult<List<SahisCari>>(_sahisCariDal.GetBy());
        }

        public IDataResult<List<SahisCari>> GetListByGrupAd(string grupKodAd)
        {
            return new SuccessDataResult<List<SahisCari>>(_sahisCariDal.GetBy().Where(p =>
            _cariGrupService.GetListByCariGrupKodId(
                _cariGrupKodService.GetByAd(grupKodAd).Data.Id).Data.Select(s => s.Id).Contains(p.Id)).ToList());
        }

        public IDataResult<List<SahisCari>> GetListByVergiDairesi(string vergiDairesi)
        {
            return new SuccessDataResult<List<SahisCari>>(_sahisCariDal.GetBy(p => p.VergiDairesi == vergiDairesi));
        }

        public IResult Add(SahisCari cari)
        {
            _cariDal.Add(new Cari { Kod = cari.Kod, Unvan = cari.Unvan, VergiDairesi = cari.VergiDairesi });
            _sahisCariDal.Add(new SahisCari { CariId = _cariDal.Get(p => p.Kod == cari.Kod).Id, TCNo = cari.TCNo });
            return new SuccessResult(Messages.CariInserted);
        }

        public IResult Delete(SahisCari cari)
        {
            _sahisCariDal.Delete(_sahisCariDal.Get(p => p.TCNo == cari.TCNo));
            _cariDal.Delete(_cariDal.Get(p => p.Kod == cari.Kod));
            return new SuccessResult(Messages.CariDeleted);
        }

        public IResult Update(SahisCari cari)
        {
            var updateCari = _sahisCariDal.Get(p => p.TCNo == cari.TCNo);
            updateCari.Kod = cari.Kod;
            updateCari.Unvan = cari.Unvan;
            updateCari.VergiDairesi = cari.VergiDairesi;
            updateCari.TCNo = cari.TCNo;
            _sahisCariDal.Update(updateCari);
            _cariDal.Update(new Cari { Id = updateCari.CariId, Kod = updateCari.Kod, Unvan = updateCari.Unvan, VergiDairesi = updateCari.VergiDairesi });
            return new SuccessResult(Messages.CariUpdated);
        }
    }
}