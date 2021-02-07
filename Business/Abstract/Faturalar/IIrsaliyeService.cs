using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IIrsaliyeService : IADU<Irsaliye>
    {
        IDataResult<Irsaliye> GetByCariHareketId(int cariHareketId);
        IDataResult<Irsaliye> GetByNo(string irsaliyeNo);
        IDataResult<Irsaliye> GetByPersonelHareketId(int personelHareketId);
        IDataResult<List<Irsaliye>> GetListByCariId(int cariId);
        IDataResult<List<Irsaliye>> GetListByKayitTarihi(DateTime tarih);
        IDataResult<List<Irsaliye>> GetListByPersonelId(int personelId);
        IDataResult<List<Irsaliye>> GetListByTarih(DateTime tarih);
    }
}