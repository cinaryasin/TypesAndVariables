using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {//Interfaceler gibi abstrack class larda new lenemez. Alt dalları newlenebilir.
            Database database = new SqlServer(); //ayrı ayrı çağırıyoruz burada SqlServer ı çağırdık
            database.Add();
            database.Delete();
            Console.WriteLine("************************************************************");
            Database database2 = new Oracle(); //ayrı ayrı çağırıyoruz burada Oracle ı çağırdık
            database2.Add();
            database2.Delete();
            Console.WriteLine("************************************************************");
            Console.WriteLine("Her ikisindede Add metodu aynı fakat Delete için\nabstrack çalıştırdığımız için ikisindede delete fonksiyonları\nfarklı olarak çalışmaktadır.");

            Console.ReadLine();

        }
    }

    abstract class Database
    {
        public void Add() // Add fonksiyonunun hepsinde aynı olduğunu ve bütün databaselerin buradan bu kodu çağırabileceğini tekrar yazmamaları gerektiğini gösteriyorum.
        {
            Console.WriteLine("Added by default");
        }
        public abstract void Delete(); // delete fonksiyonunun her database de değişiklik gösterebileceğini belirtiyorum ve buna kod girmiyorum.
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by SqlServer");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
