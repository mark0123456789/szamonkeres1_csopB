using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace számonkérés1B_csoport
{
    internal class Program
    {
        public static bool kartya()
        {
            Console.WriteLine("Rendelkezik-e törzsvásárlói kártyával? (igen/nem)");
            string eldontes = Console.ReadLine();
            return eldontes.ToLower() == "igen";
        }

        public static int penz()
        {
            Console.WriteLine("Mekkora a fizetendő összeg?");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void osszeg()
        {
            bool vanKartya = kartya();
            int fizetendoOsszeg = penz();

            if (vanKartya)
            {
                if (fizetendoOsszeg < 10000)
                {
                    Console.WriteLine(fizetendoOsszeg);
                }
                else if (fizetendoOsszeg < 50001)
                {
                    Console.WriteLine(fizetendoOsszeg - (fizetendoOsszeg / 100 * 5));
                }
                else
                {
                    Console.WriteLine(fizetendoOsszeg - (fizetendoOsszeg / 10));
                }
            }
            else
            {
                Console.WriteLine(fizetendoOsszeg);
            }
        }

        static void Main(string[] args)
        {
            osszeg();
        }
    }
}
