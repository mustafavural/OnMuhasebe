using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IStokHareketService : ICRUD<StokHareket>
    {
        IDataResult<List<StokHareket>> GetByFaturaId(int faturaId);
        IDataResult<List<StokHareket>> GetByStokId(int stokId);
        IDataResult<List<StokHareket>> GetByDepoId(int depoId);
        IDataResult<decimal> GetStokMiktar(int stokId);
    }
}