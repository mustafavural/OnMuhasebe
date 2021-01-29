using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFSahisCariDal : EFEntityRepositoryBase<SahisCari, OnMuhasebeContext>, ISahisCariDal
    {
        public List<SahisCari> GetBy(Expression<Func<SahisCari, bool>> filter = null)
        {
            using (var context = new OnMuhasebeContext())
            {
                var result = from c in context.Cariler
                             join s in context.SahisCariler
                             on c.Id equals s.CariId
                             select new SahisCari
                             {
                                 Id = s.Id,
                                 CariId = s.CariId,
                                 Kod = c.Kod,
                                 Unvan = c.Unvan,
                                 VergiDairesi = c.VergiDairesi,
                                 TCNo = s.TCNo
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}