using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class ÖrnekUygulamaDöngü
    {
        //Asal sayı

        public static void AnaKod()
        {
            if (AsalSayi(7))
            {
                Console.WriteLine("asal sayıdır");

            }
            else
            {
                Console.WriteLine("asal sayı değildir");
            }
            

        }
        private static bool AsalSayi(int a)
        {

            bool result = true;

            for (int i = 2; i < a - 1; i++)
            {
                if (a % i == 0)
                {
                    result = false;

                }

            }
            return result;
        }

    }
}
