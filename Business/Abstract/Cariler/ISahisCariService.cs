using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ISahisCariService : ICariService<SahisCari>, IADU<SahisCari>
    {
        IDataResult<SahisCari> GetByTCNo(string TCNo);
        IDataResult<List<SahisCari>> GetListByGrupAd(string grupKodAd);
    }
}