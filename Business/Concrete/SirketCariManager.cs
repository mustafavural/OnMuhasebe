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

        public IResult Add(SirketCari cari)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(SirketCari cari)
        {
            throw new NotImplementedException();
        }

        public IDataResult<SirketCari> GetById(int cariId)
        {
            return new SuccessDataResult<SirketCari>(_sirketCariDal.GetById(cariId));
        }

        public IDataResult<SirketCari> GetByKod(string cariKod)
        {
            throw new NotImplementedException();
        }

        public IDataResult<SirketCari> GetByUnvan(string cariUnvan)
        {
            throw new NotImplementedException();
        }

        public IDataResult<SirketCari> GetByVergiNo(string VergiNo)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SirketCari>> GetList()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SirketCari>> GetListByGrupAd(string grupKodAd)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SirketCari>> GetListByGrupKodId(int grupKodId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SirketCari>> GetListByVergiDairesi(string vergiDairesi)
        {
            throw new NotImplementedException();
        }

        public IResult Update(SirketCari cari)
        {
            throw new NotImplementedException();
        }
    }
}