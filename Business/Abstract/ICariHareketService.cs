using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICariHareketService
    {
        IDataResult<CariHareket> GetById(int cariHareketId);
        IResult Add(CariHareket cariHareket);
        IResult Delete(CariHareket cariHareket);
        IResult Update(CariHareket cariHareket);
        IDataResult<decimal> GetTotalBorcOnCari(int cariId);
        IDataResult<decimal> GetTotalAlacakOnCari(int cariId);
        IDataResult<List<CariHareket>> GetListByCariId(int cariHareketId);
        IDataResult<List<CariHareket>> GetListByDate(DateTime cariHareketTarih);
    }
}