using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;


namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfaceDemo1();
            //ICustomerDalcs();
            //ICustomerDalcs2();
            //InterfacesDemo();

            Console.ReadLine();
        }

        private static void InterfacesDemo()
        {
            Interfaces.InterfacesDemo.InterfaceImplamente();
        }

        private static void ICustomerDalcs2()
        {
            ICustomerDal[] customerDals = new ICustomerDal[3] // yeni bir veri tabanı kurup onuda desteklediğimiz zaman buraya rahatlıkla girebiliriz.
                        {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
                        };
            foreach (var customerdal in customerDals)
            {
                customerdal.Add();
                customerdal.Delete();
                customerdal.Update();
            }
        }

        private static void ICustomerDalcs()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfaceDemo1()
        {
            PersonManager personManager = new PersonManager(); // person manager e verdiğimiz IPerson interface i sayesinde hem customer a hem student a ulaştık.
            Customer customer = new Customer // customer içerisindeki verileri girdik
            {
                Id = 1,
                FirstName = "Yasin",
                LastName = "Çınar",
                City = "Sivas"

            };
            Student student = new Student // student içerisindeki verileri girdik.
            {
                Id = 2,
                FirstName = "Alp",
                LastName = "Söndür",
                City = "Ankara"

            };

            personManager.Add(customer);
            personManager.Add(student);
        }
    }

    /*Interface lerin en büyük kullanım amacı Temel nesne oluşturup bütün nesneleri içinde tutmaktır*/

    //interface ise soyut nesnelerdir
    interface IPerson
    {
        //interface içerisine bilgileri tanımladıktan sonra classların yanında 
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string City { get; set; }
    }

    //2 nesne oluşturuyoruz Customer ve Student adlı
    //Bu nesnelere somut nesne denir. Tek başına hiç bir şey ifade etmez
    class Customer : IPerson //classlara gelinir ve sende aynı zamanda bir IPerson sun diyerek interface tanımlanır
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        //studentdaki Id gibi duruyorlar ama daha güzel durması için diğerleri gibi düzeltilebilirler gibi düzeltilebilir.
    }

    class Student : IPerson //classlara gelinir ve sende aynı zamanda bir IPerson sun diyerek interface tanımlanır
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }

    class PersonManager /* yönetici paneli oluşturulurken
                         * Add içerisine customer veya student 
                         * tanımlamak yerine interface olan 
                         * IPerson tanımlanırsa ana kod alanında çağırırken 
                         * customer olarakta çağırsak, student olarakta çağırsak bize istediğimizi verecektir.
                         * Çünkü Interface IPerson her ikisinide içine almaktadır.*/
    {
        public void Add(IPerson person)
        {
            Console.WriteLine((person.Id) + " " + person.FirstName + " " + person.LastName + " " + person.City);
        }
    }
}
