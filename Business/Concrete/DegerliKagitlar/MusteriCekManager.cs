using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{//TODO:implementasyon eksik
    public class MusteriCekManager : CekManager<MusteriCek>, IMusteriCekService
    {
        IDegerliKagitDal<MusteriCek> _musteriCekDal;
        public MusteriCekManager(IDegerliKagitDal<MusteriCek> musteriCekDal) : base(musteriCekDal)
        {
            _musteriCekDal = musteriCekDal;
        }

        public IDataResult<List<MusteriCek>> GetByAlisTarihi(DateTime tarih)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MusteriCek>> GetByAsilBorclu(string asilBorclu)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MusteriCek>> GetByCariIdCiroEden(int cariIdCiroEden)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MusteriCek>> GetByCariIdCiroEdilen(int cariIdCiroEdilen)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MusteriCek>> GetByCikisTarihi(DateTime tarih)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<MusteriCek>> GetByHesapIdTahsileVerilen(int hesapIdTahsileVerilen)
        {
            throw new NotImplementedException();
        }
        public IResult Add(MusteriCek entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(MusteriCek entity)
        {
            throw new NotImplementedException();
        }

        public IResult Update(MusteriCek entity)
        {
            throw new NotImplementedException();
        }
    }
}