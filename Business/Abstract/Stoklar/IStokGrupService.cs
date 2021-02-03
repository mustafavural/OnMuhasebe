using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IStokGrupService : ICRUD<StokGrup>
    {
        IDataResult<List<StokGrup>> GetByStokId(int stokId);
        IDataResult<List<StokGrup>> GetByStokGrupKodId(int stokGrupKodId);
    }
}