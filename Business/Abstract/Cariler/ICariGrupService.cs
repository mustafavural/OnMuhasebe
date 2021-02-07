using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICariGrupService : IADU<CariGrup>, IGet<CariGrup>
    {
        IDataResult<List<CariGrup>> GetByCariId(int cariId);
        IDataResult<List<CariGrup>> GetListByCariGrupKodId(int cariGrupKodId);
    }
}