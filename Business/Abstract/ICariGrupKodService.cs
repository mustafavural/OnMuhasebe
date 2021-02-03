using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICariGrupKodService : ICRUD<CariGrupKod>
    {
        IDataResult<CariGrupKod> GetByTur(string cariGrupKodTur);
        IDataResult<CariGrupKod> GetByAd(string cariGrupKodAd);
        IDataResult<List<CariGrupKod>> GetListByCari(int cariId);
    }
}