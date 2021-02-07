using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IStokService : IADU<Stok>, IGet<Stok>
    {
        IDataResult<Stok> GetByKod(string stokKod);
        IDataResult<Stok> GetByBarkod(string stokBarkod);
        IDataResult<Stok> GetByAd(string stokAd);
        IDataResult<List<Stok>> GetListByGrupKod(int grupKodId);
        IDataResult<List<Stok>> GetListByGrupAd(string grupKodAd);
        IDataResult<List<Stok>> GetListByKDV(int KDV);
    }
}