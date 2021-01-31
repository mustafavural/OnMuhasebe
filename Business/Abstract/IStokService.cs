using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IStokService
    {
        IDataResult<Stok> GetById(int stokId);
        IDataResult<Stok> GetByKod(string stokKod);
        IDataResult<Stok> GetByBarkod(string stokBarkod);
        IDataResult<Stok> GetByAd(string stokAd);
        IDataResult<List<Stok>> GetList();
        IDataResult<List<Stok>> GetListByGrupKod(int grupKodId);
        IDataResult<List<Stok>> GetListByGrupAd(string grupKodAd);
        IDataResult<List<Stok>> GetListByKDV(int KDV);
        IResult Add(Stok stok);
        IResult Update(Stok stok);
        IResult Delete(Stok stok);
    }
}