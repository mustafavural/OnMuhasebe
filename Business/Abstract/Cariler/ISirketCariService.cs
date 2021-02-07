using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ISirketCariService : ICariService<SirketCari>, IADU<SirketCari>
    {
        IDataResult<SirketCari> GetByVergiNo(string VergiNo);
    }
}