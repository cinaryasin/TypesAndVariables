using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class ForEachDöngüsü
    {
        //Foreach döngüsü dizi temelli dataların dolaşılması için kullanılır
        public static void AnaKod()
        {
            string[] students = { "yasin", "ahmet", "mehmet" };
            students[0] = "ali"; // students ' ın içindeki elemanları foreach döngüsü içerisinde değiştiremeyiz
            //fakat foreach dışında elemanları değiştirebiliriz.
            foreach (var student in students)
            {
                Console.WriteLine(student); // böylelikle students array inin içindeki herşeyi gezecek.
            }

        }
    }
}
