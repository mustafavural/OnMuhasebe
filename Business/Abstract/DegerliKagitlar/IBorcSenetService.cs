using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IBorcSenetService : ISenetService<BorcSenet>, IADU<BorcSenet>
    {
        IDataResult<List<BorcSenet>> GetListByCariIdVerilen(int cariIdVerilen);
        IDataResult<List<BorcSenet>> GetListByCikisTarihi(DateTime tarih);
    }
}