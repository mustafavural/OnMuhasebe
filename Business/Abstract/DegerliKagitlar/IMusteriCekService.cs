using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IMusteriCekService : ICekService<MusteriCek>, IADU<MusteriCek>
    {
        IDataResult<List<MusteriCek>> GetByCariIdCiroEden(int cariIdCiroEden);
        IDataResult<List<MusteriCek>> GetByCariIdCiroEdilen(int cariIdCiroEdilen);
        IDataResult<List<MusteriCek>> GetByHesapIdTahsileVerilen(int hesapIdTahsileVerilen);
        IDataResult<List<MusteriCek>> GetByAsilBorclu(string asilBorclu);
        IDataResult<List<MusteriCek>> GetByAlisTarihi(DateTime tarih);
        IDataResult<List<MusteriCek>> GetByCikisTarihi(DateTime tarih);
    }
}