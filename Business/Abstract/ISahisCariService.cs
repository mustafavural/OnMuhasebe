using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ISahisCariService : ICRUD<SahisCari>
    {
        IDataResult<SahisCari> GetByKod(string cariKod);
        IDataResult<SahisCari> GetByUnvan(string cariUnvan);
        IDataResult<SahisCari> GetByTCNo(string TCNo);
        IDataResult<List<SahisCari>> GetListByVergiDairesi(string vergiDairesi);
        IDataResult<List<SahisCari>> GetListByGrupAd(string grupKodAd);
    }
}