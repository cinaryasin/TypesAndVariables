using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class MetotOverloading2
    {
        //params Keyword
        public static void AnaKod()
        {
            Console.WriteLine(add(5, 4, 3, 2, 1));//add metoduna params gönderdiğimiz için istediğimiz kadar sayı toplayabiliriz
            Console.ReadLine();
        }
        // params ile int yanına dizi açıyoruz ve birden fazla 10, 20 vs. gibi sayılarla işlem yapmak istersek paramsı kullanırız
        static int add(params int[] numbers) 
        {
            return numbers.Sum();
        }
    }
}
