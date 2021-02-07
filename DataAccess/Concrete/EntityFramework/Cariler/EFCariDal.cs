using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCariDal<TEntity> : EFEntityRepositoryBase<TEntity, OnMuhasebeContext>, ICariDal<TEntity>
        where TEntity : Cari, new()
    {

    }
}