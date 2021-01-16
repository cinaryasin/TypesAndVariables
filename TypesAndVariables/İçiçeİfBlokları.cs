using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class İçiçeİfBlokları
    {
        //iç içe if blokları
        public static void AnaKod()
        {
            var sayi = 45;

            if (sayi >=0  && sayi<=100)// if bloğu içerisine yeni ifler yazılabilir
            {
                if (sayi>=90 && sayi <=95) //&& ve anlamına gelir || veya anlamına gelir
                {
                    Console.WriteLine("sayi 90 ve 95 arasındadır sayı = {0}",sayi);
                }
                else if (sayi==20 || sayi ==30)
                {
                    Console.WriteLine("sayı 20 veya 30 dur sayı= {0}", sayi);
                }
                else
                {
                    Console.WriteLine("sayı 100 den küçük fakat 90 ve 95 arasında değil sayı = {0}",sayi);
                }

            }
            else
            {
                Console.WriteLine("sayı 100 den büyük veya 0 dan küçük sayı= {0}",sayi);
            }
            Console.ReadLine();
        }
    }
}
