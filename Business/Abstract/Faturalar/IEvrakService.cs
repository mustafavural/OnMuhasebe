using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IEvrakService<TEntity> : IGet<TEntity>
        where TEntity : Evrak, new()
    {
        IDataResult<TEntity> GetByCariHareketId(int cariHareketeId);
        IDataResult<TEntity> GetByPersonelHareketId(int personelHareketId);
        IDataResult<List<TEntity>> GetListByCariId(int cariId);
        IDataResult<List<TEntity>> GetListByPersonelId(int personelId);
        IDataResult<List<TEntity>> GetListByTarih(DateTime tarih);
        IDataResult<List<TEntity>> GetListByKayitTarihi(DateTime tarih);
    }
}