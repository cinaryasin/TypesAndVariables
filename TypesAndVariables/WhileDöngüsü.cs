using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class WhileDöngüsü
    {
        //while döngüsü
        public static void AnaKod()
        {
            int number = 100;
            while (number>=0) //işlem yapılacak değişkene hangi şartı gerçekleştirene kadar döneceğini söyler
            {
                Console.WriteLine(number);
                number--;// şarta nasıl geleceği belirlenir
            }
        }
    }
}
