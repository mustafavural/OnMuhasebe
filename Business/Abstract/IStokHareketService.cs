using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IStokHareketService
    {
        IDataResult<StokHareket> GetById(int stokHareketId);
        IDataResult<List<StokHareket>> GetByFaturaId(int faturaId);
        IDataResult<List<StokHareket>> GetByStokId(int stokId);
        IDataResult<List<StokHareket>> GetByDepoId(int depoId);
        IResult Add(StokHareket stokHareket);
        IResult Delete(StokHareket stokHareket);
        IResult Update(StokHareket stokHareket);
    }
}