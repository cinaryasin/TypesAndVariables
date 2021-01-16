using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class ElseifBlokları
    {
        public static void AnaKod()
        {
            //Else if bloğu
            //if bloğundaki şart sağlanmazsa yeni bir şart daha girilmek istenirse Else if bloğu üzerinde işlem yapılır.

            var sayi = 5;// şartı sağlıyacak olan değişken

            if (sayi == 4)
            {
                Console.WriteLine("if şartı sağlandı {0}",sayi);
            }
            else if (sayi == 5 )
            {
                Console.WriteLine("else if şartı sağlandı {0}",sayi);

            }
            else
            {
                Console.WriteLine("şart sağlanmadı");
            }
            Console.ReadLine();
        }
    }
}
