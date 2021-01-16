using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class intVeriTipi
    {
        public static void AnaKod()
        {
            // int veri tipi
            int number1 = 500000; // number1 burada bir değişkendir. 500000 olarak number1 a bir değer atanmıştır. 
                              //Console.WriteLine(number1); // ekrana yazdırma olarak kullanılır.

            // {} bu komut ile virgülden sonraki 0. 1. 2.vs. indexleri oraya atama yaparız. {} süslü parantezlerin içine indexler girilir.
            Console.WriteLine("number1 değişkeninin değeri {0}", number1);
            Console.ReadLine();
        }
    }
}
