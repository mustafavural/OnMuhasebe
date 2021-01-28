using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ISahisCariService
    {
        IDataResult<SahisCari> GetById(int cariId);
        IDataResult<SahisCari> GetByKod(string cariKod);
        IDataResult<SahisCari> GetByUnvan(string cariUnvan);
        IDataResult<SahisCari> GetByTCNo(string TCNo);
        IDataResult<List<SahisCari>> GetList();
        IDataResult<List<SahisCari>> GetListByVergiDairesi(string vergiDairesi);
        IDataResult<List<SahisCari>> GetListByGrupKodId(int grupKodId);
        IDataResult<List<SahisCari>> GetListByGrupAd(string grupKodAd);
        IResult Add(SahisCari cari);
        IResult Delete(SahisCari cari);
        IResult Update(SahisCari cari);
    }
}