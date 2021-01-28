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

        public IResult Add(SahisCari cari)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(SahisCari cari)
        {
            throw new NotImplementedException();
        }

        public IDataResult<SahisCari> GetById(int cariId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<SahisCari> GetByKod(string cariKod)
        {
            throw new NotImplementedException();
        }

        public IDataResult<SahisCari> GetByTCNo(string TCNo)
        {
            throw new NotImplementedException();
        }

        public IDataResult<SahisCari> GetByUnvan(string cariUnvan)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SahisCari>> GetList()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SahisCari>> GetListByGrupAd(string grupKodAd)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SahisCari>> GetListByGrupKodId(int grupKodId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SahisCari>> GetListByVergiDairesi(string vergiDairesi)
        {
            throw new NotImplementedException();
        }

        public IResult Update(SahisCari cari)
        {
            throw new NotImplementedException();
        }
    }
}