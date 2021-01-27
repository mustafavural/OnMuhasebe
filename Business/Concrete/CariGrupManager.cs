using Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CariGrupManager : ICariGrupService
    {
        public IResult Add(CariGrup cariGrup)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(CariGrup cariGrup)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CariGrup>> GetListByCariGrupKodId(int cariGrupKodId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CariGrup>> GetByCariId(int cariId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(CariGrup cariGrup)
        {
            throw new NotImplementedException();
        }
    }
}