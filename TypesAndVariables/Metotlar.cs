using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class Metotlar
    {
        //Metotlar
        public static void AnaKod()
        {
            var toplam1 = 2;
            

            var a = topla2(50, 25);

            Console.WriteLine("toplam1 değişkeninin sonucu ="+" "+toplam1+" "+"topla2 metot sonucu = "+" "+a);
            Console.ReadLine();

        }

        // ayrı bir static oluşturulacak ve burda sabit bir işlem yapılacak kolayca dışarıdan çağırılacak

        static void topla()
        {
            Console.WriteLine("Toplam!!!"); //topla metodunun içerisine Toplam mesajı yazıldı ve anakoddan çağırılacak.
        }

        static int topla2(int sayi1, int sayi2) // topla 2 metoduna 2 değişken atandı
        {
            var toplam = sayi1 + sayi2; // 2 değişkenin ne yapması gerektiği belirtildi.
            Console.WriteLine("Sayıların toplamı = {0}", toplam); //metodun ekrana yazdırılması sağlandı
            return toplam;
           

        }
 
    // void = git bir şeyi yap anlamına gelir
    // satatic int sayıların kullanıldı integer ifadelerde yer alır.
    }
}
