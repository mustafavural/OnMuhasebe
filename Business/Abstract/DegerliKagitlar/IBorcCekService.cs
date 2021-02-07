using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IBorcCekService : ICekService<BorcCek>, IADU<BorcCek>
    {
        IDataResult<List<BorcCek>> GetListByCariIdVerilen(int cariIdVerilen);
        IDataResult<List<BorcCek>> GetListByHesapId(int hesapId);
        IDataResult<List<BorcCek>> GetListByCikisTarihi(DateTime tarih);
    }
}