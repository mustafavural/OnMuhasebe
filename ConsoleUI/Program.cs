using Business.Abstract;
using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public class Program
    {
        IStokService stokService;
        IStokGrupKodService stokGrupKodService;
        ISahisCariService sahisCariService;
        ISirketCariService sirketCariService;
        public Program(IStokService stokService, IStokGrupKodService stokGrupKodService, ISahisCariService sahisCariService, ISirketCariService sirketCariService)
        {
            this.stokService = stokService;
            this.stokGrupKodService = stokGrupKodService;
            this.sahisCariService = sahisCariService;
            this.sirketCariService = sirketCariService;
        }

        public void EkranaYaz<T>(List<T> tablo) where T : class, IEntity, new()
        {
            foreach (var satir in tablo)
            {
                foreach (var sutun in satir.GetType().GetProperties())
                {
                    Console.Write(satir.GetType().GetProperty(sutun.Name).Name + " ");
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
                Console.Write(satir.GetType().GetProperty(sutun.Name).Name + " ");
                Console.Write(satir.GetType().GetProperty(sutun.Name).GetValue(satir) + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        public void Run(string[] args)
        {
            var deleted = sirketCariService.Delete(new SirketCari { Kod = "33", Unvan = "Yavuz", VergiDairesi = "küçükçekmece", VergiNo = "1234567890" });
            //var getSirketCariList = sirketCariService.GetListByVergiDairesi("küçükçekmece");
            //EkranaYaz(delet);
            Console.WriteLine(deleted.Message);
        }
    }
}