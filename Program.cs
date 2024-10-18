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
            bool vanekartya = false;
            string eldontes = "";
            Console.WriteLine("rendelkezik e törzsvásárlói kártyával");
            eldontes = Console.ReadLine();
            if (eldontes == "igen") vanekartya = true;
           return vanekartya;
        }
        public static int penz()
        {
            int FizetendoOsszeg = 0;
            Console.WriteLine("mekkora a fizetendő összeg?");
            FizetendoOsszeg = Convert.ToInt32(Console.ReadLine());
            return FizetendoOsszeg;
        }
        public static void osszeg()
        {
            if (kartya() == true)
            {
                if (penz() < 10000)
                {
                    Console.WriteLine(penz());
                }
                else if ( penz() < 50001) {
                    Console.WriteLine(penz()-(penz() / 100 * 5));
                }
                else if (penz() > 50001)
                {
                    Console.WriteLine( penz()-(penz() / 10));
                }
            }
            else Console.WriteLine(penz());
        }

        static void Main(string[] args)
        {
            kartya();
            penz();
            osszeg();

        }
    }
}
