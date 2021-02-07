using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IMusteriCekService : ICekService<MusteriCek>, IADU<MusteriCek>
    {
        IDataResult<List<MusteriCek>> GetListByCariIdCiroEden(int cariIdCiroEden);
        IDataResult<List<MusteriCek>> GetListByCariIdCiroEdilen(int cariIdCiroEdilen);
        IDataResult<List<MusteriCek>> GetListByHesapIdTahsileVerilen(int hesapIdTahsileVerilen);
        IDataResult<List<MusteriCek>> GetListByAsilBorclu(string asilBorclu);
        IDataResult<List<MusteriCek>> GetListByAlisTarihi(DateTime tarih);
        IDataResult<List<MusteriCek>> GetListByCikisTarihi(DateTime tarih);
    }
}