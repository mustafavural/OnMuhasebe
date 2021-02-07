using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{//TODO:implementasyon eksik
    public class MusteriSenetManager : SenetManager<MusteriSenet>, IMusteriSenetService
    {
        IDegerliKagitDal<MusteriSenet> _musteriSenetDal;

        public MusteriSenetManager(IDegerliKagitDal<MusteriSenet> musteriSenetDal) : base(musteriSenetDal)
        {
            _musteriSenetDal = musteriSenetDal;
        }

        public IDataResult<List<MusteriSenet>> GetByAlisTarihi(DateTime tarih)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MusteriSenet>> GetByAsilBorclu(string asilBorclu)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MusteriSenet>> GetByCariIdCiroEden(int cariIdCiroEden)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MusteriSenet>> GetByCariIdCiroEdilen(int cariIdCiroEdilen)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MusteriSenet>> GetByCikisTarihi(DateTime tarih)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MusteriSenet>> GetByHesapIdTahsileVerilen(int hesapIdTahsileVerilen)
        {
            throw new NotImplementedException();
        }

        public IResult Add(MusteriSenet entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(MusteriSenet entity)
        {
            throw new NotImplementedException();
        }

        public IResult Update(MusteriSenet entity)
        {
            throw new NotImplementedException();
        }
    }
}