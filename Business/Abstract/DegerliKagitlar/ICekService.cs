using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICekService<TEntity> : IDegerliKagitService<TEntity> where TEntity : Cek, new()
    {
        IDataResult<List<TEntity>> GetByBankaId(int bankaId);
        IDataResult<TEntity> GetByKod(string kod);
    }
}