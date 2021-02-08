using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IMusteriSenetService : ISenetService<MusteriSenet>, IADU<MusteriSenet>
    {
        IDataResult<List<MusteriSenet>> GetListByCariIdCiroEden(int cariIdCiroEden);
        IDataResult<List<MusteriSenet>> GetListByCariIdCiroEdilen(int cariIdCiroEdilen);
        IDataResult<List<MusteriSenet>> GetListByHesapIdTahsileVerilen(int hesapIdTahsileVerilen);
        IDataResult<List<MusteriSenet>> GetListByAsilBorclu(string asilBorclu);
        IDataResult<List<MusteriSenet>> GetListByAlisTarihi(DateTime tarih);
        IDataResult<List<MusteriSenet>> GetListByCikisTarihi(DateTime tarih);
    }
}