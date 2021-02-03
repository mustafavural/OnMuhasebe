using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICariHareketService : ICRUD<CariHareket>
    {
        IDataResult<decimal> GetTotalBorcOnCari(int cariId);
        IDataResult<decimal> GetTotalAlacakOnCari(int cariId);
        IDataResult<List<CariHareket>> GetListByCariId(int cariHareketId);
        IDataResult<List<CariHareket>> GetListByDate(DateTime cariHareketTarih);
        IDataResult<decimal> GetTotalBakiye(int cariId);
    }
}