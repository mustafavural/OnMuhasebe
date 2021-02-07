using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBankaService : IADU<Banka>, IGet<Banka>
    {
        IDataResult<Banka> GetByAd(string ad);
    }
}