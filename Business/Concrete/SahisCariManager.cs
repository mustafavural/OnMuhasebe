using Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SahisCariManager : ISahisCariService
    {
        public IResult Add(SahisCari sahisCari)
        {
            throw new NotImplementedException();
        }

        public IResult Add(Cari cari)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(SahisCari sahisCari)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Cari cari)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Cari> GetById(int cariId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Cari>> GetList()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Cari>> GetListByGrupAd(string grupKodAd)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Cari>> GetListByGrupKod(int grupKodId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SahisCari>> GetListByTCNo(string TCNo)
        {
            throw new NotImplementedException();
        }

        public IResult Update(SahisCari sahisCari)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Cari cari)
        {
            throw new NotImplementedException();
        }
    }
}