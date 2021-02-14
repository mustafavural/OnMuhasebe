using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI.EntityTest
{
    public class StoklarDepended : TestBase
    {
        IStokService _stokService;
        public StoklarDepended()
        {
            _stokService = new StokManager(
                new EFStokDal(),
                new StokGrupManager(new EFStokGrupDal()),
                new StokGrupKodManager(new EFStokGrupKodDal(),
                              new StokGrupManager(new EFStokGrupDal())));
        }
    }
    public class StoklarTest : TestBase
    {
        private IStokService _stokService;
        private Stok _stok;

        public StoklarTest(IStokService stokService)
        {
            this._stokService = stokService;
            _stok = new Stok
            {
                Kod = "183",
                Barkod = "8691234567890",
                Ad = "TestStok",
                KDV = 36,
                Birim = "Adet",
                Birim2 = "Adet",
                Birim3 = "Adet",
                Birim2Oran = 1,
                Birim3Oran = 1
            };
        }

        public void StokTestYap()
        {
            #region addDeleteUpdate
            Console.WriteLine(_stokService.Add(_stok).Message);
            var updateIcin = _stokService.GetByKod("183");
            Console.WriteLine(updateIcin.Message);
            updateIcin.Data.Ad = "Değiştirildi";
            Console.WriteLine(_stokService.Update(updateIcin.Data).Message);
            base.EkranaYaz(_stokService.GetById(updateIcin.Data.Id).Data);
            Console.WriteLine(_stokService.Delete(updateIcin.Data).Message);
            #endregion

            Console.WriteLine("getbyAd");
            var getbyad = _stokService.GetByAd("Stok8");
            Console.WriteLine(getbyad.Message);
            base.EkranaYaz(getbyad.Data);

            Console.WriteLine("getbyBarkod");
            var getbyBarkod = _stokService.GetByBarkod("100212545445");
            Console.WriteLine(getbyBarkod.Message);
            base.EkranaYaz(getbyad.Data);

            Console.WriteLine("getList");
            var getList = _stokService.GetList();
            Console.WriteLine(getList.Message);
            base.EkranaYaz(getList.Data);

            Console.WriteLine("getbyGrupAd");
            var getbyGrupAd = _stokService.GetListByGrupAd("KIRMIZI");
            Console.WriteLine(getbyGrupAd.Message);
            base.EkranaYaz(getbyGrupAd.Data);

            Console.WriteLine("getListbyKDV");
            var getListbyKDV = _stokService.GetListByKDV(18);
            Console.WriteLine(getListbyKDV.Message);
            base.EkranaYaz(getListbyKDV.Data);
        }
    }
}