using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class İfBlokları
    {
        public static void AnaKod()
        {
            //if blokları (Şart blokları) Conditionals

            var number = 15; // bize verilen değeri if bloğunda karşılaştırırız ve duruma göre ne yapacağını belirtiriz.
            
            if (number == 15)// number değişkeninin değerinin 15 e eşit olma durumunda yapması gerekeni if bloğunda belirttik.
            {
                Console.WriteLine("Sayımızın değeri 15 tir");
            }
            else// number değişkeninin istediğimiz şarta uymadığı durumda ne yapması gerektiğini belirttik.
            {
                Console.WriteLine("sayının değeri 15 değildir");
            }
            //if bloğu bu şekildede kullanılabiliyor
            Console.WriteLine(number == 15 ? "Koşul sağlandı" : "Koşul sağlanmadı!!!");
            //: noktadan önceki koşulu sağladığı zaman, : noktadan sonraki koşulu sağlamadığı zaman ekrana yazdırır. 
            Console.ReadLine();
        }
    }
}
