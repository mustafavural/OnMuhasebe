using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFEvrakDal<TEntity> : EFEntityRepositoryBase<TEntity, OnMuhasebeContext>, IEvrakDal<TEntity>
        where TEntity : Evrak, new()
    {

    }
}