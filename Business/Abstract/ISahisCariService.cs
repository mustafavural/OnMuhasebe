using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ISahisCariService
    {
        IDataResult<SahisCari> GetById(int sahisCariId);
        IDataResult<SahisCari> GetByKod(string sahisCariKod);
        IDataResult<SahisCari> GetByUnvan(string sahisCariUnvan);
        IDataResult<SahisCari> GetByTCNo(string TCNo);
        IDataResult<List<SahisCari>> GetList();
        IDataResult<List<SahisCari>> GetListByVergiDairesi(string sahisVergiDairesi);
        IDataResult<List<SahisCari>> GetListByGrupKodId(int grupKodId);
        IDataResult<List<SahisCari>> GetListByGrupAd(string grupKodAd);
        IResult Add(SahisCari sahisCari);
        IResult Delete(SahisCari sahisCari);
        IResult Update(SahisCari sahisCari);
    }
}