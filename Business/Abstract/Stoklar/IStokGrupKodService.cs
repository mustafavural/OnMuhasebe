using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IStokGrupKodService : IADU<StokGrupKod>, IGet<StokGrupKod>
    {
        IDataResult<StokGrupKod> GetByAd(string stokGrupKodAd);
        IDataResult<List<StokGrupKod>> GetListByTur(string stokGrupKodTur);
        IDataResult<List<StokGrupKod>> GetListByStokId(int stokId);
        IDataResult<StokGrupKod> GetByTurAndAd(string tur, string ad);
    }
}