using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IStokGrupService : IADU<StokGrup>, IGet<StokGrup>
    {
        IDataResult<StokGrup> GetByBothId(int stokId, int stokGrupKodId);
        IDataResult<List<StokGrup>> GetListByStokId(int stokId);
        IDataResult<List<StokGrup>> GetListByStokGrupKodId(int stokGrupKodId);
    }
}