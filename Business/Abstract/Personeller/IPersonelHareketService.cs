using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities;
using System.Collections.Generic;

namespace Business
{
    public interface IPersonelHareketService : ICRUD<PersonelHareket>
    {
        IDataResult<List<PersonelHareket>> GetListByPersonelId(int personelId);
    }
}