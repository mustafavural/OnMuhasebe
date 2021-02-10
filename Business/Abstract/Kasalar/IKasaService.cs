using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IKasaService : IADU<Kasa>, IGet<Kasa>
    {
        IDataResult<Kasa> GetByAd(string ad);
    }
}