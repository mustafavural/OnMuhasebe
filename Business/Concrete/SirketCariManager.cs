using Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SirketCariManager : ISirketCariService
    {
        public IResult Add(SirketCari sirketCari)
        {
            throw new NotImplementedException();
        }

        public IResult Add(Cari cari)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(SirketCari sirketCari)
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

        public IDataResult<List<SirketCari>> GetListByVergiNo(string VergiNo)
        {
            throw new NotImplementedException();
        }

        public IResult Update(SirketCari sirketCari)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Cari cari)
        {
            throw new NotImplementedException();
        }
    }
}