using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class Strings
    {
        //String ler char olarak çalışırlar yani stringin araylarinde harflere ulaşabiliriz
        public static void AnaKod()
        {
            string  city = "Sivas";
            
            Console.WriteLine(city[0]); // city stringinin 0. indexini yazdırınca S harfi çıkar

            //string Metodları

            string sentence = "benim adım Yasin";
            Console.WriteLine(sentence);
            //*****************************************
            var result = sentence.Length; // .Length kaç karakter varsa onu gösterir. 
            Console.WriteLine(result);
            //*****************************************
            var result2 = sentence.Clone(); // değişkenin yeni bir klonunu yeni bir değişkene atar.
            result2 = "benim adım ahmet";
            Console.WriteLine(result2);
            //*****************************************
            var result3 = sentence.EndsWith("n"); // bu cümle şu karakterle bitiyor mu?
            Console.WriteLine(result3);
            //*****************************************
            var result4 = sentence.StartsWith("a"); // bu cümle şu karakterle başlıyor mu?
            Console.WriteLine(result4);
            //*****************************************
            var result5 = sentence.IndexOf("adım"); // aramaya baştan başlar cümlenin kaçıncı karakteri olduğunu söyler. Bulamazsa -1 döndürür.
            Console.WriteLine(result5);
            //*****************************************
            var result6 = sentence.LastIndexOf("Yasin"); //aramaya sondan başlar cümlenin kaçıncı karakteri olduğunu söyler.
            Console.WriteLine(result6);
            //*****************************************
            var result7 = sentence.Insert(0, "merhaba, "); // metne yeni birşey eklemek için kullanılır.
            Console.WriteLine(result7);
            //*****************************************
            var result8 = sentence.Substring(6); // metni parçalamak için kullanılır. Şu karakterden itibaren al. 
            Console.WriteLine(result8);
            //*****************************************
            var result9 = sentence.Substring(6, 4); // 6. karakterden sonra 4 tane karakter al.
            Console.WriteLine(result9);
            //*****************************************
            var result10 = sentence.ToLower(); // bütün büyük harfleri küçüğe çevirir.
            Console.WriteLine(result10);
            //*****************************************
            var result11 = sentence.ToUpper(); // bütün karakterleri büyük harfe çevirir.
            Console.WriteLine(result11);
            //*****************************************
            var result12 = sentence.Replace(" ", "*"); // karakterleri değiştirmeye yarar. Boşlukları yıldıza çevirdik.
            Console.WriteLine(result12);
            //*****************************************
            var result13 = sentence.Remove(6); //metinden belli bir index ten sonrasını atmak için kullanılır.
            Console.WriteLine(result13);
            //*****************************************
            var result14 = sentence.Remove(6,4); //metinden belli bir index ten sonra kaç tanesini atmak istiyorsak.
            Console.WriteLine(result14);


        }
    }
}
