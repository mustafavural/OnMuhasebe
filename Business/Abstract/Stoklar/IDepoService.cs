using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IDepoService : IADU<Depo>, IGet<Depo>
    {
        IDataResult<Depo> GetByAdresId(int adresId);
        IDataResult<Depo> GetByAd(string stokAd);
    }
}