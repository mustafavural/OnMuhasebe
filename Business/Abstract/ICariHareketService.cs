using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICariHareketService
    {
        IDataResult<CariHareket> GetById(int cariHareketId);
        IResult Add(CariHareket cariHareket);
        IResult Delete(CariHareket cariHareket);
        IResult Update(CariHareket cariHareket);
    }
}