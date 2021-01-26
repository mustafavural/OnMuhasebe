using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFSahisCariDal : EFEntityRepositoryBase<SahisCari, OnMuhasebeContext>, ISahisCariDal
    {

    }
}