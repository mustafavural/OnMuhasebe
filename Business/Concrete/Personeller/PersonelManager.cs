using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class PersonelManager : IPersonelService
    {//TODO:implementasyon eksik
        IPersonelDal _personelDal;

        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public IDataResult<PersonelHareket> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<PersonelHareket>> GetList()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Personel>> GetListByAd(string ad)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Personel>> GetListByBirim(string birim)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Personel>> GetListByCinsiyet(string cinsiyet)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Personel>> GetListByCocukSayisi(int cocukSayisi)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Personel>> GetListByDogumTarihi(DateTime tarih)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Personel>> GetListByGorev(string gorev)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Personel>> GetListByIkinciAd(string ikinciAd)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Personel>> GetListByIzin(int izin)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Personel>> GetListByKatSayi(int katSayi)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Personel>> GetListByMedeniHal(string medeniHal)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Personel>> GetListBySoyad(string soyad)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Personel>> GetListByTCNo(string tcNo)
        {
            throw new NotImplementedException();
        }
        public IResult Add(PersonelHareket entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(PersonelHareket entity)
        {
            throw new NotImplementedException();
        }

        public IResult Update(PersonelHareket entity)
        {
            throw new NotImplementedException();
        }
    }
}