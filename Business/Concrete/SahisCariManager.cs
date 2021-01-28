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

        public IDataResult<SahisCari> GetByTCNo(string TCNo)
        {
            return new SuccessDataResult<SahisCari>(_sahisCariDal.Get(p => p.TCNo == TCNo));
        }

        public IDataResult<SahisCari> GetById(int sahisCariId)
        {
            return new SuccessDataResult<SahisCari>(_sahisCariDal.Get(p => p.Id == sahisCariId));
        }

        public IDataResult<SahisCari> GetByKod(string sahisCariKod)
        {
            return new SuccessDataResult<SahisCari>(_sahisCariDal.Get(p => p.Kod == sahisCariKod));
        }

        public IDataResult<SahisCari> GetByUnvan(string sahisCariUnvan)
        {
            return new SuccessDataResult<SahisCari>(_sahisCariDal.Get(p => p.Unvan == sahisCariUnvan));
        }

        public IDataResult<List<SahisCari>> GetList()
        {
            return new SuccessDataResult<List<SahisCari>>(_sahisCariDal.GetAll());
        }

        public IDataResult<List<SahisCari>> GetListByVergiDairesi(string sahisVergiDairesi)
        {
            return new SuccessDataResult<List<SahisCari>>(_sahisCariDal.GetAll(p => p.VergiDairesi == sahisVergiDairesi));
        }

        public IDataResult<List<SahisCari>> GetListByGrupKodId(int grupKodId)
        {
            return new SuccessDataResult<List<SahisCari>>(_sahisCariDal.GetAll(p =>
            _cariGrupService.GetListByCariGrupKodId(grupKodId).Data.Select(s => s.CariId).Contains(p.Id)));
        }

        public IDataResult<List<SahisCari>> GetListByGrupAd(string grupKodAd)
        {
            return new SuccessDataResult<List<SahisCari>>(_sahisCariDal.GetAll(p =>
            _cariGrupService.GetListByCariGrupKodId(_cariGrupKodService.GetByAd(grupKodAd).Data.Id).Data.Select(s => s.Id).Contains(p.Id)));
        }

        public IResult Add(SahisCari sahisCari)
        {
            _sahisCariDal.Add(sahisCari);
            return new SuccessResult(Messages.SahisCariInserted);
        }

        public IResult Delete(SahisCari sahisCari)
        {
            _sahisCariDal.Delete(sahisCari);
            return new SuccessResult(Messages.SahisCariDeleted);
        }

        public IResult Update(SahisCari sahisCari)
        {
            _sahisCariDal.Update(sahisCari);
            return new SuccessResult(Messages.SahisCariUpdated);
        }
    }
}