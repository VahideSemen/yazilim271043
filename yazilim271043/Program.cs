using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilim271043
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 2, 3, 4, 5, 6 };
            string[] isimler = { "Ahmet", "Mehmet", "Hüseyin", "Abdullah", "Kasım" };
            Console.WriteLine(sayilar[0]);
            Console.WriteLine(sayilar[5]);
            Console.WriteLine(sayilar.Length);
            for (int i = 0; i < 6; i++)
            {
                //Console.WriteLine(i);
                Console.WriteLine(isimler[i]);
            }






            Console.ReadKey();
        }
    }
}
