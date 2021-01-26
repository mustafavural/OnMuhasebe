using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISirketCariService : ICariService
    {
        IDataResult<List<SirketCari>> GetListByVergiNo(string VergiNo);
        IResult Add(SirketCari sirketCari);
        IResult Update(SirketCari sirketCari);
        IResult Delete(SirketCari sirketCari);
    }
}