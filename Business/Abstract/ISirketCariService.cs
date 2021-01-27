using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISirketCariService
    {
        IDataResult<SirketCari> GetById(int sirketCariId);
        IDataResult<SirketCari> GetByKod(string sirketCariKod);
        IDataResult<SirketCari> GetByUnvan(string sirketCariUnvan);
        IDataResult<SirketCari> GetByVergiNo(string VergiNo);
        IDataResult<List<SirketCari>> GetList();
        IDataResult<List<SirketCari>> GetListByVergiDairesi(string sirketVergiDairesi);
        IDataResult<List<SirketCari>> GetListByGrupKodId(int grupKodId);
        IDataResult<List<SirketCari>> GetListByGrupAd(string grupKodAd);
        IResult Add(SirketCari sirketCari);
        IResult Delete(SirketCari sirketCari);
        IResult Update(SirketCari sirketCari);
    }
}