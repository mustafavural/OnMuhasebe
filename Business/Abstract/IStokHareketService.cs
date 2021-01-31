using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IStokHareketService
    {
        IDataResult<StokHareket> GetById(int stokHareketId);
        IDataResult<List<StokHareket>> GetByFaturaId(int faturaId);
        IDataResult<List<StokHareket>> GetByStokId(int stokId);
        IDataResult<List<StokHareket>> GetByDepoId(int depoId);
        IDataResult<decimal> GetStokMiktar(int stokId);
        IResult Add(StokHareket stokHareket);
        IResult Delete(StokHareket stokHareket);
        IResult Update(StokHareket stokHareket);
    }
}