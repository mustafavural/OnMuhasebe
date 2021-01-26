using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICariGrupService
    {
        IResult Add(CariGrup cariGrup);
        IResult Update(CariGrup cariGrup);
        IResult Delete(CariGrup cariGrup);
        IDataResult<List<CariGrup>> GetByCariId(int cariId);
        IDataResult<List<CariGrup>> GetByCariGrupKodId(int cariGrupKodId);
    }
}