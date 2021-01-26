using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISahisCariService : ICariService
    {
        IDataResult<List<SahisCari>> GetListByTCNo(string TCNo);
        IResult Add(SahisCari sahisCari);
        IResult Update(SahisCari sahisCari);
        IResult Delete(SahisCari sahisCari);
    }
}