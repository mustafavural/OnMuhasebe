using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
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

        private Cari GetBaseCari(SahisCari sahisCari)
        {
            return new Cari
            {
                Id = sahisCari.CariId,
                Kod = sahisCari.Kod,
                Unvan = sahisCari.Unvan,
                VergiDairesi = sahisCari.VergiDairesi
            };
        }

        public new void Add(SahisCari sahisCari)
        {
            using (var context = new OnMuhasebeContext())
            {
                var cari = this.GetBaseCari(sahisCari);
                var cariAdded = context.Entry(cari);
                cariAdded.State = EntityState.Added;
                context.SaveChanges();

                sahisCari.CariId = cariAdded.Entity.Id;
                var sahiCariAdded = context.Entry(sahisCari);
                sahiCariAdded.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public new void Delete(SahisCari sahisCari)
        {
            using (var context = new OnMuhasebeContext())
            {
                var sahiCariDeleted = context.Entry(sahisCari);
                sahiCariDeleted.State = EntityState.Deleted;
                context.SaveChanges();

                var cari = this.GetBaseCari(sahisCari);
                var cariDeleted = context.Entry(cari);
                cariDeleted.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public new void Update(SahisCari sahisCari)
        {
            using (var context = new OnMuhasebeContext())
            {
                var cari = this.GetBaseCari(sahisCari);
                var cariUpdated = context.Entry(cari);
                cariUpdated.State = EntityState.Modified;
                context.SaveChanges();

                sahisCari.CariId = cariUpdated.Entity.Id;
                var sahiCariUpdated = context.Entry(sahisCari);
                sahiCariUpdated.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}