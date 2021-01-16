using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        //Arrays ' de bir liste oluşturduğumuzda ona yeni bir eleman eklemek istediğimizde zorlanacağımız için collection lar kullanılmaktadır.
        // collections kullanırken içerisine yeni bir veri(eleman) eklemek daha kolay olacaktır.
        static void Main(string[] args)

        {
            //ArrayList ile collections örneğimiz.
            ArrayList();

            //Dışarıdan bir sınıfı liste olarak kullanma.
            CustomerList.ClassList();

            //Tip güvenli koleksiyon (generic collections) ile çalışma
            GenericList();


            ListMethodss.ListMetotlar();

            Console.ReadLine();
        }

        public class ListMethodss
        {
            public static void ListMetotlar()
            {

                List<ListMetod> listMetods = new List<ListMetod>
                {
                    new ListMetod { Id = 1, FirstName = "Yasin" },
                    new ListMetod { Id = 2, FirstName = "Ali" },
                    new ListMetod { Id = 3, FirstName = "Ahmet" },
                    new ListMetod { Id = 4, FirstName = "Can" }
                };

                listMetods.Add(new ListMetod { FirstName = "Mehemet", Id = 5 }); // Listeye yeni ekleme yaparken kullanılır
                var YeniEleman = new ListMetod// bir değişken üzerinden ekleme yapıyoruz değişken ismini add. içerisinde kullanacağız.
                {
                    FirstName = "Salih",
                    Id = 6
                };
                listMetods.Add(YeniEleman);// değişkeni atayarak ekleme yaptık
                
                var count = listMetods.Count; //Listedeki eleman sayısını gösterir.
                Console.WriteLine(count);

            }

            

            public class ListMetod
            {
                public int Id { get; set; }
                public string FirstName { get; set; }
            }
        }

        public class CustomerList
        {
            public static void ClassList()
            {
                //Bu şekilde classı liste olarak kullanabilir ve içerisine veri girebiliriz.


                //List<Customer> customers = new List<Customer>();
                //customers.Add(new Customer { Id = 1, FirstName = "Yasin" });
                //customers.Add(new Customer { Id = 2, FirstName = "Ali" });
                //customers.Add(new Customer { Id = 3, FirstName = "Ahmet" });
                //customers.Add(new Customer { Id = 4, FirstName = "Can" });
                //Yukarıdaki kodların farklı yazılış tekniği
                List<Customer> customers = new List<Customer>
                {
                    new Customer { Id = 1, FirstName = "Yasin" },
                    new Customer { Id = 2, FirstName = "Ali" },
                    new Customer { Id = 3, FirstName = "Ahmet" },
                    new Customer { Id = 4, FirstName = "Can" }
                };

                foreach (var customer in customers)
                {
                    Console.Write(customer.Id + "  ");
                    Console.WriteLine(customer.FirstName);
                }
            }

            public class Customer
            {
                public int Id { get; set; }
                public string FirstName { get; set; }
            }
        }



        private static void GenericList()
        {
            // tip güvenli koleksiyonlarda veri tipi ne ise ona göre veri girilir. str ise str girmek zorundayız.int bir veri girersek hata verecektir.
            //List<string> cities = new List<string>();
            //cities.Add("Ankara");
            //cities.Add("Sivas");
            //cities.Add("İstanbul");
            //Yukarıdaki kodların farklı yazılış tekniği
            List<string> cities = new List<string>
            {
                "Ankara",
                "Sivas",
                "İstanbul"
            };

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }


        private static void ArrayList()
        {
            //ArrayList bir collections örneğidir. Bir Liste oluşturuyoruz ve içerisine istediğimiz kadar eleman atabiliyoruz.
            //ArrayList cities = new ArrayList();
            //cities.Add("ankara"); // eleman atma işlemi.
            //cities.Add("istanbul");
            //cities.Add("sivas");
            //cities.Add(1); // rakam ve harf eklemesi yapabiliriz.
            //cities.Add('B');
            //Yukarıdaki kodların farklı yazılış tekniği 
            ArrayList cities = new ArrayList
            {
                "ankara", // eleman atma işlemi.
                "istanbul",
                "sivas",
                1, // rakam ve harf eklemesi yapabiliriz.
                'B'
            };

            foreach (var city in cities) // foreach döngüsü ile listeyi geziyoruz.
            {
                Console.WriteLine(city);
            }
        }
    }
}
