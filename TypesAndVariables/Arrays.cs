using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class Arrays

    {
        //Array (Diziler)
        public static void AnaKod()
        {
            string[] students = new string[3]; //kaç elemanlı olduğu belirlenir
            students[0] = "yasin"; //students array inin 1. elemanı yani 0. indexi
            students[1] = "asaf";
            students[2] = "metin";
            //toplamda kaç eleman tanımladıysak o kadar elemanı veriyoruz
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            //Array farklı şekilde tanımlama

            Console.WriteLine("***********************");

            string[] students2 ={ "Asaf", "Metin", "Yasin" };
            //string[] students2 = new[] { "Asaf", "Metin", "Yasin" }; //Bu şekilde de yazılabilir
            //string[] students = new string[3] { "Asaf", "Metin", "Yasin" }; // bu şekildede tanımlanabilir

            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }
            Console.ReadLine();

        }
    }
}
