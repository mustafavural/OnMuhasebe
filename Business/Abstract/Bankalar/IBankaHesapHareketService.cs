using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IBankaHesapHareketService : IADU<BankaHesapHareket>, IGet<BankaHesapHareket>
    {
        IDataResult<List<BankaHesapHareket>> GetListByHesapId(int hesapId);
        IDataResult<List<BankaHesapHareket>> GetListByPersonelHarId(int persnoelHarId);
        IDataResult<List<BankaHesapHareket>> GetListByCariHarId(int cariHarId);
        IDataResult<BankaHesapHareket> GetByBelgeNo(string belgeNo);
        IDataResult<List<BankaHesapHareket>> GetListByGirenMiktar(decimal girenMiktar);
        IDataResult<List<BankaHesapHareket>> GetListByCikanMiktar(decimal cikanMiktar);
        IDataResult<List<BankaHesapHareket>> GetListByTarih(DateTime tarih);
    }
}