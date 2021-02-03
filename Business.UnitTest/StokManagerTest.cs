using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace Business.UnitTest
{
    public class StokManagerTest
    {
        Mock<IStokDal> _moqStokDal;
        Mock<IStokGrupService> _moqStokGrupService;
        Mock<IStokGrupKodService> _moqStokGrupKodService;
        List<Stok> _dbStoklar;
        [SetUp]
        public void Setup()
        {
            _moqStokDal = new Mock<IStokDal>();
            _moqStokGrupKodService = new Mock<IStokGrupKodService>();
            _moqStokGrupService = new Mock<IStokGrupService>();
            _dbStoklar = new List<Stok>
            {
                new Stok
                {
                    Id=1,
                    Kod = "183",
                    Barkod = "8691234567890",
                    Ad = "TestStok1",
                    KDV = 18,
                    Birim = "Adet",
                    Birim2 = "Paket",
                    Birim3 = "Koli",
                    Birim2Oran = 0.1m,
                    Birim3Oran = 0.01m
                },
                new Stok
                {
                    Id=2,
                    Kod = "1044",
                    Barkod = "5646541456455",
                    Ad = "TestStok2",
                    KDV = 18,
                    Birim = "Dal",
                    Birim2 = "Paket",
                    Birim3 = "Karton",
                    Birim2Oran = 0.05m,
                    Birim3Oran = 0.005m
                },
                new Stok
                {
                    Id=1,
                    Kod = "767",
                    Barkod = "454423017890",
                    Ad = "TestStok3",
                    KDV = 8,
                    Birim = "Paket",
                    Birim2 = "Adet",
                    Birim3 = "Kilo",
                    Birim2Oran = 30,
                    Birim3Oran = 5
                },
                new Stok
                {
                    Id=1,
                    Kod = "350",
                    Barkod = "78742131354556",
                    Ad = "TestStok4",
                    KDV = 20,
                    Birim = "Paket",
                    Birim2 = "Adet",
                    Birim3 = "Palet",
                    Birim2Oran = 500,
                    Birim3Oran = 0.02m
                },
                new Stok
                {
                    Id=1,
                    Kod = "349",
                    Barkod = "12111223231333",
                    Ad = "TestStok5",
                    KDV = 18,
                    Birim = "Kilo",
                    Birim2 = "Adet",
                    Birim3 = "Paket",
                    Birim2Oran = 20,
                    Birim3Oran = 0.5m
                }
            };
            _moqStokDal.Setup(m => m.GetAll(null)).Returns(_dbStoklar);
            _moqStokDal.Setup(m => m.Get(p=>p.Id==1)).Returns(_dbStoklar[0]);
        }

        [Test]
        public void Tum_Stoklarý_Listele()
        {
            IStokService _stokService = new StokManager(_moqStokDal.Object, _moqStokGrupService.Object, _moqStokGrupKodService.Object);

            IDataResult<List<Stok>> stoklar = _stokService.GetList();

            Assert.AreEqual(5, stoklar.Data.Count);
            Assert.IsInstanceOf<List<Stok>>(stoklar);
            Assert.IsInstanceOf<Stok>(stoklar.Data[0]);
        }

        [Test]
        public void Id_ile_verilen_stogu_getir()
        {
            IStokService _stokService = new StokManager(_moqStokDal.Object, _moqStokGrupService.Object, _moqStokGrupKodService.Object);

            IDataResult<List<Stok>> stoklar = _stokService.GetList();

            Assert.AreEqual(5, stoklar.Data.Count);
            Assert.IsInstanceOf<IDataResult<List<Stok>>>(stoklar);
            Assert.IsInstanceOf<List<Stok>>(stoklar.Data);
            Assert.IsInstanceOf<Stok>(stoklar.Data[0]);
        }
    }
}