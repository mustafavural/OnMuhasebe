using Business.Abstract;
using System;

namespace ConsoleUI.EntityTest
{
    public class EvraklarTest : TestBase
    {
        private IFaturaService _faturaService;
        //private Fatura _fatura;

        public EvraklarTest(IFaturaService faturaService)
        {
            this._faturaService = faturaService;
        }

        public void FaturaTestYap()
        {
            Console.WriteLine("getList");
            var getList = _faturaService.GetList();
            Console.WriteLine(getList.Message);
            base.EkranaYaz(getList.Data);
        }
    }
}
