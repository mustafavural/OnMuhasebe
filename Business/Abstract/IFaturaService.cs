﻿using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IFaturaService : ICRUD<Fatura>
    {
        IDataResult<Fatura> GetByCariHareketId(int cariHareketeId);
        IDataResult<Fatura> GetByNo(string faturaNo);
        IDataResult<Fatura> GetByPersonelHareketId(int personelHareketId);
        IDataResult<List<Fatura>> GetListByCariId(int cariId);
        IDataResult<List<Fatura>> GetListByKayitTarihi(DateTime tarih);
        IDataResult<List<Fatura>> GetListByTarih(DateTime tarih);
    }
}