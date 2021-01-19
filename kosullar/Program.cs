using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kosullar
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama if/else

            ////Koşul ifadeleri mutlaka bool sonuç oluşturmalı
            //int sayi = 15;

            //if (sayi>10)
            //{
            //    Console.WriteLine("Sayı 10dan büyüktür.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı 10dan küçüktür.");
            //}

            #endregion

            #region if/else uygulama

            //Console.WriteLine("Lütfen bir sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi > 10)
            //{
            //    Console.WriteLine("Sayı 10'dan büyüktür.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı 10'dan küçüktür.");
            //}

            #endregion

            #region uygulama

            //Console.WriteLine("Lütfen bölmek isteğiniz bir sayı giriniz:");
            //double sayi1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());
            //if(sayi2==0)
            //{
            //    Console.WriteLine("Sıfıra bölme tanımsızdır!");
            //}
            //else
            //{
            //    Console.WriteLine(sayi1/sayi2);
            //}

            #endregion

            #region uygulama

            //Console.WriteLine("Bir sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi>20 && sayi<40)
            //{
            //    Console.WriteLine("Sayı birinci aralıktadır.");
            //}
            //else if (sayi>50 && sayi<70)
            //{
            //    Console.WriteLine("Sayı ikinci aralıktadır.");
            //}
            //else if (sayi>60 && sayi<80)
            //{
            //    Console.WriteLine("Sayı üçüncü araıktadır.");
            //}
            //else
            //Console.WriteLine("Sayı tanımlı aralıklarda değildir.");


            #endregion

            #region kullanıcıdan alınan sayı çift mi?

            //Console.WriteLine("bir sayı giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine("sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("sayı tektir.");
            //}

            #endregion

            #region sayı 0-100 arasındaki sayı çift mi?

            Console.WriteLine("0 ile 100 arasında bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi>0 && sayi<100)
            {
                if(sayi % 2 == 0)
                {
                    Console.WriteLine("Sayı çifttir.");
                }
                else
                {
                    Console.WriteLine("Sayı tektir.");
                }
            }
            else

            {
                Console.WriteLine("Sayı aralıkta değildir.");
            }
            #endregion

           
        }
    }
}
