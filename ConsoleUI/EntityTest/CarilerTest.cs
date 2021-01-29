using Business.Abstract;
using Entities.Concrete;
using System;

namespace ConsoleUI.EntityTest
{
    public class CarilerTest : TestBase
    {
        private ISirketCariService sirketCariService;
        private ISahisCariService sahisCariService;
        private SahisCari _sahisCari;
        private SirketCari _sirketCari;
        public CarilerTest(ISirketCariService sirketCariService, ISahisCariService sahisCariService)
        {
            this.sirketCariService = sirketCariService;
            this.sahisCariService = sahisCariService;
            this._sirketCari = new SirketCari { Kod = "06-001", Unvan = "Symantec", VergiDairesi = "Kocatepe", VergiNo = "1234567890" };
            this._sahisCari = new SahisCari { Kod = "06-001", Unvan = "Seyhan VURAL", VergiDairesi = "Sincan", TCNo = "22178323378" };
        }
        public void SirketTestYap()
        {
            #region addDeleteUpdate
            Console.WriteLine(sirketCariService.Add(_sirketCari).Message);
            var updateIcin = sirketCariService.GetByKod("06-001").Data;
            updateIcin.Unvan = "Değiştirildi";
            Console.WriteLine(sirketCariService.Update(updateIcin).Message);
            base.EkranaYaz(sirketCariService.GetById(updateIcin.CariId).Data);
            Console.WriteLine(sirketCariService.Delete(updateIcin).Message);
            #endregion

            Console.WriteLine("getbyUnvan");
            base.EkranaYaz(sirketCariService.GetByUnvan("Mephisto Corp.").Data);

            Console.WriteLine("getbyVergiNo");
            base.EkranaYaz(sirketCariService.GetByVergiNo("4444444444").Data);

            Console.WriteLine("getList");
            base.EkranaYaz(sirketCariService.GetList().Data);

            Console.WriteLine("getbyGrupAd");
            base.EkranaYaz(sirketCariService.GetListByGrupAd("MatbuFatura").Data);

            Console.WriteLine("getbyVergiDairesi");
            base.EkranaYaz(sirketCariService.GetListByVergiDairesi("selçuk").Data);
        }
        public void SahisTestYap()
        {
            #region addDeleteUpdate
            Console.WriteLine(sahisCariService.Add(_sahisCari).Message);
            var updateIcin = sahisCariService.GetByKod("06-001").Data;
            updateIcin.Unvan = "Değiştirildi";
            Console.WriteLine(sahisCariService.Update(updateIcin).Message);
            base.EkranaYaz(sahisCariService.GetById(updateIcin.CariId).Data);
            Console.WriteLine(sahisCariService.Delete(updateIcin).Message);
            #endregion

            Console.WriteLine("getbyUnvan");
            base.EkranaYaz(sahisCariService.GetByUnvan("Mustafa VURAL").Data);

            Console.WriteLine("getbyTCNo");
            base.EkranaYaz(sahisCariService.GetByTCNo("56789012345").Data);

            Console.WriteLine("getList");
            base.EkranaYaz(sahisCariService.GetList().Data);

            Console.WriteLine("getbyGrupAd");
            base.EkranaYaz(sahisCariService.GetListByGrupAd("MatbuFatura").Data);

            Console.WriteLine("getbyVergiDairesi");
            base.EkranaYaz(sahisCariService.GetListByVergiDairesi("selçuk").Data);
        }
    }
}