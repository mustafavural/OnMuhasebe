using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ISirketCariService : ICariService<SirketCari>, IADU<SirketCari>
    {
        IDataResult<SirketCari> GetByVergiNo(string VergiNo);
        IDataResult<List<SirketCari>> GetListByGrupAd(string grupKodAd);
    }
}