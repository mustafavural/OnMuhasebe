using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICariService<TEntity> : IGet<TEntity> where TEntity : Cari, new()
    {
        IDataResult<TEntity> GetByKod(string cariKod);
        IDataResult<TEntity> GetByUnvan(string cariUnvan);
        IDataResult<List<TEntity>> GetListByVergiDairesi(string vergiDairesi);
    }
}