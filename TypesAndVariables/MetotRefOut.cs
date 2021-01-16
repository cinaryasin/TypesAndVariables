using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class MetotRefOut
/*                          !!!Önemli!!!
    (Ref)  ref keyword kullanılırken ref verilecek değişkenin bir değeri olması lazım. 
    (Out) Ama ref ile aynı işi yapan out keyword ünde ise ref verilecek değişkenin bir değeri olmasına gerek yok
    (Ref) Aşağıdaki örnekte number1 e 20 değerini verip ref göndermiştik ve metot içerisinde 45 olarak değişmiş gelmişti.
    (Out) Out komutunda ise number1 e bir değer vermek zorunda değiliz o metotdaki sayıyı otamatik olarak alıp gelecektir.
*/

    {
        public static void AnaKod()
        {
            int number1 = 20;
            int number2 = 50;

            Console.WriteLine("number1 = {0}", number1);

            var topla = Metot1(ref number1, number2);


            Console.WriteLine("number1 = 20 , number2 = 50 .  number1 ref olarak gitti ve yeni değerini aldı geldi toplam = {0}",topla);

            Console.WriteLine("***************************************************************************");
            
            Console.WriteLine("number 1 aslında 20, ama metot1' in içerisine ref olarak gönderildiği için  " + "\n" +
                "oradaki number 1'in yeni değerini aldı ve bir sonraki komutta alttaki değer yazdı = {0}",number1);




            Console.ReadLine();
        }

         static int Metot1(ref int number1, int number2)
        {
            number1 = 45;
            return number1 + number2;
        }
    }
}
