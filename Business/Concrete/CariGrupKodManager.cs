using Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CariGrupKodManager : ICariGrupKodService
    {
        public IResult Add(CariGrupKod cariGrupKod)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(CariGrupKod cariGrupKod)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CariGrupKod> GetByAd(string cariGrupKodAd)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CariGrupKod> GetById(int cariGrupKodId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CariGrupKod> GetByTur(string cariGrupKodTur)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CariGrupKod>> GetList()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CariGrupKod>> GetListByCari(int cariId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(CariGrupKod cariGrupKod)
        {
            throw new NotImplementedException();
        }
    }
}