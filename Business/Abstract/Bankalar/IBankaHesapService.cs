using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IBankaHesapService : IADU<BankaHesap>, IGet<BankaHesap>
    {
        IDataResult<BankaHesap> GetByAd(string ad);
        IDataResult<BankaHesap> GetByNo(string no);
        IDataResult<BankaHesap> GetByIBAN(string iban);
        IDataResult<List<BankaHesap>> GetListByMusteriYetkili(string musteriYetkili);
        IDataResult<List<BankaHesap>> GetListBySubeId(int subeId);
    }
}