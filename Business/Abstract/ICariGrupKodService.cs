using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICariGrupKodService
    {
        IResult Add(CariGrupKod cariGrupKod);
        IResult Update(CariGrupKod cariGrupKod);
        IResult Delete(CariGrupKod cariGrupKod);
        IDataResult<CariGrupKod> GetById(int cariGrupKodId);
        IDataResult<CariGrupKod> GetByTur(string cariGrupKodTur);
        IDataResult<CariGrupKod> GetByAd(string cariGrupKodAd);
        IDataResult<List<CariGrupKod>> GetList();
        IDataResult<List<CariGrupKod>> GetListByCari(int cariId);
    }
}