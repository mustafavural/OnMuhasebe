using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IMusteriSenetService : ISenetService<MusteriSenet>, IADU<MusteriSenet>
    {
        IDataResult<List<MusteriSenet>> GetByCariIdCiroEden(int cariIdCiroEden);
        IDataResult<List<MusteriSenet>> GetByCariIdCiroEdilen(int cariIdCiroEdilen);
        IDataResult<List<MusteriSenet>> GetByHesapIdTahsileVerilen(int hesapIdTahsileVerilen);
        IDataResult<List<MusteriSenet>> GetByAsilBorclu(string asilBorclu);
        IDataResult<List<MusteriSenet>> GetByAlisTarihi(DateTime tarih);
        IDataResult<List<MusteriSenet>> GetByCikisTarihi(DateTime tarih);
    }
}