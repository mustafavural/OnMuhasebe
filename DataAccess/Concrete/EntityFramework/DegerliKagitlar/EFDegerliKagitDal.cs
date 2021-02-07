using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFDegerliKagitDal<TDegerliKagitEntity> : EFEntityRepositoryBase<TDegerliKagitEntity, OnMuhasebeContext>, IDegerliKagitDal<TDegerliKagitEntity>
        where TDegerliKagitEntity : DegerliKagit, new()
    {

    }
}