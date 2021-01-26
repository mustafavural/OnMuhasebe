using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public class Program
    {
        IStokService stokService;
        IStokGrupKodService stokGrupKodService;
        public Program(IStokService stokService, IStokGrupKodService stokGrupKodService)
        {
            this.stokService = stokService;
            this.stokGrupKodService = stokGrupKodService;
        }





        public void Run(string[] args)
        {
            var getList = stokService.GetList();
            ekranayaz(getList.Data);
            var getListByGrupAd = stokService.GetListByGrupAd("MürekkepPüskürtmeli");
            ekranayaz(getListByGrupAd.Data);
            var getListByGrupKod = stokService.GetListByGrupKod(23);
            ekranayaz(getListByGrupKod.Data);
            var getKodList = stokGrupKodService.GetList();
            ekranayaz(getKodList.Data);
            Console.WriteLine(getKodList.Message);
        }




        public void ekranayaz(List<Stok> list)
        {
            foreach (var item in list)
            {
                foreach (var i in item.GetType().GetProperties())
                {
                    Console.Write(item.GetType().GetProperty(i.Name).GetValue(item) + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public void ekranayaz(List<StokGrupKod> list)
        {
            foreach (var item in list)
            {
                foreach (var i in item.GetType().GetProperties())
                {
                    Console.Write(item.GetType().GetProperty(i.Name).GetValue(item) + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
