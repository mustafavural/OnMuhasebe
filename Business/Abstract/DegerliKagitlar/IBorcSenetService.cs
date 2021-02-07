using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IBorcSenetService : ISenetService<BorcSenet>, IADU<BorcSenet>
    {
        IDataResult<List<BorcSenet>> GetByCariIdVerilen(int cariIdVerilen);
        IDataResult<List<BorcSenet>> GetByCikisTarihi(DateTime tarih);
    }
}