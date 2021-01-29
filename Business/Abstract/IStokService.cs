using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IStokService
    {
        IDataResult<Stok> GetById(int stokId);
        IDataResult<List<Stok>> GetList();
        IDataResult<List<Stok>> GetListByGrupKod(int grupKodId);
        IDataResult<List<Stok>> GetListByGrupAd(string grupKodAd);
        IResult Add(Stok stok);
        IResult Update(Stok stok);
        IResult Delete(Stok stok);
    }
}