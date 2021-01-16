using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class Metot2
    {
        public static void AnaKod()
        {
            var metotTopla = topla(30);//2. parametreye sayı girilmedi default olarak topla metodunun içerisinden alacak

            var metotTopla2 = topla(30, 50); //2. sayı girildi topla metodundaki sayı yok sayılacak


            Console.WriteLine("Default çalışan topla metodundaki sayı ile toplam = {0}", metotTopla);
            Console.WriteLine("2 parametreninde girildikten sonraki sayı ile toplam = {0}", metotTopla2);
            Console.ReadLine();

        }


        // default değerler en sona verilir int number2 = 15 gibi
        static int topla(int number, int number2 = 15) // default bir değişken atandı number 2 de
            //eğer anakod içerisinde number ikiye sayı verilmezse buradaki sayı değerlendirilecek.
        {
            var toplam = number + number2;
            
            return toplam;
        }
    }
}
