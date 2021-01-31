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

        private Cari GetBaseCari(SirketCari sirketCari)
        {
            return new Cari
            {
                Id = sirketCari.CariId,
                Kod = sirketCari.Kod,
                Unvan = sirketCari.Unvan,
                VergiDairesi = sirketCari.VergiDairesi
            };
        }

        public new void Add(SirketCari sirketCari)
        {
            using (var context = new OnMuhasebeContext())
            {
                var cari = this.GetBaseCari(sirketCari);
                var cariAdded = context.Entry(cari);
                cariAdded.State = EntityState.Added;
                context.SaveChanges();

                sirketCari.CariId = cariAdded.Entity.Id;
                var sirketCariAdded = context.Entry(sirketCari);
                sirketCariAdded.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public new void Delete(SirketCari sirketCari)
        {
            using (var context = new OnMuhasebeContext())
            {
                var sirketCariDeleted = context.Entry(sirketCari);
                sirketCariDeleted.State = EntityState.Deleted;
                context.SaveChanges();

                var cari = this.GetBaseCari(sirketCari);
                var cariDeleted = context.Entry(cari);
                cariDeleted.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public new void Update(SirketCari sirketCari)
        {
            using (var context = new OnMuhasebeContext())
            {
                var cari = this.GetBaseCari(sirketCari);
                var cariUpdated = context.Entry(cari);
                cariUpdated.State = EntityState.Modified;
                context.SaveChanges();

                sirketCari.CariId = cariUpdated.Entity.Id;
                var sirketCariUpdated = context.Entry(sirketCari);
                sirketCariUpdated.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}