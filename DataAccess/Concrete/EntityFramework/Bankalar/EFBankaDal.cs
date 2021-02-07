using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public class EFBankaDal : EFEntityRepositoryBase<Banka, OnMuhasebeContext>, IBankaDal
    {

    }
}