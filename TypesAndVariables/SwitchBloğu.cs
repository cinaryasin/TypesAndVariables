using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class SwitchBloğu
    {
        public static void AnaKod()
        {
            //switch bloğu
            var number = 25; // number değişkeni tanımlandı

            switch (number) // burada karşılaştırılacak değişken verilir.
            {
                case 10: // case ile değişkenin şartı sağlayıp sağlamadığı kontrol edilir.
                    Console.WriteLine("sayı {0} dur",number); // şart sağlıyorsa ekrana yazdırır.
                    break; // Bu şart alanını keser 
                case 25: // case ile değişkenin şartı sağlayıp sağlamadığı kontrol edilir.
                    Console.WriteLine("sayı {0} dir",number);
                    break;
                default: //default hiç biri uymadığı zaman default komutu devreye girer.
                    Console.WriteLine("şart sağlanmadı");
                    break; // program sonlanır

            }



            Console.ReadLine();
        }
    }
}
