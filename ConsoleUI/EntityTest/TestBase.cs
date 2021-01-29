using Core.Entities;
using System;
using System.Collections.Generic;

namespace ConsoleUI.EntityTest
{
    public class TestBase
    {
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
    }
}
