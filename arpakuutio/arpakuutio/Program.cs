using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arpakuutio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean lopeta = false;
            Console.WriteLine("Tervetuloa random-generaattoriin!");
            while (lopeta != true) 
            {
                Console.WriteLine("Haetaan seuraavat Random-luvut...");
                randomLuvut();
                Console.WriteLine("Haetaanko luvut uudelleen? K=kyllä/E=ei");
                if (Console.ReadLine().ToUpper() == "E") lopeta = true;
            }
               
        }

        private static void randomLuvut()
        {
            int rLuku = 0, i = 0;
            Random arpa = new Random();
            //silmukka alkaa ja pyörii niin kauan, kuin laskurimuuttuja on alle 100
            while (i < 100)
            {
                rLuku = arpa.Next(1, 3000);
                Console.WriteLine("Silmukan kierroksella {1} randomluku on {0}", rLuku.ToString(), (i + 1).ToString());
                //kasvata silmukkalaskurin arvoa yhdellä per kierros
                i++;
            }
        }
    }
}
