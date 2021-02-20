using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFStokDal : EFEntityRepositoryBase<Stok, OnMuhasebeContext>, IStokDal
    {
        public List<StokGrupKod> GetStokGrupKodlar(int stokId)
        {
            using (var context = new OnMuhasebeContext())
            {
                return context.StokGrupKodlar.Where(p =>
                context.StokGruplar.Where(k => k.StokId == stokId)
                .Select(s => s.StokGrupKodId).Contains(p.Id)).ToList();
            }
        }
    }
}