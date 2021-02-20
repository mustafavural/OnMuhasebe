using Core.DataAccess;
using Entities.Concrete;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IStokDal : IEntityRepository<Stok>
    {
        List<StokGrupKod> GetStokGrupKodlar(int stokId);
    }
}