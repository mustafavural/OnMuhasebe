using Core.Business.Abstract;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IPersonelService : IADU<Personel>, IGet<Personel>
    {
        IDataResult<List<Personel>> GetListByAd(string ad);
        IDataResult<List<Personel>> GetListByIkinciAd(string ikinciAd);
        IDataResult<List<Personel>> GetListBySoyad(string soyad);
        IDataResult<List<Personel>> GetListByTCNo(string tcNo);
        IDataResult<List<Personel>> GetListByCinsiyet(string cinsiyet);
        IDataResult<List<Personel>> GetListByMedeniHal(string medeniHal);
        IDataResult<List<Personel>> GetListByCocukSayisi(int cocukSayisi);
        IDataResult<List<Personel>> GetListByDogumTarihi(DateTime tarih);
        IDataResult<List<Personel>> GetListByKatSayi(int katSayi);
        IDataResult<List<Personel>> GetListByBirim(string birim);
        IDataResult<List<Personel>> GetListByGorev(string gorev);
        IDataResult<List<Personel>> GetListByIzin(int izin);
    }
}