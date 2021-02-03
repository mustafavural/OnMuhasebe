using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ISirketCariService : ICRUD<SirketCari>
    {
        IDataResult<SirketCari> GetByKod(string cariKod);
        IDataResult<SirketCari> GetByUnvan(string cariUnvan);
        IDataResult<SirketCari> GetByVergiNo(string VergiNo);
        IDataResult<List<SirketCari>> GetListByVergiDairesi(string vergiDairesi);
        IDataResult<List<SirketCari>> GetListByGrupAd(string grupKodAd);
    }
}