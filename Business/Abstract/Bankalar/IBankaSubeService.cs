using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IBankaSubeService : IADU<BankaSube>, IGet<BankaSube>
    {
        IDataResult<BankaSube> GetByAd(string ad);
        IDataResult<List<BankaSube>> GetListByBankaId(int bankaId);
    }
}