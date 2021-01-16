using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {                                   //Hata Yakalama
        static void Main(string[] args)
        {
            //HataYakalama();//method oluşturuldu

            Console.WriteLine("Hata Yönetimi 2. derste kaldık 20.2");

            Console.ReadLine();

        }



        private static void HataYakalama()
        {
            //verecek hatanın karşılığında ekrana ne vermesi gerektiğini yazıyoruz.
            try
            {//içerisine başarılı olursa yazılacak kodu veriyoruz
                string[] students = new string[3] { "Yasin", "Ahmet", "Asaf" };
                students[3] = "Metin"; // 3. indexinde herhangi birşey olmadığı için haa verecektir.
            }

            catch (Exception exception)//exception ile yeni bir hata kontrol oluşturuyoruz ve aşağıda hatanın mesajını istiyoruz.
            {//başarısız olursada buraya yazıyoruz.
                Console.WriteLine("Hataaaa!!!!!");
                Console.WriteLine(exception.Message);//asıl hatanın ne olduğunu bize gösterir.
                Console.WriteLine(exception.InnerException); // buda varsa daha detaylı bir bilgi verecektir.

            }

            Console.ReadLine();
        }
    }
}
