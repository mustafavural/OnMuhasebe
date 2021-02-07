using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ISahisCariService : ICariService<SahisCari>, IADU<SahisCari>
    {
        IDataResult<SahisCari> GetByTCNo(string TCNo);
    }
}