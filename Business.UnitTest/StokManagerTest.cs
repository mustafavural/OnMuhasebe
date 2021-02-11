using Business.Abstract;
using Business.Concrete;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Business.UnitTest
{
    public class StokManagerTest
    {
        Mock<IStokService> _moqStokService;
        Mock<IStokDal> _moqStokDal;
        Mock<IStokGrupService> _moqStokGrupService;
        Mock<IStokGrupKodService> _moqStokGrupKodService;
        List<Stok> _dbStoklar;
        IStokService _stokService;
        Stok s1;

        [SetUp]
        public void Setup()
        {
            _moqStokService = new Mock<IStokService>();
            _moqStokDal = new Mock<IStokDal>();
            _moqStokGrupService = new Mock<IStokGrupService>();
            _moqStokGrupKodService = new Mock<IStokGrupKodService>();
            _stokService = new StokManager(_moqStokDal.Object, _moqStokGrupService.Object, _moqStokGrupKodService.Object);

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
                    Id=3,
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
                    Id=4,
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
                    Id=5,
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
            s1 = new Stok
            {
                Id = 6,
                Kod = "999",
                Barkod = "999999999999",
                Ad = "99999999999",
                KDV = 18,
                Birim = "Kilo",
                Birim2 = "Adet",
                Birim3 = "Paket",
                Birim2Oran = 20,
                Birim3Oran = 0.5m
            };

            _moqStokService.Setup(m => m.GetList()).Returns(new SuccessDataResult<List<Stok>>(_dbStoklar));
            _moqStokService.Setup(m => m.GetById(2)).Returns(new SuccessDataResult<Stok>(_dbStoklar[1]));
            _moqStokService.Setup(m => m.GetByAd("TestStok3")).Returns(new SuccessDataResult<Stok>(_dbStoklar[2]));
            _moqStokService.Setup(m => m.GetByBarkod("78742131354556")).Returns(new SuccessDataResult<Stok>(_dbStoklar[3]));
            _moqStokService.Setup(m => m.GetByKod("183")).Returns(new SuccessDataResult<Stok>(_dbStoklar[0]));
            _moqStokService.Setup(m => m.GetListByKDV(18)).Returns(new SuccessDataResult<List<Stok>>(_dbStoklar.Where(P => P.KDV == 18).ToList()));
            _moqStokService.Setup(m => m.Add(s1)).Returns(new SuccessResult(Messages.SuccessMessages.StokInserted));
            _moqStokService.Setup(m => m.Update(s1)).Returns(new SuccessResult(Messages.SuccessMessages.StokUpdated));
            _moqStokService.Setup(m => m.Delete(s1)).Returns(new SuccessResult(Messages.SuccessMessages.StokDeleted));
        }

        [Test]
        public void Tum_Stoklarý_Listele()
        {
            var stoklar = _stokService.GetList();

            Assert.AreEqual(_dbStoklar, stoklar.Data);
        }

        [Test]
        public void Id_ile_verilen_stogu_getir()
        {
            var stok = _stokService.GetById(2);

            Assert.AreEqual(_dbStoklar[1], stok.Data);
        }

        [Test]
        public void Dogru_Kod_ile_verilen_stogu_getir()
        {
            var stok = _stokService.GetByKod("183");

            Assert.AreEqual(_dbStoklar[0], stok.Data);
        }
        [Test]
        public void Yanlýþ_Kod_ile_verilen_hatayý_getir()
        {
            var stok = _stokService.GetByKod("2048");

            Assert.AreEqual(Messages.ErrorMessages.StokKodNotExists, stok.Message);
        }
        [Test]
        public void Barkod_ile_verilen_stogu_getir()
        {
            var stok = _stokService.GetByBarkod("12111223231333");

            Assert.AreEqual(_dbStoklar[4], stok.Data);
        }
        [Test]
        public void Ad_ile_verilen_stogu_getir()
        {
            var stok = _stokService.GetByAd("TestStok3");

            Assert.AreEqual(_dbStoklar[2], stok.Data);
        }
        [Test]
        public void Stok_Ekle()
        {
            var stok = _stokService.Add(s1);

            Assert.AreEqual(Messages.SuccessMessages.StokInserted, stok.Message);
        }
        [Test]
        public void Stok_Güncelle()
        {
            var stok = _stokService.Update(s1);

            Assert.AreEqual(Messages.SuccessMessages.StokUpdated, stok.Message);
        }
        [Test]
        public void Stok_Sil()
        {
            var stok = _stokService.Delete(s1);

            Assert.AreEqual(Messages.SuccessMessages.StokDeleted, stok.Message);
        }
    }
}