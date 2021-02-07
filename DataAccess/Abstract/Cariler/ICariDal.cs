using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICariDal<TEntity> : IEntityRepository<TEntity>
        where TEntity : Cari, new()
    {

    }
}