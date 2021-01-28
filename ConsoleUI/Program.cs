using Business.Abstract;
using Core.Entities;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public class Program
    {
        IStokService stokService;
        IStokGrupKodService stokGrupKodService;
        ISahisCariService sahisCariService;
        public Program(IStokService stokService, IStokGrupKodService stokGrupKodService, ISahisCariService sahisCariService)
        {
            this.stokService = stokService;
            this.stokGrupKodService = stokGrupKodService;
            this.sahisCariService = sahisCariService;
        }

        public void EkranaYaz<T>(List<T> tablo) where T : class, IEntity, new()
        {
            foreach (var satir in tablo)
            {
                foreach (var sutun in satir.GetType().GetProperties())
                {
                    Console.Write(satir.GetType().GetProperty(sutun.Name).GetValue(satir) + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public void EkranaYaz<T>(T satir) where T : class, IEntity, new()
        {
            foreach (var sutun in satir.GetType().GetProperties())
            {
                Console.Write(satir.GetType().GetProperty(sutun.Name).GetValue(satir) + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        public void Run(string[] args)
        {
            //var getList = stokService.GetList();
            //EkranaYaz(getList.Data);
            //var getListByGrupAd = stokService.GetListByGrupAd("MürekkepPüskürtmeli");
            //EkranaYaz(getListByGrupAd.Data);
            //var getListByGrupKod = stokService.GetListByGrupKod(23);
            //EkranaYaz(getListByGrupKod.Data);
            //var getKodList = stokGrupKodService.GetList();
            //EkranaYaz(getKodList.Data);
            //Console.WriteLine(getKodList.Message);
            var getSahisCariList = sahisCariService.GetByTCNo("22178323378");
            EkranaYaz(getSahisCariList.Data);
            Console.WriteLine(getSahisCariList.Message);
        }
    }
}