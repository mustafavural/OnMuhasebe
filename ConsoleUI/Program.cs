using ConsoleUI.EntityTest;
using System;

namespace ConsoleUI
{
    public class Program
    {
        CarilerTest cariTest;
        public Program(CarilerTest cariTest)
        {
            this.cariTest = cariTest;
        }

        public void Run(string[] args)
        {
            cariTest.SirketTestYap();
            Console.WriteLine("Şirket Testi Bitti");
            Console.ReadLine();

            cariTest.SahisTestYap();
            Console.WriteLine("Şahıs Testi Bitti");
            Console.ReadLine();
        }
    }
}