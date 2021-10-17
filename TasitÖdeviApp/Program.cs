using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TasitLib;

namespace TasitÖdeviApp
{
    class Program
    {
        static void Main(string[] args)
        {

            araba arb = new araba();

            int count = 0;

            Console.WriteLine("Kaç tane araba gireceksiniz?");
            count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {

                string dosyaYolu = @"c:\c# araba\araba.txt";
                string metin = System.IO.File.ReadAllText(dosyaYolu);
                Console.Write(metin);
                Console.ReadKey();


                Console.WriteLine("Marka Giriniz: ");
                Convert.ToString(Console.ReadLine());

                Console.WriteLine("Model Giriniz: ");
                Convert.ToString(Console.ReadLine());

                Console.WriteLine("Rengini Giriniz: ");
                Convert.ToString(Console.ReadLine());

                Console.WriteLine("Vites Tipini Giriniz: ");
                Convert.ToString(Console.ReadLine());

                Console.WriteLine("Koltuk Sayısını Giriniz: ");
                Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Yıl Giriniz: ");
                Convert.ToInt32(Console.ReadLine());

            }

        }
    }
}
