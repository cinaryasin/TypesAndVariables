using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class ForDöngüsü
    {

        //For döngüsü
        /*Belli bir veri kümesini dolaşmak istediğimiz zaman döngülerden yararlanırız.
        *Örneğin 1 den 100 e kadar olan sayıları veya 1 den 100 e kadar olan tek veya 
        çift sayıları ekrana yazdırmak istediğimiz zaman döngülerden yararlanabiliriz.*/

        public static void AnaKod()
        {
            //for (int i = 1; i<=100; i++) ne anlama gelir?
            // (i=1) i 1'e eşit olsun (i<=100) ve i 100'den küçük ve 100'e eşit olana kadar (i++) i'yi 1'er 1'er artır demektir.
            //for döngüsü içerisindeki ilk komut sayacımız yani başlangıç noktamız
            //ikinci komut ise döneceğim ama ne zamana kadar nereye kadar döneceğim anlamına gelir. Sınırlandırma yapılır
            //üçüncü komut ise 1 döngü bittiğinde diğerinde ne yapıyım.
            for (int i = 1; i <= 100; i++)                
            {
                Console.WriteLine(i);
                
            }
            Console.WriteLine("bitti");
            for (int j = 0; j <= 80; j=j+2)
            {
                Console.WriteLine(j);
                Console.WriteLine("2'şer 2'şer");
            }
            
            Console.ReadLine();
        }
    }
}
