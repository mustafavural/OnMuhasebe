using Core.Utilities.Result;
using Entities;
using System.Collections.Generic;

namespace Business
{
    public interface IPersonelHareketService
    {
        IDataResult<List<Personel>> GetListByPersonelId(int personelId);
    }
}