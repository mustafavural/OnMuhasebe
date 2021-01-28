using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFSirketCariDal : EFEntityRepositoryBase<SirketCari, OnMuhasebeContext>, ISirketCariDal
    {
        public SirketCari GetById(int cariId)
        {
            using (var context = new OnMuhasebeContext())
            {
                var result = from c in context.Cariler
                             join s in context.SirketCariler
                             on c.Id equals s.CariId into newSirketCari
                             from nsc in newSirketCari
                             where nsc.Id == cariId
                             select new SirketCari
                             {
                                 Id = nsc.Id,
                                 Kod = nsc.Kod,
                                 Unvan = nsc.Unvan,
                                 VergiDairesi = nsc.VergiDairesi,
                                 VergiNo = nsc.VergiNo
                             };
                return result.SingleOrDefault();
            }
        }
    }
}