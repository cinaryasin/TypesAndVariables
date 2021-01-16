using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(25, 50); // !!parantezin içi boşsa değer girmeden çalıştırmış oluruz. Constructors eklersek parametre girebiliriz.
            customerManager.Add();
            customerManager.List();
            //*****************************************************************************************************************************
            Product product = new Product(2, "Computer");
            Console.WriteLine((product.Id) + product.Name);
            StaticConstructor.Static(); // Static tanımlandığı zaman new lemeye gerek kalmaz.
            Console.ReadLine();
        }
    }
    class CustomerManager
    {//ctor yazıp tab a 2 kere tıklanınca constructors eklenir.
        int _count; //bir değer oluşturduk
        int _deger;
        public CustomerManager(int count = 10, int deger = 15) //buradada değer oluşturduk // burada değer vermezsek yukarıda değeri vermemiz istenir.
        {
            _count = count; // _count u count ' a eşitledik. yukarıda çağırdığımız customer manager bizden değer istemeye başladı.
            _deger = deger;
        }
        //constructor ' ları overload da edebiliriz. yani ister parametre girilebilir veya kendi belirlediğimiz parametreyi otomatik yazdırabiliriz.
        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("Listed {0} items ", _count); // sayı olarak kaç verirsek ekranda onu verecek.
        }
        public void Add()
        {
            Console.WriteLine("Added {0} items ", _deger);

        }
         

    }
    class Product
    {
        public Product()
        {

        }
        int _id;
        string _name;
        
        public Product(int id, string name)
        {
            _id = id;
            _name = name;

        }

        public int Id { get; set; }
        public String Name { get; set; }

    }
}
