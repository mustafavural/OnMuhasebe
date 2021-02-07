using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IBorcCekService : ICekService<BorcCek>, IADU<BorcCek>
    {
        IDataResult<List<BorcCek>> GetByCariIdVerilen(int cariIdVerilen);
        IDataResult<List<BorcCek>> GetByHesapId(int hesapId);
        IDataResult<List<BorcCek>> GetByCikisTarihi(DateTime tarih);
    }
}