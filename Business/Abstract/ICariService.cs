using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICariService
    {
        IDataResult<Cari> GetById(int cariId);
        IDataResult<List<Cari>> GetList();
        IDataResult<List<Cari>> GetListByGrupKod(int grupKodId);
        IDataResult<List<Cari>> GetListByGrupAd(string grupKodAd);
        IResult Add(Cari cari);
        IResult Update(Cari cari);
        IResult Delete(Cari cari);
    }
}