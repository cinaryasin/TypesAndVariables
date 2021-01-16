using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertitance
{
    //Inhertitance 
    //Interface gibi clas içerisine tanımlama yapma zorunluluğumuz yok.
    class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[2] // Customer ve student Person un alt dalları olduğu için Person ilede çağırılabilir.
            {
                new Customer{FirstName = "Yasin", Adress = "Sivas", ID = 1, LastName = "Çınar"},
                new Student{FirstName = "Mahmut", ID = 2 , LastName = "alp" , SchoolNumber = 97},
                //new Person() // interface olsaydı çağıramazdık ama inhertitance olduğu içinde personu ayrı bir şekilde çağırabiliyoruz.
            };
            //Customer customer = new Customer();  Customer veya Student ayrı ayrı bu şekildede çağırılabilir.

            foreach (var persons in person)
            {
                Console.WriteLine(persons.FirstName + " " + persons.LastName + " "+ persons.ID);
                
            }
            //Customer customer = new Customer { 
            //Adress = "Sivas"};
            //Console.WriteLine(customer.Adress);
            // Ayrı özellikleri ayrı ayrı çağırmamız gerekir.
            
            Console.ReadLine();
        }
    }
    class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Customer:Person  // Customer e sen bir personsun dememiz yeterli içerisine aktarım zorunluluğu yok
        //customer in ebeveyni person olur yani customer persondan türer.
    {
        //customer in farklı özellikleri varsa o ayrıca buraya eklenebilir.
        public string Adress { get; set; }

    }

    class Student : Person
    {
        public int SchoolNumber { get; set; }
    }
}
