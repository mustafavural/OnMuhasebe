using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IPersonelHareketService : IADU<PersonelHareket>, IGet<PersonelHareket>
    {
        IDataResult<List<PersonelHareket>> GetListByPersonelId(int personelId);
        IDataResult<List<PersonelHareket>> GetListByTur(string tur);
        IDataResult<List<PersonelHareket>> GetListByIslemTarihi(DateTime tarih);
    }
}