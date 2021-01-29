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
    public class CariGrupKodManager : ICariGrupKodService
    {
        ICariGrupKodDal _cariGrupKodDal;
        ICariGrupService _cariGrupService;

        public CariGrupKodManager(ICariGrupKodDal cariGrupKodDal, ICariGrupService cariGrupService)
        {
            _cariGrupKodDal = cariGrupKodDal;
            _cariGrupService = cariGrupService;
        }

        public IResult Add(CariGrupKod cariGrupKod)
        {
            _cariGrupKodDal.Add(cariGrupKod);
            return new SuccessResult(Messages.CariGrupKodAdded);
        }

        public IResult Delete(CariGrupKod cariGrupKod)
        {
            _cariGrupKodDal.Delete(cariGrupKod);
            return new SuccessResult(Messages.CariGrupKodUpdated);
        }

        public IResult Update(CariGrupKod cariGrupKod)
        {
            _cariGrupKodDal.Update(cariGrupKod);
            return new SuccessResult(Messages.CariGrupKodDeleted);
        }
        public IDataResult<CariGrupKod> GetById(int cariGrupKodId)
        {
            return new SuccessDataResult<CariGrupKod>(_cariGrupKodDal.Get(p => p.Id == cariGrupKodId));
        }

        public IDataResult<CariGrupKod> GetByAd(string cariGrupKodAd)
        {
            return new SuccessDataResult<CariGrupKod>(_cariGrupKodDal.Get(p => p.Ad == cariGrupKodAd));
        }

        public IDataResult<CariGrupKod> GetByTur(string cariGrupKodTur)
        {
            return new SuccessDataResult<CariGrupKod>(_cariGrupKodDal.Get(p => p.Tur == cariGrupKodTur));
        }

        public IDataResult<List<CariGrupKod>> GetList()
        {
            return new SuccessDataResult<List<CariGrupKod>>(_cariGrupKodDal.GetAll());
        }

        public IDataResult<List<CariGrupKod>> GetListByCari(int cariId)
        {
            return new SuccessDataResult<List<CariGrupKod>>(_cariGrupKodDal.GetAll(p =>
            _cariGrupService.GetByCariId(cariId).Data.Select(s => s.CariId).Contains(cariId)));
        }
    }
}