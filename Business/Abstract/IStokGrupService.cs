using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IStokGrupService
    {
        IResult Add(StokGrup stokGrup);
        IResult Update(StokGrup stokGrup);
        IResult Delete(StokGrup stokGrup);
        IDataResult<List<StokGrup>> GetByStokId(int stokId);
        IDataResult<List<StokGrup>> GetByStokGrupKodId(int stokGrupKodId);
    }
}