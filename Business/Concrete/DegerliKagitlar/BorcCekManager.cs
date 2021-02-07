using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{//TODO:implementasyon eksik
    public class BorcCekManager : CekManager<BorcCek>, IBorcCekService
    {
        IDegerliKagitDal<BorcCek> _borcCekDal;

        public BorcCekManager(IDegerliKagitDal<BorcCek> borcCekDal) : base(borcCekDal)
        {
            _borcCekDal = borcCekDal;
        }

        public IDataResult<List<BorcCek>> GetByCariIdVerilen(int cariIdVerilen)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BorcCek>> GetByCikisTarihi(DateTime tarih)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<BorcCek>> GetByHesapId(int hesapId)
        {
            throw new NotImplementedException();
        }

        public IResult Add(BorcCek entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(BorcCek entity)
        {
            throw new NotImplementedException();
        }

        public IResult Update(BorcCek entity)
        {
            throw new NotImplementedException();
        }
    }
}
