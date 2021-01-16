using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {/*Değer tipler: int, Double, Byte vb. değer tiplerdir.
          Referans tipler: String, Class, Arrays, Interface referans tipleridir.*/

            //Değer Tipler
            int number1 = 10;
            int number2 = 20;

            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2);

            //Referans Tipler
            string[] cities = new string[] { "Sivas", "Ankara", "Bursa" };
            string[] cities2 = new string[] { "Adıyaman", "Muğla", "Manisa" };
            cities2 = cities;
            cities[0] = "İstanbul";
            Console.WriteLine(cities2[0]);
            Console.ReadLine();
        }
    }
}
