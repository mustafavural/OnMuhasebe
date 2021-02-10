using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IKasaHareketService : IADU<KasaHareket>, IGet<KasaHareket>
    {
        IDataResult<KasaHareket> GetByBelgeNo(string belgeNo);
        IDataResult<List<KasaHareket>> GetListByKasaId(int kasaId);
        IDataResult<List<KasaHareket>> GetListByPersonelId(int personelId);
        IDataResult<List<KasaHareket>> GetListByCariId(int cariId);
        IDataResult<List<KasaHareket>> GetListByGirenMiktar(decimal girenMiktar);
        IDataResult<List<KasaHareket>> GetListByCikanMiktar(decimal cikanMiktar);
        IDataResult<List<KasaHareket>> GetListByTarih(DateTime tarih);
    }
}