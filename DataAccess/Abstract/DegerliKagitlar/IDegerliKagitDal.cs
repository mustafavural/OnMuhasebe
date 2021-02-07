using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IDegerliKagitDal<TDegerliKagitEntity> : IEntityRepository<TDegerliKagitEntity>
        where TDegerliKagitEntity : DegerliKagit, new()
    {

    }
}