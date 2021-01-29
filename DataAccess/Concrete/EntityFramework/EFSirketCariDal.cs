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
    public class EFSirketCariDal : EFEntityRepositoryBase<SirketCari, OnMuhasebeContext>, ISirketCariDal
    {
        public List<SirketCari> GetBy(Expression<Func<SirketCari, bool>> filter = null)
        {
            using (var context = new OnMuhasebeContext())
            {
                var result = from c in context.Cariler
                             join s in context.SirketCariler
                             on c.Id equals s.CariId
                             select new SirketCari
                             {
                                 Id = s.Id,
                                 CariId = s.CariId,
                                 Kod = c.Kod,
                                 Unvan = c.Unvan,
                                 VergiDairesi = c.VergiDairesi,
                                 VergiNo = s.VergiNo
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}