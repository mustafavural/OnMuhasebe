using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ISirketCariService
    {
        IDataResult<SirketCari> GetById(int cariId);
        IDataResult<SirketCari> GetByKod(string cariKod);
        IDataResult<SirketCari> GetByUnvan(string cariUnvan);
        IDataResult<SirketCari> GetByVergiNo(string VergiNo);
        IDataResult<List<SirketCari>> GetList();
        IDataResult<List<SirketCari>> GetListByVergiDairesi(string vergiDairesi);
        IDataResult<List<SirketCari>> GetListByGrupAd(string grupKodAd);
        IResult Add(SirketCari cari);
        IResult Delete(SirketCari cari);
        IResult Update(SirketCari cari);
    }
}