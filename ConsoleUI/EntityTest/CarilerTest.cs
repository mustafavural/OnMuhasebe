using Business.Abstract;
using Entities.Concrete;
using System;

namespace ConsoleUI.EntityTest
{
    public class CarilerTest : TestBase
    {
        private ISirketCariService _sirketCariService;
        private ISahisCariService _sahisCariService;
        private SahisCari _sahisCari;
        private SirketCari _sirketCari;
        public CarilerTest(ISirketCariService sirketCariService, ISahisCariService sahisCariService)
        {
            this._sirketCariService = sirketCariService;
            this._sahisCariService = sahisCariService;
            this._sirketCari = new SirketCari { Kod = "06-001", Unvan = "Symantec", VergiDairesi = "Sincan", VergiNo = "1234567890" };
            this._sahisCari = new SahisCari { Kod = "35-001", Unvan = "Seyhan VURAL", VergiDairesi = "Alsancak", TCNo = "22178323378" };
        }
        public void SirketTestYap()
        {
            #region addDeleteUpdate
            Console.WriteLine(_sirketCariService.Add(_sirketCari).Message);
            var updateIcin = _sirketCariService.GetByKod("06-001").Data;
            updateIcin.Unvan = "Değiştirildi";
            Console.WriteLine(_sirketCariService.Update(updateIcin).Message);
            base.EkranaYaz(_sirketCariService.GetById(updateIcin.Id).Data);
            Console.WriteLine(_sirketCariService.Delete(updateIcin).Message);
            #endregion

            Console.WriteLine("getbyUnvan");
            base.EkranaYaz(_sirketCariService.GetByUnvan("Mephisto Corp.").Data);

            Console.WriteLine("getbyVergiNo");
            base.EkranaYaz(_sirketCariService.GetByVergiNo("4444444444").Data);

            Console.WriteLine("getList");
            base.EkranaYaz(_sirketCariService.GetList().Data);

            Console.WriteLine("getbyGrupAd");
            base.EkranaYaz(_sirketCariService.GetListByGrupAd("MatbuFatura").Data);

            Console.WriteLine("getbyVergiDairesi");
            base.EkranaYaz(_sirketCariService.GetListByVergiDairesi("selçuk").Data);
        }
        public void SahisTestYap()
        {
            #region addDeleteUpdate
            Console.WriteLine(_sahisCariService.Add(_sahisCari).Message);
            var updateIcin = _sahisCariService.GetByKod("35-001").Data;
            updateIcin.Unvan = "Değiştirildi";
            Console.WriteLine(_sahisCariService.Update(updateIcin).Message);
            base.EkranaYaz(_sahisCariService.GetById(updateIcin.Id).Data);
            Console.WriteLine(_sahisCariService.Delete(updateIcin).Message);
            #endregion

            Console.WriteLine("getbyUnvan");
            base.EkranaYaz(_sahisCariService.GetByUnvan("Mustafa VURAL").Data);

            Console.WriteLine("getbyTCNo");
            base.EkranaYaz(_sahisCariService.GetByTCNo("56789012345").Data);

            Console.WriteLine("getList");
            base.EkranaYaz(_sahisCariService.GetList().Data);

            Console.WriteLine("getbyGrupAd");
            base.EkranaYaz(_sahisCariService.GetListByGrupAd("MatbuFatura").Data);

            Console.WriteLine("getbyVergiDairesi");
            base.EkranaYaz(_sahisCariService.GetListByVergiDairesi("selçuk").Data);
        }
    }
}