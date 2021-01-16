using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class EnumVeriTipi
    {
        public static void AnaKod()
        {
            //Enum Veri Tipi

            //if değişkeni içerisinde enum değişkeni kullanımı yazarken kolaylık sağlar
            //if (Names.yasin==yasin)// gibi dışarıdan çağırılabilir
            //{

            //}
            Console.WriteLine(Names.yasin);// ekrana bu şekilde de yazdırılabilir.
            Console.ReadLine();
            
        }
        //enum dışarıda belli başlı gün, ay, yıl, isimler vs gibi birden fazla metinleri tutmaya yarar.
        // daha sonra içeride if değişkeniyle veya farklı bi şekilde içeride kullanılmaya yarar.
        enum Names
        {
            yasin, ahmet, mehmet, ali

        }
    }
}
