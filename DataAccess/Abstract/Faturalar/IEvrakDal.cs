using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IEvrakDal<TEntity> : IEntityRepository<TEntity>
        where TEntity : Evrak, new()
    {

    }
}