using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class ArraysÇokBoyutlu
    {
        //Çok Boyutlu arrays
        //Örneğin Dünyadaki ülkeleri, Ülkelerdeki bölgeleri, Bölgelerdeki şehirleri tutmak istersek çok boyutl arrayleri kullanırız

        public static void AnaKod()
        {
            // 3 bölge 2 şehir tanımlamak istiyoruz
            string[,] bölgeler = new string[3, 2]
            {
                {"istanbul","izmir" },
                {"sivas","tokar" },   //3 satırlı 2 sütunlu alanlar oluşturulur
                {"rize","ordu" }
            };
            /* forech ile yazdırılabilir
            foreach (var bölge in bölgeler)
            {
                Console.WriteLine(bölge);

            }*/
            for (int i = 0; i <= bölgeler.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= bölgeler.GetUpperBound(1); j++)
                {
                    Console.WriteLine(bölgeler[i, j]);
                }
                Console.WriteLine("**************");
            }

            Console.ReadLine();

        }

    }
}
