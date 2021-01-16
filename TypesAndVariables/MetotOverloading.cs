using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class MetotOverloading
    {
        public static void AnaKod()
        {

            var sayi2 = multiply(2, 2);
            var sayi3 = multiply(2, 2, 2);
            var sayi4 = multiply(2, 2, 2, 2);
            Console.WriteLine("iki sayının çarpımı = {0}", sayi2);
            Console.WriteLine("üç sayının çarpımı = {0}", sayi3);
            Console.WriteLine("4 sayının çarpımı = {0}", sayi4);




            Console.ReadLine();
        }

        //Çarpma metodu oluşturuluyor
        static int multiply(int number1, int number2) // 2 sayıyı birden çarparken böyle bir metot
        {
            return number1 * number2;

        }
        static int multiply(int number1, int number2, int number3, int number4 = 1)
        {
            //3 sayı girilirse 4. sayı number4 ü otomatik 1 alsın diye number 1 e değer atanmıştır.
            return number1 * number2 * number3 * number4;
        }
    }
}
