using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFStokHareketDal : EFEntityRepositoryBase<StokHareket, OnMuhasebeContext>, IStokHareketDal
    {

    }
}