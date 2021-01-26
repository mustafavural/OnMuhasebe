using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IStokGrupKodService
    {
        IDataResult<StokGrupKod> GetById(int stokGrupKodId);
        IDataResult<StokGrupKod> GetByTur(string stokGrupKodTur);
        IDataResult<StokGrupKod> GetByAd(string stokGrupKodAd);
        IDataResult<List<StokGrupKod>> GetList();
        IDataResult<List<StokGrupKod>> GetListByStok(int stokId);
        IResult Add(StokGrupKod stokGrupKod);
        IResult Update(StokGrupKod stokGrupKod);
        IResult Delete(StokGrupKod stokGrupKod);
    }
}