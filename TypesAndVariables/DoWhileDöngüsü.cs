using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class DoWhileDöngüsü
    {
        // do while döngüsünde önce içeriğe bakar sonra şartı okur
        public static void AnaKod()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;

            } while (number>=0);
            //şartı büyük eşittir 11 yapsaydık do While yine çalışacaktı ama sadece 10' u yazdırıp duracaktı çünkü 10, 11'den küçük.

        }
    }
}
