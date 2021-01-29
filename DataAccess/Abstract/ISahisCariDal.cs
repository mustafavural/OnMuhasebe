using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ISahisCariDal : IEntityRepository<SahisCari>
    {
        List<SahisCari> GetBy(Expression<Func<SahisCari, bool>> filter = null);
    }
}