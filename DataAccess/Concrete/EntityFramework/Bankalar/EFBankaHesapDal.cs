using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public class EFBankaHesapDal : EFEntityRepositoryBase<BankaHesap, OnMuhasebeContext>, IBankaHesapDal
    {

    }
}