using Core.Utilities.Result;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ISenetService<TEntity> : IDegerliKagitService<TEntity>
        where TEntity : Senet, new()
    {
        IDataResult<TEntity> GetByKod(string kod);
    }
}