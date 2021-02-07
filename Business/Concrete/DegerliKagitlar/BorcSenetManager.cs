using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{//TODO:implementasyon eksik
    public class BorcSenetManager : SenetManager<BorcSenet>, IBorcSenetService
    {
        IDegerliKagitDal<BorcSenet> _borcSenetDal;

        public BorcSenetManager(IDegerliKagitDal<BorcSenet> borcSenetDal) : base(borcSenetDal)
        {
            _borcSenetDal = borcSenetDal;
        }

        public IDataResult<List<BorcSenet>> GetByCariIdVerilen(int cariIdVerilen)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BorcSenet>> GetByCikisTarihi(DateTime tarih)
        {
            throw new NotImplementedException();
        }

        public IResult Add(BorcSenet entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(BorcSenet entity)
        {
            throw new NotImplementedException();
        }

        public IResult Update(BorcSenet entity)
        {
            throw new NotImplementedException();
        }
    }
}
